using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;
using System.Data.SqlTypes;

namespace Data_Access_Layer
{
    public class DbManager
    {
        SqlConnection sqlCn;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDa;
        DataTable dt;

        public DbManager()
        {
            try
            {
                sqlCn = new SqlConnection();
                sqlCn.ConnectionString = "Data source=.;Initial Catalog=pubs;Integrated Security=true;Encrypt=false;";
                sqlCmd = new SqlCommand("", sqlCn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlDa = new SqlDataAdapter(sqlCmd);
                dt = new();
            }
            finally{ }
        }

        public int ExecuteNonQuery(string spName, Dictionary<string, object> parameters = default)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = spName;

                foreach (var param in parameters ?? new())
                    sqlCmd.Parameters.Add(new SqlParameter(param.Key, param.Value ?? DBNull.Value));

                if (sqlCn.State != ConnectionState.Open)
                    sqlCn.Open();
                return sqlCmd.ExecuteNonQuery();
            } catch { return -1; }
            finally 
            {
                sqlCn.Close();
            }
        }

        public object ExecuteScalar(string spName, Dictionary<string, object> parameters = default)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = spName;

                foreach (var param in parameters ?? new())
                    sqlCmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                if (sqlCn.State != ConnectionState.Open)
                    sqlCn.Open();
                return sqlCmd.ExecuteScalar();
            } catch { return new(); }
            finally
            {
                sqlCn.Close();
            }
        }

        public DataTable ExecuteDataTable(string spName, Dictionary<string, object> parameters = default)
        {
            try
            {
                dt.Clear();
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = spName;

                foreach (var param in parameters ?? new())
                    sqlCmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                sqlDa.Fill(dt);
                return dt;
            } catch { return new(); }
            finally {}
        }

        //public DataTable ExecuteDataReader(string spName)
        //{
        //    try
        //    {
        //        dt.Clear();
        //        sqlCmd.CommandText = spName;

        //        if (sqlCn.State != ConnectionState.Open)
        //            sqlCn.Open();
        //        using (SqlDataReader reader = sqlCmd.ExecuteReader())
        //        {
        //            // Add column schema to DataTable
        //            for (int i = 0; i < reader.FieldCount; i++)
        //                dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));

        //            // Read rows and populate DataTable
        //            while (reader.Read())
        //            {
        //                DataRow row = dt.NewRow();
        //                for (int i = 0; i < reader.FieldCount; i++)
        //                    row[i] = reader.GetValue(i) ?? DBNull.Value;
        //                dt.Rows.Add(row);
        //            }
        //        }
        //        return dt;
        //    }
        //    catch { return new(); }
        //    finally { }
        //}
    }
}
