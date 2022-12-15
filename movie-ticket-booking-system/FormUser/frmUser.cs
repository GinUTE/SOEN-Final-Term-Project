using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.FormLogIn;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormUser
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();

            LoadChildForm(new frmLogIn(this));
        }

        internal User LoggedInUser { get; set; }

        public void LoadChildForm(Form childForm)
        {
            Height = childForm.Height;
            picLogo.Location = new Point(0, (Height - picLogo.Height) / 2);
            CenterToScreen();

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;

            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.Show();
        }
    }
}