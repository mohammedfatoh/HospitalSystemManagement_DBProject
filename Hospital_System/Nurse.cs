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
    public partial class Nurse : Form
    {
        DBManager db;
        DataTable table;
        public Nurse()
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
            list_modifyNurse.SelectedIndexChanged -= list_modifyNurse_SelectedIndexChanged;
            table = db.getTAble("select * from Nurse");
            list_modifyNurse.ValueMember = "Nurse_id";
            list_modifyNurse.DisplayMember = "Nurse_name";
            list_modifyNurse.DataSource = table;
            list_modifyNurse.SelectedIndexChanged += list_modifyNurse_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String NurseName, NurseAddress, NursePhone, NurseSalary;
            NurseName = txt_AddNurseName.Text;
            NurseAddress = txt_AddNurseAddress.Text;
            NursePhone = txt_AddNursePhone.Text;
            NurseSalary = txt_AddNurseSalary.Text;
            

            if (NurseName != "" && NurseSalary != "" && NurseAddress != "" )
            {

                db.insertAndModifyNurse("insert into Nurse(Nurse_name,Nurse_address,Nurse_salary,nurse_phonenumber)values (@v1,@v2,@v3,@v4)"
                  , NurseName, NurseAddress, int.Parse(NurseSalary), NursePhone);
                txt_AddNurseName.Clear();
                txt_AddNurseAddress.Clear();
                txt_AddNursePhone.Clear();
                txt_AddNurseSalary.Clear();
                set();
           
            }
        }

        private void btn_removeNurse_Click(object sender, EventArgs e)
        {
            string Nurse_id = list_modifyNurse.SelectedValue.ToString();
            db.deleteFromTable("delete from nurse where nurse_id=@v1", int.Parse(Nurse_id));
            set();
        }

        private void list_removeNurse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modigyNurse_Click(object sender, EventArgs e)
        {

            String NurseName, NurseAddress, NursePhone, NurseSalary, Nurse_id;
            NurseName = txt_ModifyNurseName.Text;
            NurseAddress = txt_ModifyNurseAddress.Text;
            NursePhone = txt_ModifyNursePhone.Text;
            NurseSalary = txt_ModifyNurseSalary.Text;
            Nurse_id = list_modifyNurse.SelectedValue.ToString();

            if (NurseName != "" && NurseSalary != "" && NurseAddress != "" && Nurse_id != "")
            {

                db.insertAndModifyNurse("update nurse set nurse_name=@v1 ,nurse_address=@v2 ,nurse_salary=@v3 ,nurse_phonenumber=@v4 where nurse_id=@v5"
                  , NurseName, NurseAddress, int.Parse(NurseSalary), NursePhone, Nurse_id);
                set();
            }
        }

        private void list_modifyNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nurse_id = list_modifyNurse.SelectedValue.ToString();
            table = db.getTAble("select * from Nurse where Nurse_id =" + Nurse_id + "");
            txt_ModifyNurseName.Text = table.Rows[0][1].ToString();
            txt_ModifyNurseAddress.Text = table.Rows[0][3].ToString();
            txt_ModifyNursePhone.Text = table.Rows[0][4].ToString();
            txt_ModifyNurseSalary.Text = table.Rows[0][2].ToString();
        }



        private void txt_ModifyNurseSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ModifyNursePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_ModifyNurseAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_ModifyNurseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_searchNurse_TextChanged(object sender, EventArgs e)
        {
            string key = txt_searchNurse.Text;
            table = db.getTAble("select * from nurse where nurse_name like '%" + key + "%'");
            dg_searchNurse.DataSource = table;
        }
    }
}
