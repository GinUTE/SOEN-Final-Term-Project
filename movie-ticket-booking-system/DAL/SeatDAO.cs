using System.Data;
using System.Data.SqlClient;
using movie_ticket_booking_system.DL;

namespace movie_ticket_booking_system.DAL
{
    internal class SeatDAO
    {
        private readonly DbConnection _dbConnection;

        public SeatDAO()
        {
            _dbConnection = new DbConnection();
        }

        public DataTable GetSeatByScreeningAndAuditorium(string screeningId, string auditoriumId)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@screening_id", SqlDbType.Int)
            {
                Value = screeningId
            };
            paras[1] = new SqlParameter("@auditorium_id", SqlDbType.Int)
            {
                Value = auditoriumId
            };

            return _dbConnection.ExecuteLoadQuery("usp_GetSeatByScreeningAndAuditorium", paras,
                CommandType.StoredProcedure);
        }
    }
}