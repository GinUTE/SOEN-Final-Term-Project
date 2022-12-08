using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.FormLogIn;

namespace movie_ticket_booking_system.FormUser
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();

            LoadChildForm(new frmLogIn(this));
        }

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