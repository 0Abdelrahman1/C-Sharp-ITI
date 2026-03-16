using detailedView.Context;
using detailedView.Entities;
using Microsoft.EntityFrameworkCore;

namespace detailedView
{
    public partial class frmDetailedView : Form
    {
        public frmDetailedView()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context?.Dispose();
        }

        pubsContext Context = new();
        BindingSource titlesBindingSource = new();
        BindingSource publishersBindingSource = new();
        BindingNavigator bindingNavigator = new();
        private void frmDetailedView_Load(object sender, EventArgs e)
        {
            Context.Titles.Load();
            Context.Publishers.Load();

            titlesBindingSource.DataSource = Context.Titles.Local.ToBindingList();
            publishersBindingSource.DataSource = Context.Publishers.Local.ToBindingList();
            bindingNavigator = new BindingNavigator(titlesBindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(bindingNavigator);

            titlesBindingSource.AddingNew += (sender, e) =>
            {
                e.NewObject = new Title
                {
                    TitleId ="_",
                    Title1 = "_",
                    Type = "UNDECIDED",
                    Pubdate = DateTime.Now,
                    Price = null,
                    Advance = null,
                    Royalty = null,
                    YtdSales = null
                };
                button1_Click(new(), new());
            };

            txtTitleId.DataBindings.Add("Text", titlesBindingSource, "TitleId");
            txtTitle.DataBindings.Add("Text", titlesBindingSource, "Title1");
            txtType.DataBindings.Add("Text", titlesBindingSource, "Type");

            cmbPublisherName.DataSource = publishersBindingSource;
            cmbPublisherName.DisplayMember = "PubName";
            cmbPublisherName.ValueMember = "PubId";
            cmbPublisherName.DataBindings.Add("SelectedValue", titlesBindingSource, "PubId");

            BindNullableNumber(txtPrice, "Price");
            BindNullableNumber(txtAdvance, "Advance");
            BindNullableNumber(txtRoyalty, "Royalty");
            BindNullableNumber(txtYtdSales, "YtdSales");

            richTxtNotes.DataBindings.Add("Text", titlesBindingSource, "Notes");
            datePublishDate.DataBindings.Add("Value", titlesBindingSource, "Pubdate");
        }

        // ai
        private void BindNullableNumber(TextBox textBox, string memberName)
        {
            var b = textBox.DataBindings.Add("Text", titlesBindingSource, memberName, true, DataSourceUpdateMode.OnValidation);
            b.NullValue = "";
            b.DataSourceNullValue = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            titlesBindingSource.EndEdit();

            int C = 0, U = 0, D = 0;
            foreach (var t in Context.Titles)
                switch (Context.Entry(t).State)
                {
                    case EntityState.Added: C++; break;
                    case EntityState.Modified: U++; break;
                    case EntityState.Deleted: D++; break;
                }
            this.Text = $"[{C} Added, {U} Updated, {D} Deleted] Successfully !\t--{Context.SaveChanges()} Rows Affected!--";
        }
    }
}
