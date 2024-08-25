
namespace AyuboDrive_SystemNew.Forms
{
    partial class Driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver));
            this.Dri_SalaryPerDay = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.JoinDate = new System.Windows.Forms.DateTimePicker();
            this.BankAccNoBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WorkExpbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dri_searchMail = new System.Windows.Forms.TextBox();
            this.Dri_SearchClrBtn = new System.Windows.Forms.Button();
            this.Dri_searchNIC = new System.Windows.Forms.TextBox();
            this.Dri_SearchBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Dri_AgeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DriBloodCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Dri_Lic_Expiry = new System.Windows.Forms.DateTimePicker();
            this.Dri_IdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dri_AdBox = new System.Windows.Forms.TextBox();
            this.Dri_mailBox = new System.Windows.Forms.TextBox();
            this.Dri_Drive_LicNoBox = new System.Windows.Forms.TextBox();
            this.Dri_teleBox = new System.Windows.Forms.TextBox();
            this.Dri_NICbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dri_nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DriverGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dri_SaveBtn = new System.Windows.Forms.Button();
            this.Dri_ClearTextBtn = new System.Windows.Forms.Button();
            this.Dri_DeleteBtn = new System.Windows.Forms.Button();
            this.Dri_UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dri_SalaryPerDay
            // 
            this.Dri_SalaryPerDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_SalaryPerDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_SalaryPerDay.Location = new System.Drawing.Point(194, 533);
            this.Dri_SalaryPerDay.Name = "Dri_SalaryPerDay";
            this.Dri_SalaryPerDay.Size = new System.Drawing.Size(256, 25);
            this.Dri_SalaryPerDay.TabIndex = 80;
            this.Dri_SalaryPerDay.TextChanged += new System.EventHandler(this.Dri_SalaryPerDay_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(48, 533);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 22);
            this.label16.TabIndex = 79;
            this.label16.Text = "Salary per Day :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(43, 495);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 22);
            this.label15.TabIndex = 78;
            this.label15.Text = "Work Join Date :";
            // 
            // JoinDate
            // 
            this.JoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinDate.Location = new System.Drawing.Point(194, 497);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(101, 23);
            this.JoinDate.TabIndex = 77;
            this.JoinDate.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            this.JoinDate.ValueChanged += new System.EventHandler(this.JoinDate_ValueChanged);
            // 
            // BankAccNoBox
            // 
            this.BankAccNoBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankAccNoBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BankAccNoBox.Location = new System.Drawing.Point(195, 463);
            this.BankAccNoBox.Name = "BankAccNoBox";
            this.BankAccNoBox.Size = new System.Drawing.Size(256, 25);
            this.BankAccNoBox.TabIndex = 76;
            this.BankAccNoBox.TextChanged += new System.EventHandler(this.BankAccNoBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(19, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 22);
            this.label11.TabIndex = 75;
            this.label11.Text = "Bank Account  No :";
            // 
            // WorkExpbox
            // 
            this.WorkExpbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkExpbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WorkExpbox.Location = new System.Drawing.Point(194, 354);
            this.WorkExpbox.Name = "WorkExpbox";
            this.WorkExpbox.Size = new System.Drawing.Size(122, 25);
            this.WorkExpbox.TabIndex = 74;
            this.WorkExpbox.TextChanged += new System.EventHandler(this.WorkExpbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Work Experience :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dri_searchMail);
            this.groupBox2.Controls.Add(this.Dri_SearchClrBtn);
            this.groupBox2.Controls.Add(this.Dri_searchNIC);
            this.groupBox2.Controls.Add(this.Dri_SearchBtn);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(466, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 159);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Driver";
            // 
            // Dri_searchMail
            // 
            this.Dri_searchMail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_searchMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_searchMail.Location = new System.Drawing.Point(100, 73);
            this.Dri_searchMail.Name = "Dri_searchMail";
            this.Dri_searchMail.Size = new System.Drawing.Size(256, 25);
            this.Dri_searchMail.TabIndex = 74;
            // 
            // Dri_SearchClrBtn
            // 
            this.Dri_SearchClrBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dri_SearchClrBtn.FlatAppearance.BorderSize = 0;
            this.Dri_SearchClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_SearchClrBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_SearchClrBtn.Location = new System.Drawing.Point(100, 116);
            this.Dri_SearchClrBtn.Name = "Dri_SearchClrBtn";
            this.Dri_SearchClrBtn.Size = new System.Drawing.Size(100, 25);
            this.Dri_SearchClrBtn.TabIndex = 77;
            this.Dri_SearchClrBtn.Text = "Clear";
            this.Dri_SearchClrBtn.UseVisualStyleBackColor = false;
            // 
            // Dri_searchNIC
            // 
            this.Dri_searchNIC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_searchNIC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_searchNIC.Location = new System.Drawing.Point(102, 29);
            this.Dri_searchNIC.Name = "Dri_searchNIC";
            this.Dri_searchNIC.Size = new System.Drawing.Size(256, 25);
            this.Dri_searchNIC.TabIndex = 51;
            // 
            // Dri_SearchBtn
            // 
            this.Dri_SearchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dri_SearchBtn.FlatAppearance.BorderSize = 0;
            this.Dri_SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_SearchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_SearchBtn.Location = new System.Drawing.Point(266, 116);
            this.Dri_SearchBtn.Name = "Dri_SearchBtn";
            this.Dri_SearchBtn.Size = new System.Drawing.Size(90, 25);
            this.Dri_SearchBtn.TabIndex = 78;
            this.Dri_SearchBtn.Text = "Search";
            this.Dri_SearchBtn.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(20, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 73;
            this.label14.Text = "E-Mail :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(20, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 50;
            this.label13.Text = "NIC no :";
            // 
            // Dri_AgeBox
            // 
            this.Dri_AgeBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_AgeBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_AgeBox.Location = new System.Drawing.Point(194, 133);
            this.Dri_AgeBox.Name = "Dri_AgeBox";
            this.Dri_AgeBox.Size = new System.Drawing.Size(147, 25);
            this.Dri_AgeBox.TabIndex = 70;
            this.Dri_AgeBox.TextChanged += new System.EventHandler(this.Dri_AgeBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(137, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 22);
            this.label12.TabIndex = 69;
            this.label12.Text = "Age :";
            // 
            // DriBloodCombo
            // 
            this.DriBloodCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriBloodCombo.FormattingEnabled = true;
            this.DriBloodCombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.DriBloodCombo.Location = new System.Drawing.Point(195, 316);
            this.DriBloodCombo.Name = "DriBloodCombo";
            this.DriBloodCombo.Size = new System.Drawing.Size(121, 27);
            this.DriBloodCombo.TabIndex = 61;
            this.DriBloodCombo.SelectedIndexChanged += new System.EventHandler(this.DriBloodCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(60, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 22);
            this.label10.TabIndex = 60;
            this.label10.Text = "Blood Group :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(44, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "License Expiry :";
            // 
            // Dri_Lic_Expiry
            // 
            this.Dri_Lic_Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dri_Lic_Expiry.Location = new System.Drawing.Point(195, 427);
            this.Dri_Lic_Expiry.Name = "Dri_Lic_Expiry";
            this.Dri_Lic_Expiry.Size = new System.Drawing.Size(101, 23);
            this.Dri_Lic_Expiry.TabIndex = 58;
            this.Dri_Lic_Expiry.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            this.Dri_Lic_Expiry.ValueChanged += new System.EventHandler(this.Dri_Lic_Expiry_ValueChanged);
            // 
            // Dri_IdBox
            // 
            this.Dri_IdBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_IdBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_IdBox.Location = new System.Drawing.Point(195, 17);
            this.Dri_IdBox.Name = "Dri_IdBox";
            this.Dri_IdBox.ReadOnly = true;
            this.Dri_IdBox.Size = new System.Drawing.Size(146, 25);
            this.Dri_IdBox.TabIndex = 57;
            this.Dri_IdBox.TextChanged += new System.EventHandler(this.Dri_IdBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(91, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Driver ID :";
            // 
            // Dri_AdBox
            // 
            this.Dri_AdBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_AdBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_AdBox.Location = new System.Drawing.Point(195, 169);
            this.Dri_AdBox.Multiline = true;
            this.Dri_AdBox.Name = "Dri_AdBox";
            this.Dri_AdBox.Size = new System.Drawing.Size(256, 64);
            this.Dri_AdBox.TabIndex = 53;
            this.Dri_AdBox.TextChanged += new System.EventHandler(this.Dri_AdBox_TextChanged);
            // 
            // Dri_mailBox
            // 
            this.Dri_mailBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_mailBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_mailBox.Location = new System.Drawing.Point(195, 244);
            this.Dri_mailBox.Name = "Dri_mailBox";
            this.Dri_mailBox.Size = new System.Drawing.Size(256, 25);
            this.Dri_mailBox.TabIndex = 52;
            this.Dri_mailBox.TextChanged += new System.EventHandler(this.Dri_mailBox_TextChanged);
            // 
            // Dri_Drive_LicNoBox
            // 
            this.Dri_Drive_LicNoBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_Drive_LicNoBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_Drive_LicNoBox.Location = new System.Drawing.Point(195, 391);
            this.Dri_Drive_LicNoBox.Name = "Dri_Drive_LicNoBox";
            this.Dri_Drive_LicNoBox.Size = new System.Drawing.Size(256, 25);
            this.Dri_Drive_LicNoBox.TabIndex = 51;
            this.Dri_Drive_LicNoBox.TextChanged += new System.EventHandler(this.Dri_Drive_LicNoBox_TextChanged);
            // 
            // Dri_teleBox
            // 
            this.Dri_teleBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_teleBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_teleBox.Location = new System.Drawing.Point(195, 280);
            this.Dri_teleBox.Name = "Dri_teleBox";
            this.Dri_teleBox.Size = new System.Drawing.Size(256, 25);
            this.Dri_teleBox.TabIndex = 50;
            this.Dri_teleBox.TextChanged += new System.EventHandler(this.Dri_teleBox_TextChanged);
            // 
            // Dri_NICbox
            // 
            this.Dri_NICbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_NICbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_NICbox.Location = new System.Drawing.Point(195, 97);
            this.Dri_NICbox.Name = "Dri_NICbox";
            this.Dri_NICbox.Size = new System.Drawing.Size(256, 25);
            this.Dri_NICbox.TabIndex = 49;
            this.Dri_NICbox.TextChanged += new System.EventHandler(this.Dri_NICbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(5, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Driving License  No :";
            // 
            // Dri_nameBox
            // 
            this.Dri_nameBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_nameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dri_nameBox.Location = new System.Drawing.Point(195, 57);
            this.Dri_nameBox.Name = "Dri_nameBox";
            this.Dri_nameBox.Size = new System.Drawing.Size(256, 25);
            this.Dri_nameBox.TabIndex = 48;
            this.Dri_nameBox.TextChanged += new System.EventHandler(this.Dri_nameBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(54, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Telephone no :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(115, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "E-Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(99, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(113, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "NIC no :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Driver Name :";
            // 
            // DriverGrid
            // 
            this.DriverGrid.AllowUserToAddRows = false;
            this.DriverGrid.AllowUserToDeleteRows = false;
            this.DriverGrid.AllowUserToResizeColumns = false;
            this.DriverGrid.AllowUserToResizeRows = false;
            this.DriverGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DriverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGrid.Location = new System.Drawing.Point(466, 187);
            this.DriverGrid.Name = "DriverGrid";
            this.DriverGrid.ReadOnly = true;
            this.DriverGrid.Size = new System.Drawing.Size(625, 301);
            this.DriverGrid.TabIndex = 40;
            this.DriverGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Dri_SaveBtn);
            this.groupBox1.Controls.Add(this.Dri_ClearTextBtn);
            this.groupBox1.Controls.Add(this.Dri_DeleteBtn);
            this.groupBox1.Controls.Add(this.Dri_UpdateBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.DriverGrid);
            this.groupBox1.Controls.Add(this.Dri_SalaryPerDay);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.JoinDate);
            this.groupBox1.Controls.Add(this.BankAccNoBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.WorkExpbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Dri_AgeBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.DriBloodCombo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Dri_Lic_Expiry);
            this.groupBox1.Controls.Add(this.Dri_IdBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Dri_AdBox);
            this.groupBox1.Controls.Add(this.Dri_mailBox);
            this.groupBox1.Controls.Add(this.Dri_Drive_LicNoBox);
            this.groupBox1.Controls.Add(this.Dri_teleBox);
            this.groupBox1.Controls.Add(this.Dri_NICbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Dri_nameBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 569);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Details";
            // 
            // Dri_SaveBtn
            // 
            this.Dri_SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Dri_SaveBtn.FlatAppearance.BorderSize = 0;
            this.Dri_SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_SaveBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_SaveBtn.Location = new System.Drawing.Point(628, 497);
            this.Dri_SaveBtn.Name = "Dri_SaveBtn";
            this.Dri_SaveBtn.Size = new System.Drawing.Size(141, 58);
            this.Dri_SaveBtn.TabIndex = 68;
            this.Dri_SaveBtn.Text = "SAVE";
            this.Dri_SaveBtn.UseVisualStyleBackColor = false;
            this.Dri_SaveBtn.Click += new System.EventHandler(this.Dri_SaveBtn_Click);
            // 
            // Dri_ClearTextBtn
            // 
            this.Dri_ClearTextBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Dri_ClearTextBtn.FlatAppearance.BorderSize = 0;
            this.Dri_ClearTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_ClearTextBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_ClearTextBtn.Location = new System.Drawing.Point(468, 497);
            this.Dri_ClearTextBtn.Name = "Dri_ClearTextBtn";
            this.Dri_ClearTextBtn.Size = new System.Drawing.Size(141, 58);
            this.Dri_ClearTextBtn.TabIndex = 70;
            this.Dri_ClearTextBtn.Text = "CLEAR";
            this.Dri_ClearTextBtn.UseVisualStyleBackColor = false;
            this.Dri_ClearTextBtn.Click += new System.EventHandler(this.Dri_ClearTextBtn_Click);
            // 
            // Dri_DeleteBtn
            // 
            this.Dri_DeleteBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Dri_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.Dri_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_DeleteBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_DeleteBtn.Location = new System.Drawing.Point(949, 497);
            this.Dri_DeleteBtn.Name = "Dri_DeleteBtn";
            this.Dri_DeleteBtn.Size = new System.Drawing.Size(141, 58);
            this.Dri_DeleteBtn.TabIndex = 71;
            this.Dri_DeleteBtn.Text = "DELETE";
            this.Dri_DeleteBtn.UseVisualStyleBackColor = false;
            this.Dri_DeleteBtn.Click += new System.EventHandler(this.Dri_DeleteBtn_Click);
            // 
            // Dri_UpdateBtn
            // 
            this.Dri_UpdateBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Dri_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.Dri_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dri_UpdateBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dri_UpdateBtn.Location = new System.Drawing.Point(789, 497);
            this.Dri_UpdateBtn.Name = "Dri_UpdateBtn";
            this.Dri_UpdateBtn.Size = new System.Drawing.Size(141, 58);
            this.Dri_UpdateBtn.TabIndex = 69;
            this.Dri_UpdateBtn.Text = "UPDATE";
            this.Dri_UpdateBtn.UseVisualStyleBackColor = false;
            this.Dri_UpdateBtn.Click += new System.EventHandler(this.Dri_UpdateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(891, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 581);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Dri_SalaryPerDay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker JoinDate;
        private System.Windows.Forms.TextBox BankAccNoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WorkExpbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Dri_searchMail;
        private System.Windows.Forms.TextBox Dri_searchNIC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Dri_AgeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DriBloodCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dri_Lic_Expiry;
        private System.Windows.Forms.TextBox Dri_IdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Dri_AdBox;
        private System.Windows.Forms.TextBox Dri_mailBox;
        private System.Windows.Forms.TextBox Dri_Drive_LicNoBox;
        private System.Windows.Forms.TextBox Dri_teleBox;
        private System.Windows.Forms.TextBox Dri_NICbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Dri_nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DriverGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dri_ClearTextBtn;
        private System.Windows.Forms.Button Dri_DeleteBtn;
        private System.Windows.Forms.Button Dri_SaveBtn;
        private System.Windows.Forms.Button Dri_UpdateBtn;
        private System.Windows.Forms.Button Dri_SearchClrBtn;
        private System.Windows.Forms.Button Dri_SearchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}