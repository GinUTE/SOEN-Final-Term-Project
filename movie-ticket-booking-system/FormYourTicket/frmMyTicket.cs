using System.Windows.Forms;
using movie_ticket_booking_system.BLL;

namespace movie_ticket_booking_system.FormYourTicket
{
    public partial class frmMyTicket : Form
    {
        private readonly TicketBUS _ticketBUS;

        public frmMyTicket(string phone)
        {
            InitializeComponent();

            _ticketBUS = new TicketBUS();
            dgvYourTicket.DataSource = _ticketBUS.GetUserTicket(phone);
        }
    }
}