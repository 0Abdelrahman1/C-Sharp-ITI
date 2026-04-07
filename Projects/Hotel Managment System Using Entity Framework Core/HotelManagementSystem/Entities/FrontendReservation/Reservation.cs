using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagementSystem.Entities.FrontendReservation
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Column("first_name")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Column("last_name")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Column("birth_day")]
        [MaxLength(50)]
        [Required]
        public string BirthDay { get; set; }

        [Column("gender")]
        [MaxLength(50)]
        [Required]
        public string Gender { get; set; }

        [Column("phone_number")]
        [MaxLength(50)]
        [Required]
        public string PhoneNumber { get; set; }

        [Column("email_address")]
        [Required]
        public string EmailAddress { get; set; }

        [Column("number_guest")]
        [Required]
        public int NumberGuest { get; set; }

        [Column("street_address")]
        [Required]
        public string StreetAddress { get; set; }

        [Column("apt_suite")]
        [MaxLength(50)]
        [Required]
        public string AptSuite { get; set; }

        [Column("city")]
        [Required]
        public string City { get; set; }

        [Column("state")]
        [MaxLength(50)]
        [Required]
        public string State { get; set; }

        [Column("zip_code", TypeName = "nchar(10)")]
        [Required]
        public string ZipCode { get; set; }

        [Column("room_type", TypeName = "nchar(10)")]
        [Required]
        public string RoomType { get; set; }

        [Column("room_floor", TypeName = "nchar(10)")]
        [Required]
        public string RoomFloor { get; set; }

        [Column("room_number", TypeName = "nchar(10)")]
        [Required]
        public string RoomNumber { get; set; }

        [Column("total_bill")]
        [Required]
        public float TotalBill { get; set; }

        [Column("payment_type", TypeName = "nchar(10)")]
        [Required]
        public string PaymentType { get; set; }

        [Column("card_type", TypeName = "nchar(10)")]
        [Required]
        public string CardType { get; set; }

        [Column("card_number")]
        [MaxLength(50)]
        [Required]
        public string CardNumber { get; set; }

        [Column("card_exp")]
        [MaxLength(50)]
        [Required]
        public string CardExp { get; set; }

        [Column("card_cvc", TypeName = "nchar(10)")]
        [Required]
        public string CardCvc { get; set; }

        [Column("arrival_time", TypeName = "date")]
        [Required]
        public DateTime ArrivalTime { get; set; }

        [Column("leaving_time", TypeName = "date")]
        [Required]
        public DateTime LeavingTime { get; set; }

        [Column("check_in")]
        [Required]
        public bool CheckIn { get; set; }

        [Column("break_fast")]
        [Required]
        public int BreakFast { get; set; }

        [Column("lunch")]
        [Required]
        public int Lunch { get; set; }

        [Column("dinner")]
        [Required]
        public int Dinner { get; set; }

        [Column("cleaning")]
        [Required]
        public bool Cleaning { get; set; }

        [Column("towel")]
        [Required]
        public bool Towel { get; set; }

        [Column("s_surprise")]
        [Required]
        public bool SSurprise { get; set; }

        [Column("supply_status")]
        [Required]
        public bool SupplyStatus { get; set; }

        [Column("food_bill")]
        [Required]
        public int FoodBill { get; set; }
    }
}