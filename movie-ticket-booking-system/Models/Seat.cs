using System;

namespace movie_ticket_booking_system.Models
{
    public class Seat
    {
        private readonly string[] _seatCategoryName = { "Ghế thường", "Ghế VIP" };
        public string SeatId { get; set; }
        public string Row { get; set; }
        public string Number { get; set; }
        public string SeatCategoryId { get; set; }
        public string Price { get; set; }
        public bool IsReserved { get; set; }

        public string Location()
        {
            return Row + Number;
        }

        public string SeatCategoryName()
        {
            return _seatCategoryName[Convert.ToInt16(SeatCategoryId) - 1];
        }
    }
}