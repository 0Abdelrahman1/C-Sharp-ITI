namespace Task
{
    public partial class frmRTFNotepad : Form
    {
        public frmRTFNotepad()
        {
            InitializeComponent();
        }

        private void frmRTFNotepad_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRTFNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure\nYou Want to Exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                switch (dlgOpen.FilterIndex)
                {
                    case 1:
                        rtfText.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        rtfText.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
                rtfText.SaveFile(dlgSave.FileName, (RichTextBoxStreamType)(dlgSave.FilterIndex - 1));
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = rtfText.SelectionFont;
            if (dlgFont.ShowDialog() == DialogResult.OK)
                rtfText.SelectionFont = dlgFont.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dlgFont.Color = rtfText.SelectionColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                rtfText.SelectionColor = dlgColor.Color;
        }

        dlgCust dlgCust = new();
        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (dlgCust.ShowDialog() == DialogResult.OK)
                this.rtfText.AppendText(dlgCust.UserTxt.ToUpper());
        }
    }
}