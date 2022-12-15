using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;
using movie_ticket_booking_system.DAL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.BLL
{
    internal class ScreeningBUS
    {
        private readonly ScreeningDAO _screeningDAO;
        private readonly IList<Screening> _screenings;

        public ScreeningBUS(string movieId)
        {
            _screeningDAO = new ScreeningDAO();
            _screenings = ToList<Screening>(_screeningDAO.GetScreeningByMovieId(movieId));
        }

        private static string ConvertToUnderscoreCase(string value)
        {
            return string.Concat(value.Select((x, i) => i > 0 && char.IsUpper(x) ? '_' + x.ToString() : x.ToString()))
                .ToLower();
        }

        private static T MapRowToModel<T>(DataRow row, IEnumerable<PropertyInfo> properties) where T : new()
        {
            var model = new T();
            foreach (var property in properties)
                property.SetValue(model, row[ConvertToUnderscoreCase(property.Name)].ToString(), null);
            return model;
        }

        private static IList<T> ToList<T>(DataTable dt) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            return (from DataRow row in dt.Rows select MapRowToModel<T>(row, properties)).ToList();
        }

        public NameValueCollection GetShowtimeByMovieId()
        {
            var showtime = new NameValueCollection();
            foreach (var screening in _screenings)
                showtime.Add(screening.Date.Substring(0, 9), screening.Time);
            return showtime;
        }

        public string GetScreeningIdByShowtime(string date, string time)
        {
            foreach (var screening in _screenings)
                if (screening.Date.Substring(0, 9) == date && screening.Time == time)
                    return screening.ScreeningId;
            return string.Empty;
        }
    }
}