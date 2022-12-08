using System.Windows.Forms;

namespace movie_ticket_booking_system
{
    internal class Messenger
    {
        internal static void Notification(string message)
        {
            MessageBox.Show(message, @"Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Error(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static DialogResult Confirm(string message)
        {
            return MessageBox.Show(message, @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}