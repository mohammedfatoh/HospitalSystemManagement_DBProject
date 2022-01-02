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
    public partial class Patient : Form
    {
        DBManager db;
        MySqlCommand command;
        DataTable table;
       
        public Patient()
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
            table = db.getTAble("select * from room");
            txt_AddPatientRoom.SelectedIndexChanged -= txt_AddPatientRoom_SelectedIndexChanged;
            txt_AddPatientRoom.ValueMember = "room_id";
            txt_AddPatientRoom.DisplayMember = "room_name";
            txt_AddPatientRoom.DataSource = table;
            txt_AddPatientRoom.SelectedIndexChanged += txt_AddPatientRoom_SelectedIndexChanged;
            txt_AddPatientGender.SelectedIndex = 0;

            table = db.getTAble("select * from doctor");
            combo_addPatientsSpacialist.ValueMember = "doctor_id";
            combo_addPatientsSpacialist.DisplayMember = "specialist";
            combo_addPatientsSpacialist.DataSource = table;
            combo_addPatientsSpacialist.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String PatientName, PatientAddress, PatientPhone, PatientGender, PatientAge, room;
            PatientName = txt_AddPatientName.Text;
            PatientAddress = txt_AddPatientAddress.Text;
            PatientPhone = txt_AddPatientPhone.Text;
            PatientGender = txt_AddPatientGender.Text;
            PatientAge = txt_AddPatientAge.Text;
            room = txt_AddPatientRoom.SelectedValue.ToString(); ;

            if (PatientName != "" && room != "" && PatientAddress != "" && PatientGender != "")
            {
                // insert into patient table 
                string date = dt_addPatient.Value.ToString("yyyy-MM-dd");
                db.insertPatient("insert into patient(name,address,phonenumber,gender,age,room_id,date_enter) values (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
                  , PatientName, PatientAddress, int.Parse(PatientAge), PatientGender, int.Parse(room), PatientPhone,date );
                    //cretae the relation between patient and doctor
                table = db.getTAble("select * from patient order by patient_id Desc limit 1");
                int patient_id = int.Parse(table.Rows[0][0].ToString());
                int doctor_id=int.Parse(combo_addPAtientDoctor.SelectedValue.ToString());
                try
                {
                    command = new MySqlCommand("insert into patient_doctor (patient_id,doctor_id)values(@v1,@v2)", db.con);
                    command.Parameters.AddWithValue("@v1", patient_id);
                    command.Parameters.AddWithValue("@v2", doctor_id);
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //set textboxes
                txt_AddPatientName.Clear();
                txt_AddPatientAddress.Clear();
                txt_AddPatientPhone.Clear();
                txt_AddPatientAge.Clear();
               
            }
        }

        private void txt_AddPatientRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_addPatientsSpacialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string specialist = combo_addPatientsSpacialist.Text;
            table = db.getTAble("select * from doctor where specialist='" + specialist + "'");
            combo_addPAtientDoctor.ValueMember = "doctor_id";
            combo_addPAtientDoctor.DisplayMember = "doctor_name";
            combo_addPAtientDoctor.DataSource = table;
            combo_addPAtientDoctor.SelectedIndex = 0;
        }

        private void txt_searchPatient_TextChanged(object sender, EventArgs e)
        {
            string key = txt_searchPatient.Text;
            table = db.getTAble("select * from patient where isStay=0 and name like '%" + key + "%'");
            dg_searchPatient.DataSource = table;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dg_searchPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
