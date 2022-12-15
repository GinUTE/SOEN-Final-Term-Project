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
            return _userDAO.GetUserRole(phone).Rows.Cast<object>()
                .Any(row => (row as DataRow)?["role"].ToString() == "admin");
        }

        public User GetUserByPhone(string phone)
        {
            var dt = _userDAO.GetUserByPhone(phone);
            var user = new User(dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                isMale: Convert.ToBoolean(dt.Rows[0][2]),
                dateOfBirth: dt.Rows[0][3].ToString(),
                email: dt.Rows[0][4].ToString(),
                city: dt.Rows[0][5].ToString());
            return user;
        }

        public void CreateUserAccount(User user, string password)
        {
            _userDAO.CreateUserAccount(user, password);
        }
    }
}