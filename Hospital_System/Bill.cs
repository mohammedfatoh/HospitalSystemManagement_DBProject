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
   
    public partial class Bill : Form
    {
        bool a;
        DBManager db;
        MySqlCommand command;
        DataTable table;
        public Bill()
        {
            InitializeComponent();
            table = new DataTable();
            db = new DBManager();
            if (db.con.State == ConnectionState.Closed)
                db.open();
            set();

        }
        public void set()
        {
            table = db.getTAble("select * from patient where isStay=0");
            list_addBill.ValueMember = "patient_id";
            list_addBill.DisplayMember = "name";
            list_addBill.DataSource = table;
            if(list_addBill.Items.Count>0)
                list_addBill.SelectedIndex = 0;

            //select name,doctor_name,specialist,room_name,nurse_name from bill
            table = db.getTAble("select name,date_enter,bill_date,days_no,bill_amount from patient,bill where patient.patient_id=bill.patient_id");
            dgv_showBills.DataSource = table;
            float total = 0;
            for(int i = 0; i < table.Rows.Count; i++)
            {
                total += float.Parse(table.Rows[i][4].ToString());
            }

            txt_showBillNumber.Text = table.Rows.Count.ToString();
            txt_showTotalIncome.Text = total.ToString();
        }

        private void list_addBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = true;
            string Patient_id = list_addBill.SelectedValue.ToString();
            table = db.getTAble("select name,date_enter,doctor_name,specialist from patient,doctor,patient_doctor where patient.patient_id="+Patient_id+" and patient.patient_id=patient_doctor.patient_id and doctor.doctor_id=patient_doctor.doctor_id ");
            if (table.Rows.Count > 0)
            {
                dt_addbillEnter.Value = DateTime.Parse(table.Rows[0][1].ToString());
                txt_addBillDoctor.Text = table.Rows[0][2].ToString();
                txt_addBillSpecialist.Text = table.Rows[0][3].ToString();
                txt_addBillNAme.Text = table.Rows[0][0].ToString();

            }
        }

        private void txt_addBillNAme_TextChanged(object sender, EventArgs e)
        {
            CalculateBill();

        }

        private void dt_addBillExit_ValueChanged(object sender, EventArgs e)
        {
           
           
        }
        void CalculateBill()
        {
            if (a) {
                
                DateTime t1 = dt_addbillEnter.Value;
                DateTime t2 = dt_addBillExit.Value;
                TimeSpan t3 = t2 - t1;

                int days = t3.Days;
                float amount = days * 500.0f;

                txt_addBillDuration.Text = days.ToString();
                txt_addBillAmount.Text = amount.ToString(); ;
                a = false;
            }
           
        }

        private void txt_addBillDoctor_TextChanged(object sender, EventArgs e)
        {

        }
        DateTime t1;
        private void dt_addbillEnter_ValueChanged(object sender, EventArgs e)
        {
     
        }

        private void txt_addBillSpecialist_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void btn_addBill_Click(object sender, EventArgs e)
        {
            string patient_id, bill_amount, days_no, dateExit;
            patient_id = list_addBill.SelectedValue.ToString();
            bill_amount = txt_addBillAmount.Text;
            days_no = txt_addBillDuration.Text;
            dateExit = dt_addBillExit.Value.ToString("yyyy-MM-dd");

            command = new MySqlCommand("update patient set isStay=1 where patient_id=" + patient_id + "", db.con);
            command.ExecuteNonQuery();

            db.insertBill("insert into bill (bill_date,days_no,bill_amount,patient_id) values (@v1,@v2,@v3,@v4)", dateExit, int.Parse(days_no), float.Parse(bill_amount), int.Parse(patient_id));
            set();
        }
    }
}
