using System.Data;
using System.Data.SqlClient;
using movie_ticket_booking_system.DL;

namespace movie_ticket_booking_system.DAL
{
    internal class ScreeningDAO
    {
        private readonly DbConnection _dbConnection;

        public ScreeningDAO()
        {
            _dbConnection = new DbConnection();
        }

        public DataTable GetScreeningByMovieId(string movieId)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@movie_id", SqlDbType.Int)
            {
                Value = movieId
            };

            return _dbConnection.ExecuteLoadQuery("usp_GetScreeningByMovieId", paras, CommandType.StoredProcedure);
        }
    }
}