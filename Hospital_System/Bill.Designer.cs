namespace Hospital_System
{
    partial class Bill
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
            this.dt_addbillEnter = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addBillAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_addBillExit = new System.Windows.Forms.DateTimePicker();
            this.txt_addBillDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_addBill = new System.Windows.Forms.ListBox();
            this.txt_addBillSpecialist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_addBillDoctor = new System.Windows.Forms.TextBox();
            this.btn_addBill = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_addBillNAme = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_showBills = new System.Windows.Forms.DataGridView();
            this.lab46 = new System.Windows.Forms.Label();
            this.txt_showTotalIncome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_showBillNumber = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showBills)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dt_addbillEnter);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_addBillAmount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dt_addBillExit);
            this.tabPage1.Controls.Add(this.txt_addBillDuration);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.list_addBill);
            this.tabPage1.Controls.Add(this.txt_addBillSpecialist);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_addBillDoctor);
            this.tabPage1.Controls.Add(this.btn_addBill);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_addBillNAme);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add  Bill";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dt_addbillEnter
            // 
            this.dt_addbillEnter.Enabled = false;
            this.dt_addbillEnter.Location = new System.Drawing.Point(382, 161);
            this.dt_addbillEnter.Name = "dt_addbillEnter";
            this.dt_addbillEnter.Size = new System.Drawing.Size(236, 26);
            this.dt_addbillEnter.TabIndex = 65;
            this.dt_addbillEnter.ValueChanged += new System.EventHandler(this.dt_addbillEnter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(252, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "Amount";
            // 
            // txt_addBillAmount
            // 
            this.txt_addBillAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBillAmount.ForeColor = System.Drawing.Color.Black;
            this.txt_addBillAmount.Location = new System.Drawing.Point(385, 287);
            this.txt_addBillAmount.Name = "txt_addBillAmount";
            this.txt_addBillAmount.Size = new System.Drawing.Size(87, 29);
            this.txt_addBillAmount.TabIndex = 63;
            this.txt_addBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(249, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Duration";
            // 
            // dt_addBillExit
            // 
            this.dt_addBillExit.Enabled = false;
            this.dt_addBillExit.Location = new System.Drawing.Point(382, 202);
            this.dt_addBillExit.Name = "dt_addBillExit";
            this.dt_addBillExit.Size = new System.Drawing.Size(236, 26);
            this.dt_addBillExit.TabIndex = 61;
            this.dt_addBillExit.ValueChanged += new System.EventHandler(this.dt_addBillExit_ValueChanged);
            // 
            // txt_addBillDuration
            // 
            this.txt_addBillDuration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBillDuration.ForeColor = System.Drawing.Color.Black;
            this.txt_addBillDuration.Location = new System.Drawing.Point(382, 243);
            this.txt_addBillDuration.Name = "txt_addBillDuration";
            this.txt_addBillDuration.Size = new System.Drawing.Size(90, 29);
            this.txt_addBillDuration.TabIndex = 60;
            this.txt_addBillDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(248, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "Exit Date";
            // 
            // list_addBill
            // 
            this.list_addBill.FormattingEnabled = true;
            this.list_addBill.ItemHeight = 19;
            this.list_addBill.Location = new System.Drawing.Point(675, 26);
            this.list_addBill.Name = "list_addBill";
            this.list_addBill.Size = new System.Drawing.Size(241, 365);
            this.list_addBill.TabIndex = 58;
            this.list_addBill.SelectedIndexChanged += new System.EventHandler(this.list_addBill_SelectedIndexChanged);
            // 
            // txt_addBillSpecialist
            // 
            this.txt_addBillSpecialist.Enabled = false;
            this.txt_addBillSpecialist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBillSpecialist.ForeColor = System.Drawing.Color.Black;
            this.txt_addBillSpecialist.Location = new System.Drawing.Point(382, 117);
            this.txt_addBillSpecialist.Name = "txt_addBillSpecialist";
            this.txt_addBillSpecialist.Size = new System.Drawing.Size(237, 29);
            this.txt_addBillSpecialist.TabIndex = 56;
            this.txt_addBillSpecialist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBillSpecialist.TextChanged += new System.EventHandler(this.txt_addBillSpecialist_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(248, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Enter Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(248, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Specialist";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(249, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 53;
            this.label8.Text = "Doctor Name";
            // 
            // txt_addBillDoctor
            // 
            this.txt_addBillDoctor.Enabled = false;
            this.txt_addBillDoctor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBillDoctor.ForeColor = System.Drawing.Color.Black;
            this.txt_addBillDoctor.Location = new System.Drawing.Point(382, 73);
            this.txt_addBillDoctor.Name = "txt_addBillDoctor";
            this.txt_addBillDoctor.Size = new System.Drawing.Size(237, 29);
            this.txt_addBillDoctor.TabIndex = 52;
            this.txt_addBillDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBillDoctor.TextChanged += new System.EventHandler(this.txt_addBillDoctor_TextChanged);
            // 
            // btn_addBill
            // 
            this.btn_addBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_addBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addBill.Location = new System.Drawing.Point(320, 355);
            this.btn_addBill.Name = "btn_addBill";
            this.btn_addBill.Size = new System.Drawing.Size(132, 36);
            this.btn_addBill.TabIndex = 51;
            this.btn_addBill.Text = "Accept Payment";
            this.btn_addBill.UseVisualStyleBackColor = false;
            this.btn_addBill.Click += new System.EventHandler(this.btn_addBill_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(249, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "Patient Name";
            // 
            // txt_addBillNAme
            // 
            this.txt_addBillNAme.Enabled = false;
            this.txt_addBillNAme.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addBillNAme.ForeColor = System.Drawing.Color.Black;
            this.txt_addBillNAme.Location = new System.Drawing.Point(382, 29);
            this.txt_addBillNAme.Name = "txt_addBillNAme";
            this.txt_addBillNAme.Size = new System.Drawing.Size(237, 29);
            this.txt_addBillNAme.TabIndex = 49;
            this.txt_addBillNAme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_addBillNAme.TextChanged += new System.EventHandler(this.txt_addBillNAme_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.lab46);
            this.tabPage2.Controls.Add(this.txt_showTotalIncome);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_showBillNumber);
            this.tabPage2.Controls.Add(this.dgv_showBills);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Bills";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(477, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Eg  (500 eg for A Day)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(500, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Days";
            // 
            // dgv_showBills
            // 
            this.dgv_showBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_showBills.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_showBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showBills.Location = new System.Drawing.Point(28, 68);
            this.dgv_showBills.Name = "dgv_showBills";
            this.dgv_showBills.Size = new System.Drawing.Size(877, 335);
            this.dgv_showBills.TabIndex = 0;
            // 
            // lab46
            // 
            this.lab46.AutoSize = true;
            this.lab46.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab46.ForeColor = System.Drawing.Color.Navy;
            this.lab46.Location = new System.Drawing.Point(494, 34);
            this.lab46.Name = "lab46";
            this.lab46.Size = new System.Drawing.Size(117, 22);
            this.lab46.TabIndex = 57;
            this.lab46.Text = "Total Income";
            // 
            // txt_showTotalIncome
            // 
            this.txt_showTotalIncome.Enabled = false;
            this.txt_showTotalIncome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showTotalIncome.ForeColor = System.Drawing.Color.Black;
            this.txt_showTotalIncome.Location = new System.Drawing.Point(642, 27);
            this.txt_showTotalIncome.Name = "txt_showTotalIncome";
            this.txt_showTotalIncome.Size = new System.Drawing.Size(237, 29);
            this.txt_showTotalIncome.TabIndex = 56;
            this.txt_showTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(24, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 55;
            this.label11.Text = "Bills Number";
            // 
            // txt_showBillNumber
            // 
            this.txt_showBillNumber.Enabled = false;
            this.txt_showBillNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showBillNumber.ForeColor = System.Drawing.Color.Black;
            this.txt_showBillNumber.Location = new System.Drawing.Point(172, 30);
            this.txt_showBillNumber.Name = "txt_showBillNumber";
            this.txt_showBillNumber.Size = new System.Drawing.Size(237, 29);
            this.txt_showBillNumber.TabIndex = 54;
            this.txt_showBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_System.Properties.Resources._642abdf64e03384de6e63f91be8fc8f6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox list_addBill;
        private System.Windows.Forms.TextBox txt_addBillSpecialist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_addBillDoctor;
        private System.Windows.Forms.Button btn_addBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_addBillNAme;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addBillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_addBillExit;
        private System.Windows.Forms.TextBox txt_addBillDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_addbillEnter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab46;
        private System.Windows.Forms.TextBox txt_showTotalIncome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_showBillNumber;
        private System.Windows.Forms.DataGridView dgv_showBills;
    }
}