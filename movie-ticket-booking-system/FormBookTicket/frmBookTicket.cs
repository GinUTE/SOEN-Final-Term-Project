using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;

namespace movie_ticket_booking_system.FormBookTicket
{
    public partial class frmBookTicket : Form
    {
        private readonly ScreeningBUS _screeningBUS;
        private readonly SeatBUS _seatBUS;
        private readonly NameValueCollection _showtime;
        private string _currentDate;
        private string _currentTime;

        public frmBookTicket(string movieId)
        {
            InitializeComponent();

            _screeningBUS = new ScreeningBUS(movieId);
            _seatBUS = new SeatBUS();
            try
            {
                _showtime = _screeningBUS.GetShowtimeByMovieId();
                if (_showtime.Count == 0)
                    lblMessage.Text = @"No available screenings";
                else AddDatePanel(_showtime.AllKeys);
            }
            catch (SqlException ex)
            {
                Messenger.Error("Unexpected SQL related error: " + ex.Number);
            }
            catch (Exception ex)
            {
                Messenger.Error("Unexpected runtime error: " + ex);
            }
        }

        private void AddDatePanel(IEnumerable<string> dateList)
        {
            foreach (var date in dateList)
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Dock = DockStyle.Left,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = date
                };
                lbl.Click += LabelDate_Click;
                tlpDate.Controls.Add(lbl);
            }
        }

        private void AddTimePanel(string timeList)
        {
            foreach (var time in timeList.Split(','))
            {
                var lbl = new Label
                {
                    AutoSize = true,
                    Dock = DockStyle.Left,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = time
                };
                lbl.Click += LabelTime_Click;
                tlpTime.Controls.Add(lbl);
            }
        }

        private void LabelDate_Click(object sender, EventArgs e)
        {
            if (!(sender is Label lbl)) return;

            _currentDate = lbl.Text;

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(30, 46, 61);
            foreach (Label control in tlpDate.Controls)
            {
                if (control == lbl) continue;
                control.ForeColor = DefaultForeColor;
                control.BackColor = DefaultBackColor;
            }

            tlpTime.Controls.Clear();
            AddTimePanel(_showtime[_currentDate]);

            tlpSeat.Controls.Clear();
            tlpSeat.Visible = pnlScreeningInfo.Visible = false;
        }

        private void LabelTime_Click(object sender, EventArgs e)
        {
            if (!(sender is Label lbl)) return;

            _currentTime = lbl.Text;

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(30, 46, 61);
            foreach (Label control in tlpTime.Controls)
            {
                if (control == lbl) continue;
                control.ForeColor = DefaultForeColor;
                control.BackColor = DefaultBackColor;
            }

            tlpSeat.Controls.Clear();
            tlpSeat.Visible = pnlScreeningInfo.Visible = true;

            AddSeatPanel();
        }

        private void AddSeatPanel()
        {
            var result = _screeningBUS.GetScreeningAndAuditoriumByShowtime(_currentDate, _currentTime);
            if (result.Count != 2) return;

            var screeningId = result[0];
            var auditoriumId = result[1];
            var seats = _seatBUS.GetSeatByScreeningAndAuditorium(screeningId, auditoriumId);

            lblMessage.Text = @"Please select your preferred seats";

            foreach (var seat in seats)
            {
                var lbl = new Label
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = seat.Location(),
                    Margin = new Padding(3),
                    Name = seat.SeatId,
                    Enabled = !seat.IsReserved
                };
                lbl.Click += LabelSeat_Click;
                tlpSeat.Controls.Add(lbl);
            }
        }

        private void LabelSeat_Click(object sender, EventArgs e)
        {
        }
    }
}