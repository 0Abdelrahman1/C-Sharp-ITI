using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Task1
{
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaEmps;
        DataTable dtEmps = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            sqlCmd = new SqlCommand("select * from employee", sqlCn);

            sqlDaEmps = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaEmps);

            sqlDaEmps.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaEmps.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaEmps.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlDaEmps.Fill(dtEmps);

            grdViewEmps.DataSource = dtEmps;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdViewEmps.EndEdit();
            this.Text = $"{sqlDaEmps.Update(dtEmps)} Rows Affected!";
        }
    }
}
