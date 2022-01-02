namespace Hospital_System
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.combo_addRoomStatus = new System.Windows.Forms.ComboBox();
            this.list_addRoom = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AddRoomName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.combo_ModifyRoomNurse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_modifyRoomStatus = new System.Windows.Forms.ComboBox();
            this.btn_removeNurse = new System.Windows.Forms.Button();
            this.list_modifyRoom = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_modigyRoom = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ModifyRoomName = new System.Windows.Forms.TextBox();
            this.dg_searchRoom = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_searchRoom = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-8, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 458);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dg_searchRoom);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_searchRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show&Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.combo_addRoomStatus);
            this.tabPage2.Controls.Add(this.list_addRoom);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_AddRoomName);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // combo_addRoomStatus
            // 
            this.combo_addRoomStatus.FormattingEnabled = true;
            this.combo_addRoomStatus.Items.AddRange(new object[] {
            "Empty",
            "Fill"});
            this.combo_addRoomStatus.Location = new System.Drawing.Point(202, 124);
            this.combo_addRoomStatus.Name = "combo_addRoomStatus";
            this.combo_addRoomStatus.Size = new System.Drawing.Size(237, 27);
            this.combo_addRoomStatus.TabIndex = 32;
            // 
            // list_addRoom
            // 
            this.list_addRoom.FormattingEnabled = true;
            this.list_addRoom.ItemHeight = 19;
            this.list_addRoom.Location = new System.Drawing.Point(661, 35);
            this.list_addRoom.Name = "list_addRoom";
            this.list_addRoom.Size = new System.Drawing.Size(182, 308);
            this.list_addRoom.TabIndex = 31;
            this.list_addRoom.SelectedIndexChanged += new System.EventHandler(this.list_addRoom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(713, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Room_status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(325, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Room";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room Name*";
            // 
            // txt_AddRoomName
            // 
            this.txt_AddRoomName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddRoomName.ForeColor = System.Drawing.Color.Black;
            this.txt_AddRoomName.Location = new System.Drawing.Point(202, 55);
            this.txt_AddRoomName.Name = "txt_AddRoomName";
            this.txt_AddRoomName.Size = new System.Drawing.Size(237, 29);
            this.txt_AddRoomName.TabIndex = 15;
            this.txt_AddRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.combo_ModifyRoomNurse);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.combo_modifyRoomStatus);
            this.tabPage4.Controls.Add(this.btn_removeNurse);
            this.tabPage4.Controls.Add(this.list_modifyRoom);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btn_modigyRoom);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_ModifyRoomName);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(957, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Modify Room";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // combo_ModifyRoomNurse
            // 
            this.combo_ModifyRoomNurse.FormattingEnabled = true;
            this.combo_ModifyRoomNurse.Items.AddRange(new object[] {
            "Empty",
            "Fill"});
            this.combo_ModifyRoomNurse.Location = new System.Drawing.Point(217, 168);
            this.combo_ModifyRoomNurse.Name = "combo_ModifyRoomNurse";
            this.combo_ModifyRoomNurse.Size = new System.Drawing.Size(237, 27);
            this.combo_ModifyRoomNurse.TabIndex = 53;
            this.combo_ModifyRoomNurse.SelectedIndexChanged += new System.EventHandler(this.combo_ModifyRoomNurse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(38, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nurses";
            // 
            // combo_modifyRoomStatus
            // 
            this.combo_modifyRoomStatus.FormattingEnabled = true;
            this.combo_modifyRoomStatus.Items.AddRange(new object[] {
            "Empty",
            "Fill"});
            this.combo_modifyRoomStatus.Location = new System.Drawing.Point(217, 107);
            this.combo_modifyRoomStatus.Name = "combo_modifyRoomStatus";
            this.combo_modifyRoomStatus.Size = new System.Drawing.Size(237, 27);
            this.combo_modifyRoomStatus.TabIndex = 51;
            // 
            // btn_removeNurse
            // 
            this.btn_removeNurse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_removeNurse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeNurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_removeNurse.Location = new System.Drawing.Point(476, 324);
            this.btn_removeNurse.Name = "btn_removeNurse";
            this.btn_removeNurse.Size = new System.Drawing.Size(132, 36);
            this.btn_removeNurse.TabIndex = 50;
            this.btn_removeNurse.Text = "Rmove Room";
            this.btn_removeNurse.UseVisualStyleBackColor = false;
            this.btn_removeNurse.Click += new System.EventHandler(this.btn_removeNurse_Click);
            // 
            // list_modifyRoom
            // 
            this.list_modifyRoom.FormattingEnabled = true;
            this.list_modifyRoom.ItemHeight = 19;
            this.list_modifyRoom.Location = new System.Drawing.Point(666, 33);
            this.list_modifyRoom.Name = "list_modifyRoom";
            this.list_modifyRoom.Size = new System.Drawing.Size(254, 327);
            this.list_modifyRoom.TabIndex = 49;
            this.list_modifyRoom.SelectedIndexChanged += new System.EventHandler(this.list_modifyRoom_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(38, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Room Status";
            // 
            // btn_modigyRoom
            // 
            this.btn_modigyRoom.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_modigyRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modigyRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_modigyRoom.Location = new System.Drawing.Point(263, 324);
            this.btn_modigyRoom.Name = "btn_modigyRoom";
            this.btn_modigyRoom.Size = new System.Drawing.Size(132, 36);
            this.btn_modigyRoom.TabIndex = 42;
            this.btn_modigyRoom.Text = "Modigy  Room";
            this.btn_modigyRoom.UseVisualStyleBackColor = false;
            this.btn_modigyRoom.Click += new System.EventHandler(this.btn_modigyRoom_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(38, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Room Name*";
            // 
            // txt_ModifyRoomName
            // 
            this.txt_ModifyRoomName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModifyRoomName.ForeColor = System.Drawing.Color.Black;
            this.txt_ModifyRoomName.Location = new System.Drawing.Point(217, 42);
            this.txt_ModifyRoomName.Name = "txt_ModifyRoomName";
            this.txt_ModifyRoomName.Size = new System.Drawing.Size(237, 29);
            this.txt_ModifyRoomName.TabIndex = 40;
            this.txt_ModifyRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dg_searchRoom
            // 
            this.dg_searchRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_searchRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_searchRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_searchRoom.Location = new System.Drawing.Point(17, 59);
            this.dg_searchRoom.Name = "dg_searchRoom";
            this.dg_searchRoom.Size = new System.Drawing.Size(923, 333);
            this.dg_searchRoom.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(249, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Search";
            // 
            // txt_searchRoom
            // 
            this.txt_searchRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchRoom.ForeColor = System.Drawing.Color.Black;
            this.txt_searchRoom.Location = new System.Drawing.Point(367, 14);
            this.txt_searchRoom.Name = "txt_searchRoom";
            this.txt_searchRoom.Size = new System.Drawing.Size(237, 29);
            this.txt_searchRoom.TabIndex = 23;
            this.txt_searchRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_searchRoom.TextChanged += new System.EventHandler(this.txt_searchRoom_TextChanged);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 419);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AddRoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_addRoom;
        private System.Windows.Forms.ComboBox combo_addRoomStatus;
        private System.Windows.Forms.ComboBox combo_ModifyRoomNurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_modifyRoomStatus;
        private System.Windows.Forms.Button btn_removeNurse;
        private System.Windows.Forms.ListBox list_modifyRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_modigyRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ModifyRoomName;
        private System.Windows.Forms.DataGridView dg_searchRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_searchRoom;
    }
}