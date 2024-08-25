
namespace AyuboDrive_SystemNew.Forms
{
    partial class Vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.VehiTypeCombo = new System.Windows.Forms.ComboBox();
            this.Vehi_Ins_Expiry = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Vehi_Lic_Expiry = new System.Windows.Forms.DateTimePicker();
            this.Vehi_LicNoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vehi_InsNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.V_ColorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Vehi_SearchBtn = new System.Windows.Forms.Button();
            this.Vehi_searchNoBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.VehicleGrid = new System.Windows.Forms.DataGridView();
            this.VehiNoBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.V_BrandBox = new System.Windows.Forms.TextBox();
            this.Vehi_nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehi_IdBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vehi_SaveBtn = new System.Windows.Forms.Button();
            this.Vehi_ClearTextBtn = new System.Windows.Forms.Button();
            this.Vehi_DeleteBtn = new System.Windows.Forms.Button();
            this.Vehi_UpdateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiTypeCombo
            // 
            this.VehiTypeCombo.FormattingEnabled = true;
            this.VehiTypeCombo.Location = new System.Drawing.Point(193, 99);
            this.VehiTypeCombo.Name = "VehiTypeCombo";
            this.VehiTypeCombo.Size = new System.Drawing.Size(254, 23);
            this.VehiTypeCombo.TabIndex = 83;
            // 
            // Vehi_Ins_Expiry
            // 
            this.Vehi_Ins_Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Vehi_Ins_Expiry.Location = new System.Drawing.Point(191, 280);
            this.Vehi_Ins_Expiry.Name = "Vehi_Ins_Expiry";
            this.Vehi_Ins_Expiry.Size = new System.Drawing.Size(101, 23);
            this.Vehi_Ins_Expiry.TabIndex = 82;
            this.Vehi_Ins_Expiry.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(41, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 81;
            this.label9.Text = "License Expiry :";
            // 
            // Vehi_Lic_Expiry
            // 
            this.Vehi_Lic_Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Vehi_Lic_Expiry.Location = new System.Drawing.Point(192, 345);
            this.Vehi_Lic_Expiry.Name = "Vehi_Lic_Expiry";
            this.Vehi_Lic_Expiry.Size = new System.Drawing.Size(101, 23);
            this.Vehi_Lic_Expiry.TabIndex = 80;
            this.Vehi_Lic_Expiry.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            // 
            // Vehi_LicNoBox
            // 
            this.Vehi_LicNoBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_LicNoBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vehi_LicNoBox.Location = new System.Drawing.Point(192, 309);
            this.Vehi_LicNoBox.Name = "Vehi_LicNoBox";
            this.Vehi_LicNoBox.Size = new System.Drawing.Size(256, 25);
            this.Vehi_LicNoBox.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(2, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 22);
            this.label8.TabIndex = 78;
            this.label8.Text = "Vehicle License  No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 77;
            this.label6.Text = "Insurance Expiry :";
            // 
            // Vehi_InsNo
            // 
            this.Vehi_InsNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_InsNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vehi_InsNo.Location = new System.Drawing.Point(191, 243);
            this.Vehi_InsNo.Name = "Vehi_InsNo";
            this.Vehi_InsNo.Size = new System.Drawing.Size(256, 25);
            this.Vehi_InsNo.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(52, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "Insurance No :";
            // 
            // V_ColorBox
            // 
            this.V_ColorBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_ColorBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.V_ColorBox.Location = new System.Drawing.Point(191, 208);
            this.V_ColorBox.Name = "V_ColorBox";
            this.V_ColorBox.Size = new System.Drawing.Size(256, 25);
            this.V_ColorBox.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(118, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Color :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Vehi_SearchBtn);
            this.groupBox2.Controls.Add(this.Vehi_searchNoBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(471, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 115);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Vehicle";
            // 
            // Vehi_SearchBtn
            // 
            this.Vehi_SearchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Vehi_SearchBtn.FlatAppearance.BorderSize = 0;
            this.Vehi_SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehi_SearchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_SearchBtn.Location = new System.Drawing.Point(155, 66);
            this.Vehi_SearchBtn.Name = "Vehi_SearchBtn";
            this.Vehi_SearchBtn.Size = new System.Drawing.Size(90, 25);
            this.Vehi_SearchBtn.TabIndex = 88;
            this.Vehi_SearchBtn.Text = "Search";
            this.Vehi_SearchBtn.UseVisualStyleBackColor = false;
            this.Vehi_SearchBtn.Click += new System.EventHandler(this.Vehi_SearchBtn_Click);
            // 
            // Vehi_searchNoBox
            // 
            this.Vehi_searchNoBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_searchNoBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vehi_searchNoBox.Location = new System.Drawing.Point(121, 25);
            this.Vehi_searchNoBox.Name = "Vehi_searchNoBox";
            this.Vehi_searchNoBox.Size = new System.Drawing.Size(155, 25);
            this.Vehi_searchNoBox.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 22);
            this.label13.TabIndex = 50;
            this.label13.Text = "Vehicle No :";
            // 
            // VehicleGrid
            // 
            this.VehicleGrid.AllowUserToAddRows = false;
            this.VehicleGrid.AllowUserToDeleteRows = false;
            this.VehicleGrid.AllowUserToResizeColumns = false;
            this.VehicleGrid.AllowUserToResizeRows = false;
            this.VehicleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VehicleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGrid.Location = new System.Drawing.Point(471, 140);
            this.VehicleGrid.Name = "VehicleGrid";
            this.VehicleGrid.ReadOnly = true;
            this.VehicleGrid.Size = new System.Drawing.Size(578, 194);
            this.VehicleGrid.TabIndex = 43;
            this.VehicleGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleGrid_CellClick);
            // 
            // VehiNoBox
            // 
            this.VehiNoBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiNoBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VehiNoBox.Location = new System.Drawing.Point(191, 134);
            this.VehiNoBox.Name = "VehiNoBox";
            this.VehiNoBox.Size = new System.Drawing.Size(147, 25);
            this.VehiNoBox.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(75, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 22);
            this.label12.TabIndex = 69;
            this.label12.Text = "Vehicle No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(80, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Vehicle ID :";
            // 
            // V_BrandBox
            // 
            this.V_BrandBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_BrandBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.V_BrandBox.Location = new System.Drawing.Point(192, 171);
            this.V_BrandBox.Name = "V_BrandBox";
            this.V_BrandBox.Size = new System.Drawing.Size(256, 25);
            this.V_BrandBox.TabIndex = 53;
            // 
            // Vehi_nameBox
            // 
            this.Vehi_nameBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_nameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vehi_nameBox.Location = new System.Drawing.Point(192, 59);
            this.Vehi_nameBox.Name = "Vehi_nameBox";
            this.Vehi_nameBox.Size = new System.Drawing.Size(256, 25);
            this.Vehi_nameBox.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(95, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "V_Brand :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vehicle Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vehicle Name :";
            // 
            // Vehi_IdBox
            // 
            this.Vehi_IdBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_IdBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vehi_IdBox.Location = new System.Drawing.Point(192, 19);
            this.Vehi_IdBox.Name = "Vehi_IdBox";
            this.Vehi_IdBox.ReadOnly = true;
            this.Vehi_IdBox.Size = new System.Drawing.Size(146, 25);
            this.Vehi_IdBox.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Vehi_SaveBtn);
            this.groupBox1.Controls.Add(this.Vehi_ClearTextBtn);
            this.groupBox1.Controls.Add(this.Vehi_DeleteBtn);
            this.groupBox1.Controls.Add(this.Vehi_UpdateBtn);
            this.groupBox1.Controls.Add(this.VehicleGrid);
            this.groupBox1.Controls.Add(this.VehiTypeCombo);
            this.groupBox1.Controls.Add(this.Vehi_Ins_Expiry);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Vehi_Lic_Expiry);
            this.groupBox1.Controls.Add(this.Vehi_LicNoBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Vehi_InsNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.V_ColorBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.VehiNoBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Vehi_IdBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.V_BrandBox);
            this.groupBox1.Controls.Add(this.Vehi_nameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 410);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // Vehi_SaveBtn
            // 
            this.Vehi_SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Vehi_SaveBtn.FlatAppearance.BorderSize = 0;
            this.Vehi_SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehi_SaveBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_SaveBtn.Location = new System.Drawing.Point(631, 342);
            this.Vehi_SaveBtn.Name = "Vehi_SaveBtn";
            this.Vehi_SaveBtn.Size = new System.Drawing.Size(114, 58);
            this.Vehi_SaveBtn.TabIndex = 84;
            this.Vehi_SaveBtn.Text = "SAVE";
            this.Vehi_SaveBtn.UseVisualStyleBackColor = false;
            this.Vehi_SaveBtn.Click += new System.EventHandler(this.Vehi_SaveBtn_Click);
            // 
            // Vehi_ClearTextBtn
            // 
            this.Vehi_ClearTextBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Vehi_ClearTextBtn.FlatAppearance.BorderSize = 0;
            this.Vehi_ClearTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehi_ClearTextBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_ClearTextBtn.Location = new System.Drawing.Point(473, 342);
            this.Vehi_ClearTextBtn.Name = "Vehi_ClearTextBtn";
            this.Vehi_ClearTextBtn.Size = new System.Drawing.Size(114, 58);
            this.Vehi_ClearTextBtn.TabIndex = 86;
            this.Vehi_ClearTextBtn.Text = "CLEAR";
            this.Vehi_ClearTextBtn.UseVisualStyleBackColor = false;
            this.Vehi_ClearTextBtn.Click += new System.EventHandler(this.Vehi_ClearTextBtn_Click);
            // 
            // Vehi_DeleteBtn
            // 
            this.Vehi_DeleteBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Vehi_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.Vehi_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehi_DeleteBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_DeleteBtn.Location = new System.Drawing.Point(934, 342);
            this.Vehi_DeleteBtn.Name = "Vehi_DeleteBtn";
            this.Vehi_DeleteBtn.Size = new System.Drawing.Size(114, 58);
            this.Vehi_DeleteBtn.TabIndex = 87;
            this.Vehi_DeleteBtn.Text = "DELETE";
            this.Vehi_DeleteBtn.UseVisualStyleBackColor = false;
            this.Vehi_DeleteBtn.Click += new System.EventHandler(this.Vehi_DeleteBtn_Click);
            // 
            // Vehi_UpdateBtn
            // 
            this.Vehi_UpdateBtn.BackColor = System.Drawing.Color.Honeydew;
            this.Vehi_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.Vehi_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vehi_UpdateBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehi_UpdateBtn.Location = new System.Drawing.Point(783, 342);
            this.Vehi_UpdateBtn.Name = "Vehi_UpdateBtn";
            this.Vehi_UpdateBtn.Size = new System.Drawing.Size(114, 58);
            this.Vehi_UpdateBtn.TabIndex = 85;
            this.Vehi_UpdateBtn.Text = "UPDATE";
            this.Vehi_UpdateBtn.UseVisualStyleBackColor = false;
            this.Vehi_UpdateBtn.Click += new System.EventHandler(this.Vehi_UpdateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 417);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicle";
            this.ShowInTaskbar = false;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox VehiTypeCombo;
        private System.Windows.Forms.DateTimePicker Vehi_Ins_Expiry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Vehi_Lic_Expiry;
        private System.Windows.Forms.TextBox Vehi_LicNoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Vehi_InsNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox V_ColorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Vehi_searchNoBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView VehicleGrid;
        private System.Windows.Forms.TextBox VehiNoBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox V_BrandBox;
        private System.Windows.Forms.TextBox Vehi_nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vehi_IdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Vehi_SaveBtn;
        private System.Windows.Forms.Button Vehi_ClearTextBtn;
        private System.Windows.Forms.Button Vehi_DeleteBtn;
        private System.Windows.Forms.Button Vehi_UpdateBtn;
        private System.Windows.Forms.Button Vehi_SearchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}