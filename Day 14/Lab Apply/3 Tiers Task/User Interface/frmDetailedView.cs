using Business_Logic_Layer.Entities;
using Business_Logic_Layer.EntityLists;
using Business_Logic_Layer.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class frmDetailedView : Form
    {
        public frmDetailedView()
        {
            InitializeComponent();
        }

        TitleList titles;
        PublisherIdNameList publishersIdName;
        BindingSource titlesBindingSource = new();
        BindingSource publishersIdNameBindingSource = new();
        BindingNavigator bindingNavigator;
        private void frmDetailedView_Load(object sender, EventArgs e)
        {
            titles = TitleManager.SelectAllTitles();
            titlesBindingSource.DataSource = titles;

            publishersIdName = PublisherManager.SelectAllPublishersIdName();
            publishersIdNameBindingSource.DataSource = publishersIdName;

            bindingNavigator = new BindingNavigator(titlesBindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            bindingNavigator.DeleteItem.Visible = false;
            this.Controls.Add(bindingNavigator);

            titlesBindingSource.AddingNew += (sender, e) =>
            {
                string nxt = titles.Max(t => t.title_id);
                if (nxt[0] == 'z')
                {
                    string num = (int.Parse(nxt[1..]) + 1).ToString();
                    nxt = "z" + new string('0', 5 - num.Length) + num;
                }
                else
                    nxt = "z00000";
                e.NewObject = new Title() { title_id = nxt, title = "", type = "", pubdate = DateTime.Now };
            };

            txtTitleId.DataBindings.Add("Text", titlesBindingSource, "title_id");
            txtTitle.DataBindings.Add("Text", titlesBindingSource, "title");
            txtType.DataBindings.Add("Text", titlesBindingSource, "type");

            cmbPublisherName.DataSource = publishersIdNameBindingSource;
            cmbPublisherName.DisplayMember = "pub_name";
            cmbPublisherName.ValueMember = "pub_id";
            cmbPublisherName.DataBindings.Add("SelectedValue", titlesBindingSource, "pub_id");

            BindNullableNumber(txtPrice, "price");
            BindNullableNumber(txtAdvance, "advance");
            BindNullableNumber(txtRoyalty, "royalty");
            BindNullableNumber(txtYtdSales, "ytd_sales");

            richTxtNotes.DataBindings.Add("Text", titlesBindingSource, "notes");
            datePublishDate.DataBindings.Add("Value", titlesBindingSource, "pubdate");

            lblState.DataBindings.Add("Text", titlesBindingSource, "State");
        }

        private void BindNullableNumber(TextBox textBox, string memberName) //ai
        {
            var b = textBox.DataBindings.Add("Text", titlesBindingSource, memberName, true);
            b.NullValue = "";
            b.DataSourceNullValue = null;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            titlesBindingSource.EndEdit();
            foreach (var title in titles) Trace.WriteLine(title);
            var Changes = titles.SaveChanges();
            titlesBindingSource.ResetBindings(false);
            this.Text = $"Added: {Changes.Item1}, Modified:{Changes.Item2}, Deleted:{Changes.Item3}";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (titlesBindingSource.Current is Title title)
            {
                title.State = EntityState.Deleted;
                titlesBindingSource.ResetBindings(false);
            }
        }
    }
}
