using System.Windows.Forms;
using movie_ticket_booking_system.FormNowShowing;

namespace movie_ticket_booking_system.FormDashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            LoadChildForm(new frmNowShowing());
        }

        public void LoadChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;

            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.Show();
        }
    }
}