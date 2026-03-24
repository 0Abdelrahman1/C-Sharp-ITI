namespace D13___WinForms
{
    partial class frmProductsDetailedView
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
            lstProducts = new ListBox();
            lblProductID = new Label();
            numUnitPrice = new NumericUpDown();
            txtProductName = new TextBox();
            btnPrev = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(638, 32);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(150, 324);
            lstProducts.TabIndex = 0;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(46, 43);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(50, 20);
            lblProductID.TabIndex = 1;
            lblProductID.Text = "label1";
            // 
            // numUnitPrice
            // 
            numUnitPrice.Location = new Point(46, 139);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(150, 27);
            numUnitPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(46, 84);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 3;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(46, 208);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(50, 29);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(143, 208);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(53, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmProductsDetailedView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(txtProductName);
            Controls.Add(numUnitPrice);
            Controls.Add(lblProductID);
            Controls.Add(lstProducts);
            Name = "frmProductsDetailedView";
            Text = "frmProductsDetailedView";
            Load += frmProductsDetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProducts;
        private Label lblProductID;
        private NumericUpDown numUnitPrice;
        private TextBox txtProductName;
        private Button btnPrev;
        private Button btnNext;
    }
}