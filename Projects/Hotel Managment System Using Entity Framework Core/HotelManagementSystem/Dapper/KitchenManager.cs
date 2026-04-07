using Dapper;
using HotelManagementSystem.Entities.LoginManager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace HotelManagementSystem.Dapper
{
    public class KitchenManager
    {
        DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=LoginManager;Integrated Security=True;Encrypt=false");

        public Kitchen GetByUsernamePassword(string username, string password)
            => CN.QueryFirstOrDefault<Kitchen>(
                $"""
                SELECT user_name AS {nameof(Frontend.UserName)},
                       pass_word AS {nameof(Frontend.PassWord)}
                FROM Kitchens WHERE user_name=@user_name AND pass_word=@pass_word
                """, new { user_name = username, pass_word = password }) ?? throw new Exception("No Such username and password");

    }
}
