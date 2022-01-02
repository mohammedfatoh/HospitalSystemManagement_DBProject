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
    public partial class Doctor : Form
    {
        DBManager db;
        // MySqlCommand command;
        DataTable table;
        public Doctor()
        {
            InitializeComponent();
            db = new DBManager();
            if (db.con.State == ConnectionState.Closed)
                db.open();
            table = new DataTable();
            set();
        }
        void set()
        {

            list_modifyDoctor.SelectedIndexChanged -= list_modifyDoctor_SelectedIndexChanged;
            //DataTable table2 = new DataTable();
            table = db.getTAble("select * from doctor");
            list_modifyDoctor.ValueMember = "doctor_id";
            list_modifyDoctor.DisplayMember = "doctor_name";
            list_modifyDoctor.DataSource = table;
            list_modifyDoctor.SelectedIndexChanged += list_modifyDoctor_SelectedIndexChanged;

            

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String doctorName, doctorAddress, doctorPhone, doctorSalary, specialist;
            doctorName = txt_AddDoctorName.Text;
            doctorAddress = txt_AddDoctorAddress.Text;
            doctorPhone = txt_AddDoctorPhone.Text;
            doctorSalary = txt_AddDoctorSalary.Text;
            specialist = txt_AddSpecialist.Text;

            if (doctorName != "" && doctorSalary != "" && doctorAddress != "" && specialist != "")
            {

                db.insertAndModifyDoctor("insert into doctor(doctor_name,doctor_address,doctor_salary,specialist,phonenumber)values (@v1,@v2,@v3,@v4,@v5)"
                  , doctorName, doctorAddress, int.Parse(doctorSalary), specialist, doctorPhone);
                txt_AddDoctorName.Clear();
                txt_AddDoctorAddress.Clear();
                txt_AddDoctorPhone.Clear();
                txt_AddDoctorSalary.Clear();
                txt_AddSpecialist.Clear();
                set();
            }
        }


        private void btn_removeDoctor_Click(object sender, EventArgs e)
        {
            

        }

        private void list_removeDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modigyDoctor_Click(object sender, EventArgs e)
        {
            String doctorName, doctorAddress, doctorPhone, doctorSalary, specialist,doctor_id;
            doctorName = txt_ModifyDoctorName.Text;
            doctorAddress = txt_ModifyDoctorAddress.Text;
            doctorPhone = txt_ModifyDoctorPhone.Text;
            doctorSalary = txt_ModifyDoctorSalary.Text;
            specialist = txt_ModifyDoctorSpecialist.Text;
            doctor_id = list_modifyDoctor.SelectedValue.ToString();

            if (doctorName != "" && doctorSalary != "" && doctorAddress != "" && specialist != "")
            {

                db.insertAndModifyDoctor("update doctor set doctor_name=@v1 ,doctor_address=@v2 ,doctor_salary=@v3 ,specialist=@v4 ,phonenumber=@v5 where doctor_id=@v6"
                  , doctorName, doctorAddress, int.Parse(doctorSalary), specialist, doctorPhone,doctor_id);
                set();
            }
        }

        private void list_modifyDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doctor_id = list_modifyDoctor.SelectedValue.ToString();
            table = db.getTAble("select * from doctor where doctor_id =" + doctor_id + "");
            txt_ModifyDoctorName.Text = table.Rows[0][1].ToString();
            txt_ModifyDoctorAddress.Text= table.Rows[0][3].ToString();
            txt_ModifyDoctorPhone.Text= table.Rows[0][4].ToString();
            txt_ModifyDoctorSalary.Text= table.Rows[0][2].ToString();
            txt_ModifyDoctorSpecialist.Text= table.Rows[0][5].ToString();
        }

        private void btn_removeDoctor_Click_1(object sender, EventArgs e)
        {
            string doctor_id = list_modifyDoctor.SelectedValue.ToString();
            db.deleteFromTable("delete from doctor where doctor_id=@v1", int.Parse(doctor_id));
            set();
        }

        private void txt_searchDoctor_TextChanged(object sender, EventArgs e)
        {
            string key = txt_searchDoctor.Text;
            table = db.getTAble("select * from doctor where doctor_name like '%" + key + "%'");
            dg_searchDoctor.DataSource = table;
        }
    }
}
