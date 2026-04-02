using Dapper;
using HotelManagementSystem.Entities.FrontendReservation;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace HotelManagementSystem.Dapper
{
    public class ReservationManager
    {
        DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=FrontendReservation;Integrated Security=True;Encrypt=false");

        //public Reservation GetByUsernamePassword(string username, string password)
        //    => CN.QueryFirstOrDefault<Frontend>("SELECT * FROM Frontends WHERE user_name=@userName AND pass_word=@password", new { userName = username, password = password }) ?? throw new Exception("No Such username and password");

        public Reservation GetById(int id)
            => CN.QueryFirstOrDefault<Reservation>("SELECT * FROM Reservations WHERE Id = @Id", new { Id = id }) ?? throw new Exception("No Such Id Found");
        public List<Reservation> GetAll()
            => CN.Query<Reservation>("SELECT * FROM Reservations").AsList();

        public List<Reservation> GetByCheckIn(bool checkIn)
            => CN.Query<Reservation>("SELECT * FROM Reservations WHERE check_in = @check_in;", new { check_in = checkIn }).AsList();

        public List<Reservation> SearchLikeBy(string searchText)
            => CN.Query<Reservation>(
                $"""
                SELECT * FROM Reservations
                WHERE Id LIKE @Pattern
                    OR last_name LIKE @Pattern
                    OR first_name LIKE @Pattern
                    OR gender LIKE @Pattern
                    OR state LIKE @Pattern
                    OR city LIKE @Pattern
                    OR room_number LIKE @Pattern
                    OR room_type LIKE @Pattern
                    OR email_address LIKE @Pattern
                    OR phone_number LIKE @Pattern;
                """, new { Pattern = $"%{searchText}%" }).AsList();
    }
}
