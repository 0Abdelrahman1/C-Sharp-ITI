using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D13___WinForms
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaPrds;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlDaPrds.Fill(dtProducts); ///Open sqlCN , Execute Select Command , fill Data Table with Data , Close Connection

            grdViewPrds.DataSource = dtProducts; //Simple Data Binding 

        }
        DataTable dtProducts = new();
        private void frmProductsGridView_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
            sqlCmd = new("Select * from Products", sqlCn);

            sqlDaPrds = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaPrds);

            sqlDaPrds.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaPrds.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaPrds.DeleteCommand = commandBuilder.GetDeleteCommand();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtProducts.Rows)
            {
                Trace.WriteLine(row.RowState);
            }

            sqlDaPrds.Update(dtProducts); ///Commit Changes into Database From dtProducts
        }
    }
}
