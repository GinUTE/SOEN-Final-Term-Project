using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormBookTicket
{
    public partial class frmBookTicket : Form
    {
        private readonly User _loggedInUser;
        private readonly ScreeningBUS _screeningBUS;
        private readonly SeatBUS _seatBUS;
        private readonly List<string> _selectedSeat;
        private readonly NameValueCollection _showtime;
        private string _currentDate;
        private string _currentScreeningId;
        private string _currentTime;

        public frmBookTicket(User loggedInUser, string movieId)
        {
            InitializeComponent();

            _screeningBUS = new ScreeningBUS(movieId);
            _seatBUS = new SeatBUS();
            _selectedSeat = new List<string>();
            _loggedInUser = loggedInUser;
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
            _selectedSeat.Clear();
            btnBook.Visible = false;
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
            _selectedSeat.Clear();
            btnBook.Visible = false;
            AddSeatPanel();

            tlpSeat.Visible = pnlScreeningInfo.Visible = true;
        }

        private void AddSeatPanel()
        {
            try
            {
                _currentScreeningId = _screeningBUS.GetScreeningIdByShowtime(_currentDate, _currentTime);
                AddSeatByScreeningId();
                lblMessage.Text = @"Please select your preferred seats";
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

        private void AddSeatByScreeningId()
        {
            try
            {
                tlpSeat.Controls.Clear();
                var seats = _seatBUS.GetSeatByScreeningId(_currentScreeningId);
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
                        Enabled = !seat.IsReserved,
                        ForeColor = seat.SeatCategoryId.Equals("2") ? Color.Red : Color.Green
                    };

                    lbl.Click += LabelSeat_Click;
                    tlpSeat.Controls.Add(lbl);
                }
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

        private void LabelSeat_Click(object sender, EventArgs e)
        {
            if (!(sender is Label lbl)) return;

            if (lbl.BackColor != DefaultBackColor)
            {
                _selectedSeat.Remove(lbl.Name);
                lbl.BackColor = DefaultBackColor;
                if (_selectedSeat.Count == 0)
                    btnBook.Visible = false;
            }
            else
            {
                lbl.BackColor = Color.FromArgb(30, 46, 61);
                _selectedSeat.Add(lbl.Name);
                btnBook.Visible = true;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                _seatBUS.AddReservation(_loggedInUser.Phone, _currentScreeningId, _selectedSeat);
                var totalPrice = _seatBUS.CalculateTotalTicketPrice(_loggedInUser.Phone, _currentScreeningId);
                Messenger.Notification("Seats reserved!\nTotal cost: " + totalPrice);
                AddSeatByScreeningId();
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
    }
}