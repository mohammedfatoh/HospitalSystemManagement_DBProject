using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Form1 : Form
    {
        DBManager db;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            db = new DBManager();
            table = new DataTable();
            set();
        }
        void set()
        {
            table = db.getTAble("select count(*) from doctor");
            label_doctors.Text = table.Rows[0][0].ToString();

            table = db.getTAble("select count(*) from patient where isStay=0");
            label_patients.Text = table.Rows[0][0].ToString();

            table = db.getTAble("select count(*) from room");
            label_rooms.Text = table.Rows[0][0].ToString();

            table = db.getTAble("select count(*) from nurse");
            label_nurses.Text = table.Rows[0][0].ToString();

            table = db.getTAble("select count(*) from bill");
            label_bills.Text = table.Rows[0][0].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // db.open();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
           // this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Patient d = new Patient();
            d.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Nurse d = new Nurse();
            d.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            db.BackUp();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Room d = new Room();
            d.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            db.Retore();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
         
        }
    }
}
