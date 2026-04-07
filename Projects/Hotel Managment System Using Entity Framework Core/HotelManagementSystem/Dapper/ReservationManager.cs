using Dapper;
using HotelManagementSystem.Entities.FrontendReservation;
using HotelManagementSystem.Entities.LoginManager;
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

        const string DATABASE_AS_OBJECT = 
            $"""
            Id AS {nameof(Reservation.Id)},
            first_name AS {nameof(Reservation.FirstName)},
            last_name AS {nameof(Reservation.LastName)},
            birth_day AS {nameof(Reservation.BirthDay)},
            gender AS {nameof(Reservation.Gender)},
            phone_number AS {nameof(Reservation.PhoneNumber)},
            email_address AS {nameof(Reservation.EmailAddress)},
            number_guest AS {nameof(Reservation.NumberGuest)},
            street_address AS {nameof(Reservation.StreetAddress)},
            apt_suite AS {nameof(Reservation.AptSuite)},
            city AS {nameof(Reservation.City)},
            state AS {nameof(Reservation.State)},
            zip_code AS {nameof(Reservation.ZipCode)},
            room_type AS {nameof(Reservation.RoomType)},
            room_floor AS {nameof(Reservation.RoomFloor)},
            room_number AS {nameof(Reservation.RoomNumber)},
            total_bill AS {nameof(Reservation.TotalBill)},
            payment_type AS {nameof(Reservation.PaymentType)},
            card_type AS {nameof(Reservation.CardType)},
            card_number AS {nameof(Reservation.CardNumber)},
            card_exp AS {nameof(Reservation.CardExp)},
            card_cvc AS {nameof(Reservation.CardCvc)},
            arrival_time AS {nameof(Reservation.ArrivalTime)},
            leaving_time AS {nameof(Reservation.LeavingTime)},
            check_in AS {nameof(Reservation.CheckIn)},
            break_fast AS {nameof(Reservation.BreakFast)},
            lunch AS {nameof(Reservation.Lunch)},
            dinner AS {nameof(Reservation.Dinner)},
            cleaning AS {nameof(Reservation.Cleaning)},
            towel AS {nameof(Reservation.Towel)},
            s_surprise AS {nameof(Reservation.SSurprise)},
            supply_status AS {nameof(Reservation.SupplyStatus)},
            food_bill AS {nameof(Reservation.FoodBill)}
            """;

        public Reservation GetById(int id)
            => CN.QueryFirstOrDefault<Reservation>($"SELECT {DATABASE_AS_OBJECT} FROM Reservations WHERE Id = @Id", new { Id = id }) ?? throw new Exception("No Such Id Found");
                
        public List<Reservation> GetAll()
            => CN.Query<Reservation>($"SELECT {DATABASE_AS_OBJECT} FROM Reservations").AsList();

        public List<Reservation> GetByCheckIn(bool checkIn)
            => CN.Query<Reservation>($"SELECT {DATABASE_AS_OBJECT} FROM Reservations WHERE check_in = @check_in;", new { check_in = checkIn }).AsList();

        public List<Reservation> SearchLikeBy(string searchText)
            => CN.Query<Reservation>(
                $"""
                SELECT {DATABASE_AS_OBJECT} FROM Reservations
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
