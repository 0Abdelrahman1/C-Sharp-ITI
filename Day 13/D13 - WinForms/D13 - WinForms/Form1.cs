using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace D13___WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCN = new SqlConnection();
            //sqlCN.ConnectionString = "Data source=.;Initial Catalog=Northwind;Integrated Security=true;Encrypt=false;";
            sqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

            this.Text = ConfigurationManager.AppSettings["BranchID"]?.ToString()??"NA";

            this.FormClosed += (sender, e) => sqlCN?.Dispose();

            sqlCN.StateChange += (sender, e) => this.Text = $"State was {e.OriginalState} , Changed To {e.CurrentState}";

            btnOpen.Click += (sender, e) =>
            {
                if (sqlCN.State == ConnectionState.Closed)
                    sqlCN?.Open();
            };
        }

        SqlConnection sqlCN;

        private void btnClose_Click(object sender, EventArgs e)
        {
            sqlCN.Close();
        }
    }
}
