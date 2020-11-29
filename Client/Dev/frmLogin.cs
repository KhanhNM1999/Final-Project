using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUser.Text = "";
            txtUser.Focus();
        }
        MasterDataContext db = new MasterDataContext();
        Customer_Information objCus;
        client objClient;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                objCus = db.Customer_Informations.SingleOrDefault(p => p.username == txtUser.Text.Trim());
                objClient = db.clients.SingleOrDefault(p => p.clientName.Contains(Environment.MachineName));
                if (objClient == null)
                {
                    MessageBox.Show("Vui lòng tạo tên máy trong hệ thống trước khi login.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (objCus != null)
                {
                    db.Refresh(RefreshMode.KeepChanges, objCus);
                    if (objCus.currentMoney.GetValueOrDefault() > 0)
                    {
                        if (db.Login_Customers.Where(p => p.idCus == objCus.idCus).Count() > 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang được login tại một máy khác.Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }

                        var objLogin_Cus = new Login_Customer();
                        objLogin_Cus.idClient = objClient.idClient;
                        objLogin_Cus.idCus = objCus.idCus;
                        objLogin_Cus.startTime = DateTime.Now;
                        db.Login_Customers.InsertOnSubmit(objLogin_Cus);
                        db.SubmitChanges();

                        Properties.Settings.Default.idCus = objCus.idCus;
                        Properties.Settings.Default.idLoginCus = objLogin_Cus.ID;
                        Properties.Settings.Default.idClient = objClient.idClient;
                        Properties.Settings.Default.Save();


                        this.Hide();
                        using (var frm = new frmMain())
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn hiện không đủ để đăng nhập.Vui lòng nạp thêm tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtUser.Focus();
                    }
                }
                else
                {
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi:" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
