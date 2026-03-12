using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace Task2
{
    public partial class frmDetailedView : Form
    {
        public frmDetailedView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDaEmps;
        DataTable dtEmps = new(), dtJobs = new(), dtPubs = new();
        BindingSource empBindingSource;
        BindingNavigator bindingNavigator;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            sqlCmd = new("select * from employee", sqlCn);

            sqlDaEmps = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDaEmps);

            sqlDaEmps.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlDaEmps.InsertCommand = commandBuilder.GetInsertCommand();
            sqlDaEmps.DeleteCommand = commandBuilder.GetDeleteCommand();

            sqlDaEmps.Fill(dtEmps);
            new SqlDataAdapter(new SqlCommand("select * from jobs", sqlCn)).Fill(dtJobs);
            new SqlDataAdapter(new SqlCommand("select * from publishers", sqlCn)).Fill(dtPubs);

            empBindingSource = new(dtEmps, "");
            bindingNavigator = new BindingNavigator(empBindingSource);
            bindingNavigator.Dock = DockStyle.Top;
            this.Controls.Add(bindingNavigator);

            txtEmployeeId.DataBindings.Add("Text", empBindingSource, "emp_id");
            
            txtFirstName.DataBindings.Add("Text", empBindingSource, "fname");

            List<string> charList = [" "];
            charList.AddRange(Enumerable.Range('A', 26).Select(c => $"{(char)c}"));
            cmbMiddleNameFirstCharacter.DataSource = charList;
            cmbMiddleNameFirstCharacter.DataBindings.Add("SelectedItem", empBindingSource, "minit");

            txtLastName.DataBindings.Add("Text", empBindingSource, "lname");
            
            cmbJobId.DataSource = dtJobs;
            cmbJobId.DisplayMember = "job_id";
            cmbJobId.ValueMember = "job_id";
            cmbJobId.DataBindings.Add("SelectedValue", empBindingSource, "Job_id");

            numJobLevel.DataBindings.Add("Text", empBindingSource, "Job_lvl");

            cmbPublisherName.DataSource = dtPubs;
            cmbPublisherName.DisplayMember = "pub_name";
            cmbPublisherName.ValueMember = "pub_id";
            cmbPublisherName.DataBindings.Add("SelectedValue", empBindingSource, "pub_id");

            dateHireDate.DataBindings.Add("Text", empBindingSource, "hire_date");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            empBindingSource.EndEdit();
            this.Text = $"{sqlDaEmps.Update(dtEmps)} Rows Affected!";
        }
    }
}
