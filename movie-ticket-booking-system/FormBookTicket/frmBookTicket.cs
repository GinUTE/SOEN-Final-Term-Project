using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;

namespace movie_ticket_booking_system.FormBookTicket
{
    public partial class frmBookTicket : Form
    {
        private readonly ScreeningBUS _screeningBUS;
        private readonly List<KeyValuePair<string, string>> _showtime;

        public frmBookTicket(string movieId)
        {
            InitializeComponent();

            _screeningBUS = new ScreeningBUS();
            _showtime = _screeningBUS.GetShowtimeByMovieId(movieId);
            AddDatePanel();
            AddTimePanel(_showtime[0].Value);
        }

        private void AddDatePanel()
        {
            var index = 0;
            foreach (var lbl in _showtime.Select(date => new Label
                     {
                         Dock = DockStyle.Left,
                         Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0),
                         Name = index.ToString(),
                         TextAlign = ContentAlignment.MiddleCenter,
                         Text = date.Key
                     }))
            {
                lbl.Click += Label_Click;
                tlpDate.Controls.Add(lbl);
                ++index;
            }
        }

        private void AddTimePanel(string timeList)
        {
            var index = 0;
            foreach (var time in timeList.Split(','))
            {
                var lbl = new Label
                {
                    Dock = DockStyle.Left,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Name = index.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = time
                };
                lbl.Click += Label_Click;
                tlpTime.Controls.Add(lbl);
                ++index;
            }
        }

        private static void Label_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            Messenger.Notification(lbl?.Name);
        }
    }
}