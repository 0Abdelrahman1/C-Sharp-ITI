namespace D13___WinForms
{
    partial class frmDataReader
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
            button1 = new Button();
            lstPrdNames = new ListBox();
            txtPrdID = new TextBox();
            numUnitProce = new NumericUpDown();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)numUnitProce).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(697, 405);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 0;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstPrdNames
            // 
            lstPrdNames.FormattingEnabled = true;
            lstPrdNames.Location = new Point(638, 12);
            lstPrdNames.Name = "lstPrdNames";
            lstPrdNames.Size = new Size(150, 344);
            lstPrdNames.TabIndex = 1;
            // 
            // txtPrdID
            // 
            txtPrdID.Location = new Point(12, 22);
            txtPrdID.Name = "txtPrdID";
            txtPrdID.Size = new Size(125, 27);
            txtPrdID.TabIndex = 2;
            // 
            // numUnitProce
            // 
            numUnitProce.Location = new Point(12, 76);
            numUnitProce.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUnitProce.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnitProce.Name = "numUnitProce";
            numUnitProce.Size = new Size(150, 27);
            numUnitProce.TabIndex = 3;
            numUnitProce.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmDataReader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(numUnitProce);
            Controls.Add(txtPrdID);
            Controls.Add(lstPrdNames);
            Controls.Add(button1);
            Name = "frmDataReader";
            Text = "frmDataReader";
            Load += frmDataReader_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitProce).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox lstPrdNames;
        private TextBox txtPrdID;
        private NumericUpDown numUnitProce;
        private Button btnUpdate;
    }
}