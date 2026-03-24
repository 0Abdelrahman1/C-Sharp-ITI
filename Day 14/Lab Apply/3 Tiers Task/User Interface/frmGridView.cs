using Business_Logic_Layer.Entities;
using Business_Logic_Layer.EntityLists;
using Business_Logic_Layer.EntityManagers;
using System.Diagnostics;

namespace User_Interface
{
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        TitleList titles;
        PublisherIdNameList publishersIdName;
        BindingSource titlesBindingSource;
        BindingSource publishersIdNameBindingSource;

        private void frmGridView_Load(object sender, EventArgs e)
        {
            titles = TitleManager.SelectAllTitles();
            titlesBindingSource = new(titles, "");

            publishersIdName = PublisherManager.SelectAllPublishersIdName();
            publishersIdNameBindingSource = new(publishersIdName, "");

            titlesBindingSource.AddingNew += (sender, e) =>
            {
                string mx = titles.Max(t => t.title_id);
                if (mx[0] == 'z')
                {
                    string num = (int.Parse(mx[1..]) + 1).ToString();
                    mx = "z" + new string('0', 5 - num.Length) + num;
                }
                else
                    mx = "z00000";
                e.NewObject = new Title() { title_id = mx, title = "", type = "", pubdate = DateTime.Now };
            };
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewTitles.DataSource = titlesBindingSource;

            if (!gridViewTitles.Columns.Contains("pub_id_name"))
            {
                gridViewTitles.Columns["pub_id"].Visible = false;
                gridViewTitles.Columns["State"].ReadOnly = true;
                DataGridViewComboBoxColumn publisherCol = new DataGridViewComboBoxColumn();
                publisherCol.Name = "pub_id_name";
                publisherCol.Width = 150;
                publisherCol.DataSource = publishersIdNameBindingSource;
                publisherCol.DisplayMember = "pub_name";
                publisherCol.ValueMember = "pub_id";
                publisherCol.DataPropertyName = "pub_id";
                publisherCol.HeaderText = "Publisher Name";
                gridViewTitles.Columns.Insert(gridViewTitles.Columns["pub_id"].Index, publisherCol);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewTitles.EndEdit();
            foreach (var title in titles) Trace.WriteLine(title);
            var Changes = titles.SaveChanges();
            titlesBindingSource.ResetBindings(false); 
            this.Text = $"Added: {Changes.Item1}, Modified:{Changes.Item2}, Deleted:{Changes.Item3}";
        }

        private void gridViewTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridViewTitles.CurrentRow != null)
            {
                e.Handled = true;  // Prevent default delete behavior
                gridViewTitles.CurrentRow.Cells["State"].Value = EntityState.Deleted;
                titlesBindingSource.ResetBindings(false);
            }
        }
    }
}
