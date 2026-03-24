
namespace Task
{
    partial class frmRTFNotepad
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
            btnOpen = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnFont = new Button();
            btnColor = new Button();
            btnCustom = new Button();
            rtfText = new RichTextBox();
            dlgSave = new SaveFileDialog();
            dlgOpen = new OpenFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(696, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(354, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFont.Location = new Point(12, 517);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 0;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom;
            btnColor.Location = new Point(354, 517);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 0;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnCustom
            // 
            btnCustom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCustom.Location = new Point(696, 517);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(75, 23);
            btnCustom.TabIndex = 0;
            btnCustom.Text = "Custom";
            btnCustom.UseVisualStyleBackColor = true;
            btnCustom.Click += btnCustom_Click;
            // 
            // rtfText
            // 
            rtfText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtfText.Location = new Point(12, 41);
            rtfText.Name = "rtfText";
            rtfText.Size = new Size(759, 470);
            rtfText.TabIndex = 1;
            rtfText.Text = "";
            // 
            // dlgSave
            // 
            dlgSave.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            dlgSave.InitialDirectory = "E:\\ITI\\Courses\\C#\\Day 12\\Lab Apply\\Self Study Task";
            // 
            // dlgOpen
            // 
            dlgOpen.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            dlgOpen.InitialDirectory = "E:\\ITI\\Courses\\C#\\Day 12\\Lab Apply\\Self Study Task";
            // 
            // frmRTFNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(rtfText);
            Controls.Add(btnCustom);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Name = "frmRTFNotepad";
            Text = "Form1";
            FormClosing += frmRTFNotepad_FormClosing;
            Load += frmRTFNotepad_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnClose;
        private Button btnSave;
        private Button btnFont;
        private Button btnColor;
        private Button btnCustom;
        private RichTextBox rtfText;
        private SaveFileDialog dlgSave;
        private OpenFileDialog dlgOpen;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
    }
}
