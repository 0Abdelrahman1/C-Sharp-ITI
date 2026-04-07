using Dapper;
using HotelManagementSystem.Entities.LoginManager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem.Dapper
{
    public class FrontendManager
    {
        DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=LoginManager;Integrated Security=True;Encrypt=false");

        public Frontend GetByUsernamePassword(string username, string password)
            => CN.QueryFirstOrDefault<Frontend>(
                $"""
                SELECT user_name AS {nameof(Frontend.UserName)},
                       pass_word AS {nameof(Frontend.PassWord)}
                FROM Frontends WHERE user_name=@user_name AND pass_word=@pass_word
                """, new { user_name = username, pass_word = password}) ?? throw new Exception("No Such username and password");
    }
}
