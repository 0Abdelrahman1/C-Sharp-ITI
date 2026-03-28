using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.Data.SqlClient;
using Dapper;
namespace DapperProject
{
    public static class TitleManager
    {
        private static DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=True;Encrypt=false");
        public static List<Title> GetALL() => CN.Query<Title>("Select * from titles").AsList();
    }
}
