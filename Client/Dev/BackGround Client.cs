using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dev
{

    public partial class BackGround_Client : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = MSI; Initial Catalog = Quanly_quannet; Integrated Security = True");
        SqlCommand cmd;

        string computerName = Environment.MachineName.ToString();
        string username;
        string password;
        public BackGround_Client()
        {
            InitializeComponent();
            Console.WriteLine(computerName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            try {
                conn.Open();
                string sqlUser = "select* from Customer_Information where username ='" + username + "' and password ='" + password + "'";
                SqlCommand cmdUser = new SqlCommand(sqlUser, conn);
                cmdUser.CommandType = CommandType.Text;
                SqlDataReader dta = cmdUser.ExecuteReader();



                if (dta.Read() == true)
                {
                   
                    conn.Close();

                    Form1 f1 = new Form1(computerName, username);
                    this.Hide();
                    f1.ShowDialog();

                    conn.Close();

                    // Lấy id máy đưa vào db
                    

                    // Đăng nhập
                    

                    // Xử lý các vấn đề liên quan đến database ở Form1
                }
                else
                {
                    MessageBox.Show("Login Failed! Wrong Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed. Please try again later!");
            }
        }
            
           

        //private bool checkComputer(string computerName)
        //{
        //    string queryPC = "Select* from client where clientName ='" + computerName + "'";
        //    SqlCommand cmdPC = new SqlCommand(queryPC, conn);
        //    cmdPC.CommandType = CommandType.Text;
        //    SqlDataReader dta = cmdPC.ExecuteReader();
        //    if(dta.Read() == true)
        //    {
        //        return true;
        //    }
        //    if(dta.Read() == false)
        //    {
        //        MessageBox.Show("This computer not in the System");
        //        return false;
        //    }
        //}
    }
}
