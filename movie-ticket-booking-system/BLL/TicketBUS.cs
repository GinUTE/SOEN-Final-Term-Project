using System.Data;
using movie_ticket_booking_system.DAL;

namespace movie_ticket_booking_system.BLL
{
    internal class TicketBUS
    {
        private readonly TicketDAO _ticketDAO;

        public TicketBUS()
        {
            _ticketDAO = new TicketDAO();
        }

        public DataTable GetUserTicket(string phone)
        {
            return _ticketDAO.GetUserTicket(phone);
        }
    }
}