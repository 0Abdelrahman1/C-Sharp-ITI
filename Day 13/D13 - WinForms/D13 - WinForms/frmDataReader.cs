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
    public partial class frmDataReader : Form
    {
        public frmDataReader()
        {
            InitializeComponent();
        }
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        private void frmDataReader_Load(object sender, EventArgs e)
        {
            sqlCn = new();
            sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
            sqlCmd = new();
            sqlCmd.Connection = sqlCn;


            sqlCmd.CommandText = "select count(*) from Products";
            sqlCn.Open();
            if (int.TryParse(sqlCmd.ExecuteScalar().ToString(), out int PrdCount))
                this.Text = $"{PrdCount} Products";
            sqlCn.Close();

            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "SelectALLProducts";
            // sqlCmd.CommandText = "Select * from Products";

            sqlUpdateProductPrice = new SqlCommand(string.Empty, sqlCn);

            sqlUpdateProductPrice.CommandText = """
                UPDATE Products
                SET          UnitPrice = @UnitPrice
                WHERE  (ProductID = @ProductID)
                """;
            sqlUpdateProductPrice.Parameters.Add("@UnitPrice", SqlDbType.Money);
            sqlUpdateProductPrice.Parameters.Add("@ProductID", SqlDbType.Int);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlCn.State != ConnectionState.Open)
                sqlCn.Open();
            ///connected Mode
            SqlDataReader Reader = sqlCmd.ExecuteReader();

            while (Reader.Read())
            {
                lstPrdNames.Items.Add(
                    //Reader["ProductName"].ToString()
                    Reader.GetString("ProductName")
                    );

                //Reader["UnitPrice"] = 50;
            }
            sqlCn.Close();
        }

        SqlCommand sqlUpdateProductPrice;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (sqlCn.State  == ConnectionState.Closed)
            sqlCn.Open();
           
            if (int.TryParse(txtPrdID.Text , out int PrdID))
            {
                sqlUpdateProductPrice.Parameters["@ProductID"].Value = PrdID;
                sqlUpdateProductPrice.Parameters["@UnitPrice"].Value = numUnitProce.Value;
            }

            int R = sqlUpdateProductPrice.ExecuteNonQuery();

            this.Text = $"{R} Rows Affected";


            sqlCn.Close();
        }
    }
}
