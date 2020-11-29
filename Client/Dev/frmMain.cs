using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width + 6;
            this.Top = 0;
            objLoginCus = db.Login_Customers.SingleOrDefault(p => p.ID == Properties.Settings.Default.idLoginCus);
            dispatcherTimer = new Timer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = 1000;
            dispatcherTimer.Start();
        }
        Timer dispatcherTimer;
        MasterDataContext db = new MasterDataContext();
        Customer_Information objCus;
        client objClient;
        Login_Customer objLoginCus;
        decimal TongTienOrder = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.idCus > 0)
                {
                    objClient = db.clients.SingleOrDefault(p => p.clientName.Contains(Environment.MachineName));
                    objCus = db.Customer_Informations.FirstOrDefault(p => p.idCus == Properties.Settings.Default.idCus);
                    this.Text = objCus.name.ToUpper();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.idCus > 0)
                {
                    
                    db.Refresh(RefreshMode.KeepChanges, objCus);
                    spinPrice.EditValue = db.funCheckPrice(objClient.idClient).GetValueOrDefault();

                    txtTimePlay.Text = db.funConvertTime(SqlMethods.DateDiffSecond(objLoginCus.startTime, db.funGetdate()));

                    spinMoney.EditValue = string.Format("{0}", SqlMethods.DateDiffSecond(objLoginCus.startTime, db.funGetdate()) * (db.funCheckPrice(objClient.idClient) / 3600));
                    spinCurrentMoney.EditValue = objCus.currentMoney.GetValueOrDefault();
                    txtEndtime.Text = db.funConvertTime((int)(objCus.currentMoney.GetValueOrDefault() * 3600 / db.funCheckPrice(objClient.idClient).GetValueOrDefault()));
                    //if (objClient.IsExit == true)
                    //{
                    //    if (objLoginCus != null)
                    //    {
                    //        db.Login_Customers.DeleteOnSubmit(objLoginCus);
                    //        db.SubmitChanges();
                    //    }
                    //    System.Diagnostics.Process.Start("shutdown", "-s -f -t 5"); 
                    //}
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (var frm = new frmGoiMon())
            {
                frm.ShowDialog();
                TongTienOrder += frm.TongTien;
                spinService.EditValue = TongTienOrder;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if(objLoginCus != null)
                {
                    db.Login_Customers.DeleteOnSubmit(objLoginCus);
                    db.SubmitChanges();
                }
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Chat_Form cf = new Chat_Form();
            cf.ShowDialog();
        }
    }
}
