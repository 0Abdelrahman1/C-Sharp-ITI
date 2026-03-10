using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsDetailedView : Form
    {
        public frmProductsDetailedView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaPrds;
        DataTable dtPrds = new();

        BindingSource prdBindingSource;
        BindingNavigator BindingNavigator;
        private void frmProductsDetailedView_Load(object sender, EventArgs e)
        {


            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
            sqlCmd = new("Select * from Products", sqlCn);

            sqlDaPrds = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaPrds);

            sqlDaPrds.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaPrds.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaPrds.DeleteCommand = commandBuilder.GetDeleteCommand();

            sqlDaPrds.Fill(dtPrds);

            lstProducts.DataSource = dtPrds;
            lstProducts.DisplayMember = "ProductName";
            lstProducts.ValueMember = "ProductID";

            prdBindingSource = new BindingSource(dtPrds, "");
            BindingNavigator = new BindingNavigator(prdBindingSource);
            BindingNavigator.Dock = DockStyle.Top;

            this.Controls.Add(BindingNavigator);

            lblProductID.DataBindings.Add("Text", prdBindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", prdBindingSource, "ProductName");
            numUnitPrice.DataBindings.Add("value", prdBindingSource, "UnitPrice");

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = lstProducts.SelectedValue.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prdBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            prdBindingSource.MoveNext();
        }
    }
}
