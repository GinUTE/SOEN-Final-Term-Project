using System.Data;
using System.Data.SqlClient;
using movie_ticket_booking_system.DL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.DAL
{
    internal class UserDAO
    {
        private readonly DbConnection _dbConnection;

        public UserDAO()
        {
            _dbConnection = new DbConnection();
        }

        public object CountUserPhone(string phone)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            return _dbConnection.ExecuteScalar("usp_CountUserPhone", paras, CommandType.StoredProcedure);
        }

        public object CountUserAccount(Account account)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = account.Phone
            };
            paras[1] = new SqlParameter("@password", SqlDbType.VarChar)
            {
                Value = account.Password
            };
            return _dbConnection.ExecuteScalar("usp_CountUserAccount", paras, CommandType.StoredProcedure);
        }

        public void UpdateAccountLastSeen(string phone)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            _dbConnection.ExecuteNonQuery("usp_UpdateAccountLastSeen", paras, CommandType.StoredProcedure);
        }

        public DataTable GetUserRole(string phone)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            return _dbConnection.ExecuteLoadQuery("usp_GetUserRole", paras, CommandType.StoredProcedure);
        }

        public DataTable GetUserByPhone(string phone)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            return _dbConnection.ExecuteLoadQuery("usp_GetUserByPhone", paras, CommandType.StoredProcedure);
        }

        public void CreateUserAccount(User user, string password)
        {
            var paras = new SqlParameter[7];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = user.Phone
            };
            paras[1] = new SqlParameter("@fullname", SqlDbType.NVarChar)
            {
                Value = user.FullName
            };
            paras[2] = new SqlParameter("@is_male", SqlDbType.Bit)
            {
                Value = user.IsMale
            };
            paras[3] = new SqlParameter("@birth", SqlDbType.Date)
            {
                Value = user.DateOfBirth
            };
            paras[4] = new SqlParameter("@email", SqlDbType.VarChar)
            {
                Value = user.Email
            };
            paras[5] = new SqlParameter("@city", SqlDbType.NVarChar)
            {
                Value = user.City
            };
            paras[6] = new SqlParameter("@password", SqlDbType.VarChar)
            {
                Value = password
            };

            _dbConnection.ExecuteNonQuery("usp_CreateUserAccount", paras, CommandType.StoredProcedure);
        }
    }
}