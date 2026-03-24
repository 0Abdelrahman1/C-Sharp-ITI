namespace Task2
{
    partial class frmDetailedView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            numJobLevel = new NumericUpDown();
            cmbJobId = new ComboBox();
            cmbPublisherName = new ComboBox();
            dateHireDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmbMiddleNameFirstCharacter = new ComboBox();
            btnSaveChanges = new Button();
            txtEmployeeId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numJobLevel).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(254, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(254, 182);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // numJobLevel
            // 
            numJobLevel.Location = new Point(254, 272);
            numJobLevel.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numJobLevel.Name = "numJobLevel";
            numJobLevel.Size = new Size(120, 23);
            numJobLevel.TabIndex = 3;
            // 
            // cmbJobId
            // 
            cmbJobId.FormattingEnabled = true;
            cmbJobId.Location = new Point(254, 228);
            cmbJobId.Name = "cmbJobId";
            cmbJobId.Size = new Size(121, 23);
            cmbJobId.TabIndex = 4;
            // 
            // cmbPublisherName
            // 
            cmbPublisherName.FormattingEnabled = true;
            cmbPublisherName.Location = new Point(254, 322);
            cmbPublisherName.Name = "cmbPublisherName";
            cmbPublisherName.Size = new Size(121, 23);
            cmbPublisherName.TabIndex = 5;
            // 
            // dateHireDate
            // 
            dateHireDate.Location = new Point(254, 383);
            dateHireDate.Name = "dateHireDate";
            dateHireDate.Size = new Size(200, 23);
            dateHireDate.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(31, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Employee ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(31, 97);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(31, 143);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 10;
            label4.Text = "Middle Name First Character:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(31, 190);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 11;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(31, 236);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Job ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(31, 280);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 13;
            label7.Text = "Job Level:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(31, 330);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 14;
            label8.Text = "Publisher Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(31, 391);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 15;
            label9.Text = "Hire Date:";
            // 
            // cmbMiddleNameFirstCharacter
            // 
            cmbMiddleNameFirstCharacter.FormattingEnabled = true;
            cmbMiddleNameFirstCharacter.Location = new Point(254, 135);
            cmbMiddleNameFirstCharacter.Name = "cmbMiddleNameFirstCharacter";
            cmbMiddleNameFirstCharacter.Size = new Size(121, 23);
            cmbMiddleNameFirstCharacter.TabIndex = 16;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveChanges.Location = new Point(524, 322);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(160, 50);
            btnSaveChanges.TabIndex = 17;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(254, 47);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(100, 23);
            txtEmployeeId.TabIndex = 18;
            // 
            // frmDetailedView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 469);
            Controls.Add(txtEmployeeId);
            Controls.Add(btnSaveChanges);
            Controls.Add(cmbMiddleNameFirstCharacter);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateHireDate);
            Controls.Add(cmbPublisherName);
            Controls.Add(cmbJobId);
            Controls.Add(numJobLevel);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "frmDetailedView";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numJobLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private NumericUpDown numJobLevel;
        private ComboBox cmbJobId;
        private ComboBox cmbPublisherName;
        private DateTimePicker dateHireDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmbMiddleNameFirstCharacter;
        private Button btnSaveChanges;
        private TextBox txtEmployeeId;
    }
}
