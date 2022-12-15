using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using movie_ticket_booking_system.DAL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.BLL
{
    internal class MovieBUS
    {
        private readonly MovieDAO _movieDAO;

        public MovieBUS()
        {
            _movieDAO = new MovieDAO();
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
                if (property.Name == "Thumbnail")
                    property.SetValue(model, (byte[])row[ConvertToUnderscoreCase(property.Name)], null);
                else property.SetValue(model, row[ConvertToUnderscoreCase(property.Name)].ToString(), null);
            return model;
        }

        private static IList<T> ToList<T>(DataTable dt) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            return (from DataRow row in dt.Rows select MapRowToModel<T>(row, properties)).ToList();
        }

        public IList<Movie> GetNowShowing()
        {
            return ToList<Movie>(_movieDAO.GetNowShowing());
        }

        public IList<Movie> GetComingSoon()
        {
            return ToList<Movie>(_movieDAO.GetComingSoon());
        }
    }
}