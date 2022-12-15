using System.Data;
using System.Data.SqlClient;
using movie_ticket_booking_system.DL;

namespace movie_ticket_booking_system.DAL
{
    internal class TicketDAO
    {
        private readonly DbConnection _dbConnection;

        public TicketDAO()
        {
            _dbConnection = new DbConnection();
        }

        public DataTable GetUserTicket(string phone)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            return _dbConnection.ExecuteLoadQuery("usp_GetUserTicket", paras, CommandType.StoredProcedure);
        }
    }
}