using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev
{
    public partial class frmGoiMon : Form
    {
        public frmGoiMon()
        {
            InitializeComponent();
        }
        MasterDataContext db = new MasterDataContext();
        List<ListMenuResult> ltData;
        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            try
            {
                ltData = db.ListMenu().ToList();

                gcData.DataSource = ltData;
            }
            catch { }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public decimal TongTien = 0;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gcData.Update();
                foreach (ListMenuResult item in ltData)
                {
                    if (item.ckChon == true & item.SoLuong > 0)
                    {
                        var objDetail = new Order_Detail();
                        objDetail.idClient = Properties.Settings.Default.idClient;
                        objDetail.idCus = Properties.Settings.Default.idCus;
                        objDetail.idMenu = item.idMenu;
                        objDetail.quantity = item.SoLuong;
                        objDetail.amount = item.ThanhTien;
                        objDetail.IsOrder = true;
                        objDetail.comment = "Order";
                        db.Order_Details.InsertOnSubmit(objDetail);
                        TongTien += item.sale_price * item.SoLuong;
                    }
                }
                if (TongTien > 0)
                {
                    db.SubmitChanges();
                    this.Close();//lỗi gì?
                }
                else
                    MessageBox.Show("Please enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);//đổi tiêng anh k tự đổi dc à
            }
            catch { }
        }

        private void gcData_Click(object sender, EventArgs e)
        {

        }

        private void gvData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "gridColumn4" & e.RowHandle > -1)
            {
                gvData.SetRowCellValue(e.RowHandle, "ThanhTien", decimal.Parse(gvData.GetRowCellValue(e.RowHandle, "sale_price").ToString()) * decimal.Parse(e.Value.ToString()));
            }
            if (e.Column.Name == "gridColumn6" & e.RowHandle > -1)
            {
                gvData.SetRowCellValue(e.RowHandle, "SoLuong", 1);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Check the services you use, then enter the number you need. After selecting the last service, click on any line. \r Finally click OK.", "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
