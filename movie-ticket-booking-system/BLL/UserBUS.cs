using System;
using System.Data;
using System.Linq;
using movie_ticket_booking_system.DAL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.BLL
{
    internal class UserBUS
    {
        private readonly UserDAO _userDAO;

        public UserBUS()
        {
            _userDAO = new UserDAO();
        }

        public bool PhoneDoesExist(string phone)
        {
            return Convert.ToInt16(_userDAO.CountUserPhone(phone)) > 0;
        }

        public bool AccountDoesExist(Account account)
        {
            return Convert.ToInt16(_userDAO.CountUserAccount(account)) == 1;
        }

        public void UpdateAccountLastSeen(string phone)
        {
            _userDAO.UpdateAccountLastSeen(phone);
        }

        public bool IsAdmin(string phone)
        {
            return _userDAO.GetUserRole(phone).Rows.Cast<DataRow>().Any(row => row["role"].ToString() == "admin");
        }

        public void CreateUserAccount(User user, string password)
        {
            _userDAO.CreateUserAccount(user, password);
        }
    }
}