using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dev
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public string computerName { get; set; }
        public string username { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source = MSI; Initial Catalog = Quanly_quannet; Integrated Security = True");
        SqlCommand cmd;

        string name = "";
        public Form1(string computerName, string username)
        {
            InitializeComponent();
            conn.Open();
            string queryName = "select username from Customer_Information where username ='" + username + "'";
            SqlCommand cmd = new SqlCommand(queryName, conn);
            name = cmd.ExecuteScalar().ToString();
            lbAccount.Text = name;
            conn.Close();

            conn.Open();
            string sqlIDPC = "select idClient from client where username ='" + computerName + "'";
            SqlCommand cmdIDPC = new SqlCommand(sqlIDPC, conn);
            string idPC = cmdIDPC.ExecuteScalar().ToString();
            Console.WriteLine(idPC);
            conn.Close();

            // Lấy id Customer
            conn.Open();
            string sqlIDCus = "select idCus from Customer_Information where username ='" + username + "'";
            SqlCommand cmdIDCus = new SqlCommand(sqlIDCus, conn);
            string idCus = cmdIDCus.ExecuteScalar().ToString();
            Console.WriteLine(idCus);
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Chat_Form cf = new Chat_Form();
            //this.Hide();
            cf.ShowDialog();
        }
    }
}
