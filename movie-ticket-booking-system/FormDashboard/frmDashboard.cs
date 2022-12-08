using System.Windows.Forms;

namespace movie_ticket_booking_system.FormDashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard(bool isAdmin = false)
        {
            InitializeComponent();

            if (isAdmin)
                Messenger.Notification("User is admin!");
        }
    }
}