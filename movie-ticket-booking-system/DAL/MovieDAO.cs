using System.Data;
using movie_ticket_booking_system.DL;

namespace movie_ticket_booking_system.DAL
{
    internal class MovieDAO
    {
        private readonly DbConnection _dbConnection;

        public MovieDAO()
        {
            _dbConnection = new DbConnection();
        }

        public DataTable GetNowShowing()
        {
            return _dbConnection.ExecuteLoadQuery("usp_GetNowShowing", cmdType: CommandType.StoredProcedure);
        }

        public DataTable GetComingSoon()
        {
            return _dbConnection.ExecuteLoadQuery("usp_GetComingSoon", cmdType: CommandType.StoredProcedure);
        }
    }
}