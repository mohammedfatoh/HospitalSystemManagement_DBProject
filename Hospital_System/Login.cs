using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Login : Form
    {
        DataTable table;
        DBManager db;
        
        public Login()
        {
            InitializeComponent();
            table = new DataTable();
            db = new DBManager();
            db.open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_loginPass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_loginPass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_loginName.Text;
            string password = txt_loginPass.Text;

            table = db.getTAble("select username,password from admin");
            int i = 0;
            for ( i= 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == username && table.Rows[i][1].ToString() == password)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                    break;
                }


            }
            if(i==table.Rows.Count)
                MessageBox.Show("الرجاء التأكد من اسم المستخدم وكلمه المرور ");
            /*try
            {
                MySqlCommand command = new MySqlCommand("select * from admin where username=@v1 and password =@v2", db.con);
                command.Parameters.AddWithValue("@v1", username);
                command.Parameters.AddWithValue("@v2", password);
                MySqlDataReader datareader = command.ExecuteReader();
                if (datareader.HasRows)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("الرجاء التأكد من اسم المستخدم وكلمه المرور ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
