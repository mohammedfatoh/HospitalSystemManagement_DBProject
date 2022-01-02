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
    public partial class Room : Form
    {
        DBManager db;
       // MySqlCommand command;
        DataTable table;
        public Room()
        {
            InitializeComponent();
            
            db = new DBManager();
            if (db.con.State == ConnectionState.Closed)
                db.open();

           
            set();

        }
        void set()
        {
            table = db.getTAble("select * from nurse");
            list_addRoom.SelectedIndexChanged -= list_addRoom_SelectedIndexChanged;
            list_addRoom.ValueMember = "nurse_id";
            list_addRoom.DisplayMember = "nurse_name";
            list_addRoom.DataSource = table;
            list_addRoom.SelectedIndexChanged += list_addRoom_SelectedIndexChanged;

            list_modifyRoom.SelectedIndexChanged -= list_modifyRoom_SelectedIndexChanged;
            table = db.getTAble("select * from room");
            list_modifyRoom.ValueMember = "room_id";
            list_modifyRoom.DisplayMember = "room_name";
            list_modifyRoom.DataSource = table;
            list_modifyRoom.SelectedIndexChanged += list_modifyRoom_SelectedIndexChanged;


            combo_ModifyRoomNurse.SelectedIndexChanged -= combo_ModifyRoomNurse_SelectedIndexChanged;
            table = db.getTAble("select * from nurse");
            combo_ModifyRoomNurse.ValueMember = "nurse_id";
            combo_ModifyRoomNurse.DisplayMember = "nurse_name";
            combo_ModifyRoomNurse.DataSource = table;
            combo_ModifyRoomNurse.SelectedIndexChanged += combo_ModifyRoomNurse_SelectedIndexChanged;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String RoomName, RoomStatus, Nurse_id;
            RoomName = txt_AddRoomName.Text;
            RoomStatus = combo_addRoomStatus.Text;
            Nurse_id = list_addRoom.SelectedValue.ToString();

            if (RoomName != "" && RoomStatus != "" && Nurse_id != "" )
            {

                db.insertAndModifyRoom("insert into Room(room_name,room_status,nurse_id)values (@v1,@v2,@v3)"
                 , RoomName, RoomStatus, int.Parse(Nurse_id));
                txt_AddRoomName.Clear();

                set();

            }
        }



        private void list_AddRoomRoom_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            
            
        }

        private void list_addRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void list_removeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_removeRoom_Click_1(object sender, EventArgs e)
        {
            string Room_id = list_modifyRoom.SelectedValue.ToString();
            db.deleteFromTable("delete from room where room_id=@v1", int.Parse(Room_id));
            set();
        }

        private void btn_removeRoom_Click(object sender, EventArgs e)
        {
            string Room_id = list_modifyRoom.SelectedValue.ToString();
            db.deleteFromTable("delete from Room where Room_id=@v1", int.Parse(Room_id));
            set();
        }

        private void btn_modigyRoom_Click(object sender, EventArgs e)
        {
            String RoomName, RoomStatus, Room_id,Nurse_id;
            RoomName = txt_ModifyRoomName.Text;
            Room_id = list_modifyRoom.SelectedValue.ToString();
            RoomStatus = combo_modifyRoomStatus.Text;
            Nurse_id = combo_ModifyRoomNurse.SelectedValue.ToString();
            if (RoomName != "" && RoomStatus != "" && Nurse_id != "" && Room_id != "")
            {

                db.insertAndModifyRoom("update room set room_name=@v1 ,room_status=@v2 ,nurse_id=@v3 where room_id=@v4"
                  , RoomName, RoomStatus, int.Parse(Nurse_id), Room_id);
                set();
            }
        }

        private void list_modifyRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string Room_id = list_modifyRoom.SelectedValue.ToString();
            table = db.getTAble("select room_name,room_status,nurse_name from room,nurse where room.nurse_id=nurse.nurse_id and room_id =" + Room_id + "");
            txt_ModifyRoomName.Text = table.Rows[0][0].ToString();
            combo_modifyRoomStatus.Text = table.Rows[0][1].ToString();
            string nurse_name=table.Rows[0][2].ToString();
            combo_ModifyRoomNurse.Text = nurse_name;

        }

        private void combo_ModifyRoomNurse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_removeNurse_Click(object sender, EventArgs e)
        {

        }

        private void txt_searchRoom_TextChanged(object sender, EventArgs e)
        {
            string key = txt_searchRoom.Text;
            table = db.getTAble("select * from room where room_name like '%" + key + "%'");
            dg_searchRoom.DataSource = table;
        }
    }
}
