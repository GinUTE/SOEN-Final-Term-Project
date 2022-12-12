using System;
using System.Windows.Forms;
using movie_ticket_booking_system.FormMovie;
using movie_ticket_booking_system.FormUser;

namespace movie_ticket_booking_system.FormDashboard
{
    public partial class frmDashboard : Form
    {
        private Form _activeForm;

        public frmDashboard()
        {
            InitializeComponent();

            btnAdmin.Visible = false;
            btnNowShowing_Click(new object(), EventArgs.Empty);
        }

        public void LoadChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;

            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            pnlMoviesSubmenu.Visible = !pnlMoviesSubmenu.Visible;
        }

        private void btnNowShowing_Click(object sender, EventArgs e)
        {
            if (lblHeader.Text == btnNowShowing.Text.ToUpper()) return;
            lblHeader.Text = btnNowShowing.Text.ToUpper();
            LoadChildForm(new frmMovie());
        }

        private void btnComingSoon_Click(object sender, EventArgs e)
        {
            if (lblHeader.Text == btnComingSoon.Text.ToUpper()) return;
            lblHeader.Text = btnComingSoon.Text.ToUpper();
            LoadChildForm(new frmMovie(true));
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var frmUser = new frmUser())
            {
                var dialogResult = frmUser.ShowDialog();
                btnAdmin.Visible = dialogResult == DialogResult.Yes;
            }
        }
    }
}