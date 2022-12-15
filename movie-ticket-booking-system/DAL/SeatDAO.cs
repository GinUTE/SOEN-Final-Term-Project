using System;
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

        public DataTable GetSeatByScreeningId(string screeningId)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@screening_id", SqlDbType.Int)
            {
                Value = Convert.ToInt16(screeningId)
            };
            return _dbConnection.ExecuteLoadQuery("usp_GetSeatByScreeningId", paras, CommandType.StoredProcedure);
        }

        public void AddReservation(string phone, string screeningId)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@customer_phone", SqlDbType.VarChar)
            {
                Value = phone
            };
            paras[1] = new SqlParameter("@screening_id", SqlDbType.Int)
            {
                Value = Convert.ToInt16(screeningId)
            };
            _dbConnection.ExecuteNonQuery("usp_AddReservation", paras, CommandType.StoredProcedure);
        }

        public void AddReservedSeat(string seatId)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@seat_id", SqlDbType.Int)
            {
                Value = Convert.ToInt16(seatId)
            };
            _dbConnection.ExecuteNonQuery("usp_AddReservedSeat", paras, CommandType.StoredProcedure);
        }
    }
}