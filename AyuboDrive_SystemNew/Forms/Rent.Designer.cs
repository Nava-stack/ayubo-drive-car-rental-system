
namespace AyuboDrive_SystemNew.Forms
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R_SaveBtn = new System.Windows.Forms.Button();
            this.R_ClearTextBtn = new System.Windows.Forms.Button();
            this.R_DeleteBtn = new System.Windows.Forms.Button();
            this.R_UpdateBtn = new System.Windows.Forms.Button();
            this.RentGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rent_search = new System.Windows.Forms.TextBox();
            this.Rent_SearchBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.RentDriverSttsYes = new System.Windows.Forms.RadioButton();
            this.RentDriverSttsNo = new System.Windows.Forms.RadioButton();
            this.R_VehiCombo = new System.Windows.Forms.ComboBox();
            this.R_DriCombo = new System.Windows.Forms.ComboBox();
            this.R_CusCombo = new System.Windows.Forms.ComboBox();
            this.Rent_OrdDateTime = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Rent_IdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.R_SaveBtn);
            this.groupBox1.Controls.Add(this.R_ClearTextBtn);
            this.groupBox1.Controls.Add(this.R_DeleteBtn);
            this.groupBox1.Controls.Add(this.R_UpdateBtn);
            this.groupBox1.Controls.Add(this.RentGrid);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RentDriverSttsYes);
            this.groupBox1.Controls.Add(this.RentDriverSttsNo);
            this.groupBox1.Controls.Add(this.R_VehiCombo);
            this.groupBox1.Controls.Add(this.R_DriCombo);
            this.groupBox1.Controls.Add(this.R_CusCombo);
            this.groupBox1.Controls.Add(this.Rent_OrdDateTime);
            this.groupBox1.Controls.Add(this.ReturnDate);
            this.groupBox1.Controls.Add(this.RentDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Rent_IdBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 520);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Details";
            // 
            // R_SaveBtn
            // 
            this.R_SaveBtn.BackColor = System.Drawing.Color.Honeydew;
            this.R_SaveBtn.FlatAppearance.BorderSize = 0;
            this.R_SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_SaveBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_SaveBtn.Location = new System.Drawing.Point(650, 449);
            this.R_SaveBtn.Name = "R_SaveBtn";
            this.R_SaveBtn.Size = new System.Drawing.Size(141, 58);
            this.R_SaveBtn.TabIndex = 92;
            this.R_SaveBtn.Text = "SAVE";
            this.R_SaveBtn.UseVisualStyleBackColor = false;
            this.R_SaveBtn.Click += new System.EventHandler(this.R_SaveBtn_Click);
            // 
            // R_ClearTextBtn
            // 
            this.R_ClearTextBtn.BackColor = System.Drawing.Color.Honeydew;
            this.R_ClearTextBtn.FlatAppearance.BorderSize = 0;
            this.R_ClearTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_ClearTextBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_ClearTextBtn.Location = new System.Drawing.Point(490, 449);
            this.R_ClearTextBtn.Name = "R_ClearTextBtn";
            this.R_ClearTextBtn.Size = new System.Drawing.Size(141, 58);
            this.R_ClearTextBtn.TabIndex = 94;
            this.R_ClearTextBtn.Text = "CLEAR";
            this.R_ClearTextBtn.UseVisualStyleBackColor = false;
            this.R_ClearTextBtn.Click += new System.EventHandler(this.R_ClearTextBtn_Click);
            // 
            // R_DeleteBtn
            // 
            this.R_DeleteBtn.BackColor = System.Drawing.Color.Honeydew;
            this.R_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.R_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_DeleteBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_DeleteBtn.Location = new System.Drawing.Point(971, 449);
            this.R_DeleteBtn.Name = "R_DeleteBtn";
            this.R_DeleteBtn.Size = new System.Drawing.Size(141, 58);
            this.R_DeleteBtn.TabIndex = 95;
            this.R_DeleteBtn.Text = "DELETE";
            this.R_DeleteBtn.UseVisualStyleBackColor = false;
            this.R_DeleteBtn.Click += new System.EventHandler(this.R_DeleteBtn_Click);
            // 
            // R_UpdateBtn
            // 
            this.R_UpdateBtn.BackColor = System.Drawing.Color.Honeydew;
            this.R_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.R_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_UpdateBtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_UpdateBtn.Location = new System.Drawing.Point(811, 449);
            this.R_UpdateBtn.Name = "R_UpdateBtn";
            this.R_UpdateBtn.Size = new System.Drawing.Size(141, 58);
            this.R_UpdateBtn.TabIndex = 93;
            this.R_UpdateBtn.Text = "UPDATE";
            this.R_UpdateBtn.UseVisualStyleBackColor = false;
            this.R_UpdateBtn.Click += new System.EventHandler(this.R_UpdateBtn_Click);
            // 
            // RentGrid
            // 
            this.RentGrid.AllowUserToAddRows = false;
            this.RentGrid.AllowUserToDeleteRows = false;
            this.RentGrid.AllowUserToResizeColumns = false;
            this.RentGrid.AllowUserToResizeRows = false;
            this.RentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentGrid.Location = new System.Drawing.Point(488, 143);
            this.RentGrid.Name = "RentGrid";
            this.RentGrid.ReadOnly = true;
            this.RentGrid.Size = new System.Drawing.Size(625, 297);
            this.RentGrid.TabIndex = 91;
            this.RentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentGrid_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rent_search);
            this.groupBox2.Controls.Add(this.Rent_SearchBtn);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(488, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 122);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Driver";
            // 
            // Rent_search
            // 
            this.Rent_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rent_search.Location = new System.Drawing.Point(102, 29);
            this.Rent_search.Name = "Rent_search";
            this.Rent_search.Size = new System.Drawing.Size(97, 25);
            this.Rent_search.TabIndex = 51;
            // 
            // Rent_SearchBtn
            // 
            this.Rent_SearchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Rent_SearchBtn.FlatAppearance.BorderSize = 0;
            this.Rent_SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rent_SearchBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_SearchBtn.Location = new System.Drawing.Point(102, 71);
            this.Rent_SearchBtn.Name = "Rent_SearchBtn";
            this.Rent_SearchBtn.Size = new System.Drawing.Size(67, 25);
            this.Rent_SearchBtn.TabIndex = 78;
            this.Rent_SearchBtn.Text = "Search";
            this.Rent_SearchBtn.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(20, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 22);
            this.label13.TabIndex = 50;
            this.label13.Text = "Rent ID :";
            // 
            // RentDriverSttsYes
            // 
            this.RentDriverSttsYes.AutoSize = true;
            this.RentDriverSttsYes.Location = new System.Drawing.Point(212, 154);
            this.RentDriverSttsYes.Name = "RentDriverSttsYes";
            this.RentDriverSttsYes.Size = new System.Drawing.Size(45, 19);
            this.RentDriverSttsYes.TabIndex = 89;
            this.RentDriverSttsYes.Text = "Yes";
            this.RentDriverSttsYes.UseVisualStyleBackColor = true;
            this.RentDriverSttsYes.CheckedChanged += new System.EventHandler(this.RentDriverSttsYes_CheckedChanged);
            // 
            // RentDriverSttsNo
            // 
            this.RentDriverSttsNo.AutoSize = true;
            this.RentDriverSttsNo.Location = new System.Drawing.Point(281, 154);
            this.RentDriverSttsNo.Name = "RentDriverSttsNo";
            this.RentDriverSttsNo.Size = new System.Drawing.Size(41, 19);
            this.RentDriverSttsNo.TabIndex = 89;
            this.RentDriverSttsNo.Text = "No";
            this.RentDriverSttsNo.UseVisualStyleBackColor = true;
            this.RentDriverSttsNo.CheckedChanged += new System.EventHandler(this.RentDriverSttsNo_CheckedChanged);
            // 
            // R_VehiCombo
            // 
            this.R_VehiCombo.FormattingEnabled = true;
            this.R_VehiCombo.Location = new System.Drawing.Point(210, 237);
            this.R_VehiCombo.Name = "R_VehiCombo";
            this.R_VehiCombo.Size = new System.Drawing.Size(254, 23);
            this.R_VehiCombo.TabIndex = 87;
            this.R_VehiCombo.SelectedIndexChanged += new System.EventHandler(this.R_VehiCombo_SelectedIndexChanged);
            // 
            // R_DriCombo
            // 
            this.R_DriCombo.FormattingEnabled = true;
            this.R_DriCombo.Location = new System.Drawing.Point(210, 191);
            this.R_DriCombo.Name = "R_DriCombo";
            this.R_DriCombo.Size = new System.Drawing.Size(254, 23);
            this.R_DriCombo.TabIndex = 85;
            this.R_DriCombo.SelectedIndexChanged += new System.EventHandler(this.R_DriCombo_SelectedIndexChanged);
            // 
            // R_CusCombo
            // 
            this.R_CusCombo.FormattingEnabled = true;
            this.R_CusCombo.Location = new System.Drawing.Point(210, 70);
            this.R_CusCombo.Name = "R_CusCombo";
            this.R_CusCombo.Size = new System.Drawing.Size(254, 23);
            this.R_CusCombo.TabIndex = 84;
            this.R_CusCombo.SelectedIndexChanged += new System.EventHandler(this.R_CusCombo_SelectedIndexChanged);
            // 
            // Rent_OrdDateTime
            // 
            this.Rent_OrdDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Rent_OrdDateTime.Location = new System.Drawing.Point(210, 111);
            this.Rent_OrdDateTime.Name = "Rent_OrdDateTime";
            this.Rent_OrdDateTime.Size = new System.Drawing.Size(119, 23);
            this.Rent_OrdDateTime.TabIndex = 83;
            this.Rent_OrdDateTime.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            this.Rent_OrdDateTime.ValueChanged += new System.EventHandler(this.Rent_OrdDateTime_ValueChanged);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDate.Location = new System.Drawing.Point(330, 279);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(101, 23);
            this.ReturnDate.TabIndex = 82;
            this.ReturnDate.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // RentDate
            // 
            this.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RentDate.Location = new System.Drawing.Point(210, 279);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(101, 23);
            this.RentDate.TabIndex = 80;
            this.RentDate.Value = new System.DateTime(2022, 11, 17, 17, 43, 18, 0);
            this.RentDate.ValueChanged += new System.EventHandler(this.RentDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(83, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 77;
            this.label6.Text = "Rent Period :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(124, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Vehicle :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(74, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 22);
            this.label12.TabIndex = 69;
            this.label12.Text = "Driver Status :";
            // 
            // Rent_IdBox
            // 
            this.Rent_IdBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_IdBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rent_IdBox.Location = new System.Drawing.Point(210, 24);
            this.Rent_IdBox.Name = "Rent_IdBox";
            this.Rent_IdBox.ReadOnly = true;
            this.Rent_IdBox.Size = new System.Drawing.Size(146, 25);
            this.Rent_IdBox.TabIndex = 57;
            this.Rent_IdBox.TextChanged += new System.EventHandler(this.Rent_IdBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(122, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Rent ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(132, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Driver :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Order Date and Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Customer :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 539);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RentDriverSttsYes;
        private System.Windows.Forms.RadioButton RentDriverSttsNo;
        private System.Windows.Forms.ComboBox R_VehiCombo;
        private System.Windows.Forms.ComboBox R_DriCombo;
        private System.Windows.Forms.ComboBox R_CusCombo;
        private System.Windows.Forms.DateTimePicker Rent_OrdDateTime;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Rent_IdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Rent_search;
        private System.Windows.Forms.Button Rent_SearchBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button R_SaveBtn;
        private System.Windows.Forms.Button R_ClearTextBtn;
        private System.Windows.Forms.Button R_DeleteBtn;
        private System.Windows.Forms.Button R_UpdateBtn;
        private System.Windows.Forms.DataGridView RentGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}