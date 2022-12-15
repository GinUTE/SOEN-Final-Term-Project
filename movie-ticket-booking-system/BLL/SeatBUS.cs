using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using movie_ticket_booking_system.DAL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.BLL
{
    internal class SeatBUS
    {
        private readonly SeatDAO _seatDAO;

        public SeatBUS()
        {
            _seatDAO = new SeatDAO();
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
                if (property.Name == "IsReserved")
                    property.SetValue(model, Convert.ToBoolean(row[ConvertToUnderscoreCase(property.Name)]), null);
                else property.SetValue(model, row[ConvertToUnderscoreCase(property.Name)].ToString(), null);
            return model;
        }

        private static IList<T> ToList<T>(DataTable dt) where T : new()
        {
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();
            return (from DataRow row in dt.Rows select MapRowToModel<T>(row, properties)).ToList();
        }

        public IList<Seat> GetSeatByScreeningId(string screeningId)
        {
            return ToList<Seat>(_seatDAO.GetSeatByScreeningId(screeningId));
        }

        public void AddReservation(string phone, string screeningId, List<string> selectedSeat)
        {
            _seatDAO.AddReservation(phone, screeningId);
            foreach (var seat in selectedSeat) _seatDAO.AddReservedSeat(seat);
        }
    }
}