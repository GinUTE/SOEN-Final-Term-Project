using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using movie_ticket_booking_system.DAL;

namespace movie_ticket_booking_system.BLL
{
    internal class ScreeningBUS
    {
        private readonly ScreeningDAO _screeningDAO;

        public ScreeningBUS()
        {
            _screeningDAO = new ScreeningDAO();
        }

        public List<KeyValuePair<string, string>> GetShowtimeByMovieId(string movieId)
        {
            var dt = _screeningDAO.GetShowtimeByMovieId(movieId);
            return (from DataRow row in dt.Rows
                select new KeyValuePair<string, string>((row["date"] as DateTime? ?? default).ToString("D"),
                    row["time"].ToString())).ToList();
        }
    }
}