using detailedView.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace detailedView
{
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        pubsContext Context = new();
        BindingSource titlesBindingSource = new();
        BindingSource publishersBindingSource = new();

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdViewTitles.DataSource = titlesBindingSource;
            DataGridViewComboBoxColumn publisherCol = new DataGridViewComboBoxColumn();
            publisherCol.DataSource = publishersBindingSource;
            publisherCol.DisplayMember = "PubName";
            publisherCol.ValueMember = "PubId";
            publisherCol.DataPropertyName = "PubId";

            publisherCol.HeaderText = "Publisher Name";
            grdViewTitles.Columns.Add(publisherCol);
            grdViewTitles.Columns["PubId"].Visible = false;
            grdViewTitles.Columns["Pub"].Visible = false;
        }

        private void frmGridView_Load(object sender, EventArgs e)
        {
            Context.Titles.Load();
            Context.Publishers.Load();

            titlesBindingSource.DataSource = Context.Titles.Local.ToBindingList();
            publishersBindingSource.DataSource = Context.Publishers.Local.ToBindingList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdViewTitles.EndEdit();
            Context.SaveChanges();
        }
    }
}
