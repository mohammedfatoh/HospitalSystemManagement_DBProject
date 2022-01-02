namespace Hospital_System
{
    partial class Patient
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
            this.dg_searchPatient = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_searchPatient = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_addPatient = new System.Windows.Forms.DateTimePicker();
            this.combo_addPAtientDoctor = new System.Windows.Forms.ComboBox();
            this.label65465 = new System.Windows.Forms.Label();
            this.combo_addPatientsSpacialist = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AddPatientRoom = new System.Windows.Forms.ComboBox();
            this.txt_AddPatientGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AddPatientAge = new System.Windows.Forms.TextBox();
            this.txt_AddPatientPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4654 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AddPatientAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AddPatientName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchPatient)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 486);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.dg_searchPatient);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_searchPatient);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(964, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show&Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg_searchPatient
            // 
            this.dg_searchPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_searchPatient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg_searchPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_searchPatient.Location = new System.Drawing.Point(14, 67);
            this.dg_searchPatient.Name = "dg_searchPatient";
            this.dg_searchPatient.Size = new System.Drawing.Size(923, 333);
            this.dg_searchPatient.TabIndex = 19;
            this.dg_searchPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_searchPatient_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(246, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_searchPatient
            // 
            this.txt_searchPatient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchPatient.ForeColor = System.Drawing.Color.Black;
            this.txt_searchPatient.Location = new System.Drawing.Point(364, 22);
            this.txt_searchPatient.Name = "txt_searchPatient";
            this.txt_searchPatient.Size = new System.Drawing.Size(237, 29);
            this.txt_searchPatient.TabIndex = 17;
            this.txt_searchPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_searchPatient.TextChanged += new System.EventHandler(this.txt_searchPatient_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dt_addPatient);
            this.tabPage2.Controls.Add(this.combo_addPAtientDoctor);
            this.tabPage2.Controls.Add(this.label65465);
            this.tabPage2.Controls.Add(this.combo_addPatientsSpacialist);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_AddPatientRoom);
            this.tabPage2.Controls.Add(this.txt_AddPatientGender);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_AddPatientAge);
            this.tabPage2.Controls.Add(this.txt_AddPatientPhone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4654);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_AddPatientAddress);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_AddPatientName);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(964, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Patient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(535, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date";
            // 
            // dt_addPatient
            // 
            this.dt_addPatient.Location = new System.Drawing.Point(664, 274);
            this.dt_addPatient.Name = "dt_addPatient";
            this.dt_addPatient.Size = new System.Drawing.Size(237, 26);
            this.dt_addPatient.TabIndex = 33;
            // 
            // combo_addPAtientDoctor
            // 
            this.combo_addPAtientDoctor.FormattingEnabled = true;
            this.combo_addPAtientDoctor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_addPAtientDoctor.Location = new System.Drawing.Point(664, 209);
            this.combo_addPAtientDoctor.Name = "combo_addPAtientDoctor";
            this.combo_addPAtientDoctor.Size = new System.Drawing.Size(237, 27);
            this.combo_addPAtientDoctor.TabIndex = 32;
            // 
            // label65465
            // 
            this.label65465.AutoSize = true;
            this.label65465.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65465.ForeColor = System.Drawing.Color.Navy;
            this.label65465.Location = new System.Drawing.Point(535, 209);
            this.label65465.Name = "label65465";
            this.label65465.Size = new System.Drawing.Size(67, 22);
            this.label65465.TabIndex = 31;
            this.label65465.Text = "Doctor";
            // 
            // combo_addPatientsSpacialist
            // 
            this.combo_addPatientsSpacialist.FormattingEnabled = true;
            this.combo_addPatientsSpacialist.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combo_addPatientsSpacialist.Location = new System.Drawing.Point(664, 139);
            this.combo_addPatientsSpacialist.Name = "combo_addPatientsSpacialist";
            this.combo_addPatientsSpacialist.Size = new System.Drawing.Size(237, 27);
            this.combo_addPatientsSpacialist.TabIndex = 30;
            this.combo_addPatientsSpacialist.SelectedIndexChanged += new System.EventHandler(this.combo_addPatientsSpacialist_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(535, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Specialist";
            // 
            // txt_AddPatientRoom
            // 
            this.txt_AddPatientRoom.FormattingEnabled = true;
            this.txt_AddPatientRoom.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_AddPatientRoom.Location = new System.Drawing.Point(664, 72);
            this.txt_AddPatientRoom.Name = "txt_AddPatientRoom";
            this.txt_AddPatientRoom.Size = new System.Drawing.Size(237, 27);
            this.txt_AddPatientRoom.TabIndex = 28;
            this.txt_AddPatientRoom.SelectedIndexChanged += new System.EventHandler(this.txt_AddPatientRoom_SelectedIndexChanged);
            // 
            // txt_AddPatientGender
            // 
            this.txt_AddPatientGender.FormattingEnabled = true;
            this.txt_AddPatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_AddPatientGender.Location = new System.Drawing.Point(209, 303);
            this.txt_AddPatientGender.Name = "txt_AddPatientGender";
            this.txt_AddPatientGender.Size = new System.Drawing.Size(237, 27);
            this.txt_AddPatientGender.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(29, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender";
            // 
            // txt_AddPatientAge
            // 
            this.txt_AddPatientAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddPatientAge.ForeColor = System.Drawing.Color.Black;
            this.txt_AddPatientAge.Location = new System.Drawing.Point(208, 257);
            this.txt_AddPatientAge.Name = "txt_AddPatientAge";
            this.txt_AddPatientAge.Size = new System.Drawing.Size(237, 29);
            this.txt_AddPatientAge.TabIndex = 24;
            this.txt_AddPatientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_AddPatientPhone
            // 
            this.txt_AddPatientPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddPatientPhone.ForeColor = System.Drawing.Color.Black;
            this.txt_AddPatientPhone.Location = new System.Drawing.Point(206, 206);
            this.txt_AddPatientPhone.Name = "txt_AddPatientPhone";
            this.txt_AddPatientPhone.Size = new System.Drawing.Size(237, 29);
            this.txt_AddPatientPhone.TabIndex = 23;
            this.txt_AddPatientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(29, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "age";
            // 
            // label4654
            // 
            this.label4654.AutoSize = true;
            this.label4654.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4654.ForeColor = System.Drawing.Color.Navy;
            this.label4654.Location = new System.Drawing.Point(535, 72);
            this.label4654.Name = "label4654";
            this.label4654.Size = new System.Drawing.Size(59, 22);
            this.label4654.TabIndex = 21;
            this.label4654.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address*";
            // 
            // txt_AddPatientAddress
            // 
            this.txt_AddPatientAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddPatientAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_AddPatientAddress.Location = new System.Drawing.Point(206, 136);
            this.txt_AddPatientAddress.Name = "txt_AddPatientAddress";
            this.txt_AddPatientAddress.Size = new System.Drawing.Size(237, 29);
            this.txt_AddPatientAddress.TabIndex = 18;
            this.txt_AddPatientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(435, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = " Name*";
            // 
            // txt_AddPatientName
            // 
            this.txt_AddPatientName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddPatientName.ForeColor = System.Drawing.Color.Black;
            this.txt_AddPatientName.Location = new System.Drawing.Point(206, 69);
            this.txt_AddPatientName.Name = "txt_AddPatientName";
            this.txt_AddPatientName.Size = new System.Drawing.Size(237, 29);
            this.txt_AddPatientName.TabIndex = 15;
            this.txt_AddPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchPatient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox txt_AddPatientGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AddPatientAge;
        private System.Windows.Forms.TextBox txt_AddPatientPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4654;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AddPatientAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AddPatientName;
        private System.Windows.Forms.ComboBox txt_AddPatientRoom;
        private System.Windows.Forms.ComboBox combo_addPAtientDoctor;
        private System.Windows.Forms.Label label65465;
        private System.Windows.Forms.ComboBox combo_addPatientsSpacialist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_addPatient;
        private System.Windows.Forms.DataGridView dg_searchPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_searchPatient;
    }
}