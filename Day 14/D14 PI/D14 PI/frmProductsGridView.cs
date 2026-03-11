using Microsoft.Data.SqlClient;
using System.Data;

namespace D14_PI
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
        }
        SqlConnection sqlcn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDAPrds;
        DataTable dtPrds;
        SqlCommand sqlcmdSelectAllCategories;
        SqlDataAdapter sqlDaCategories;
        DataTable dtCategories;
        private void frmLoad(object sender, EventArgs e)
        {
            sqlcn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=true;Encrypt=false");
            sqlCmd = new("Select * from Products", sqlcn);
            sqlDAPrds = new(sqlCmd);
            dtPrds = new();

            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDAPrds);
            sqlDAPrds.InsertCommand = builder.GetInsertCommand();
            sqlDAPrds.UpdateCommand = builder.GetUpdateCommand();
            sqlDAPrds.DeleteCommand = builder.GetDeleteCommand();


            sqlcmdSelectAllCategories = new("select CategoryID as CatID , CategoryName  from Categories", sqlcn);
            sqlDaCategories = new(sqlcmdSelectAllCategories);
            dtCategories = new();

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlDAPrds.Fill(dtPrds);
            sqlDaCategories.Fill(dtCategories);

            gridViewPrds.DataSource = dtPrds;
            DataGridViewComboBoxColumn CatCol = new DataGridViewComboBoxColumn();
            CatCol.DataSource = dtCategories;
            CatCol.DisplayMember = "CategoryName"; //from dtCategories Table
            CatCol.ValueMember = "CatID"; //from dtCategories Table
            CatCol.DataPropertyName = "CategoryID"; ///from dtProducts Table
            ///ComboBox Selected Value = CategoryID Field in Product
           
            CatCol.HeaderText = "Category";
            gridViewPrds.Columns.Add(CatCol);

            gridViewPrds.Columns["CategoryID"].Visible = false;


            gridViewPrds.Columns["ProductID"].ReadOnly = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewPrds.EndEdit();

            int R =  sqlDAPrds.Update(dtPrds);

            this.Text = $"{R} Rows Affected";

        }
    }
}
