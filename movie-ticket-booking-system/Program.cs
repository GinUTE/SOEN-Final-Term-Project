using System;
using System.Windows.Forms;
using movie_ticket_booking_system.FormDashboard;
using movie_ticket_booking_system.FormUser;

namespace movie_ticket_booking_system
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var frmUser = new frmUser())
            {
                Application.Run(new frmDashboard(frmUser.ShowDialog() == DialogResult.Yes));
            }
        }
    }
}