using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;
using movie_ticket_booking_system.FormBookTicket;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormMovie
{
    public partial class frmMovie : Form
    {
        private readonly MovieBUS _movieBUS;
        private readonly bool _showComingSoon;

        public frmMovie(bool showComingSoon = false)
        {
            InitializeComponent();

            _movieBUS = new MovieBUS();
            _showComingSoon = showComingSoon;
        }

        private void AddMoviePanel(Movie movie)
        {
            var pnl = new Panel();
            var picThumbnail = new PictureBox();
            var lblTitle = new Label();
            var lblGenre = new Label();
            var lblRuntime = new Label();
            var lblReleaseDate = new Label();
            var btnBook = new Button();

            pnl.Controls.Add(lblReleaseDate);
            pnl.Controls.Add(lblRuntime);
            pnl.Controls.Add(lblGenre);
            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(picThumbnail);
            pnl.Controls.Add(btnBook);

            pnl.Dock = DockStyle.Fill;
            pnl.Location = new Point(0, 0);
            pnl.Margin = new Padding(0);
            pnl.Name = movie.MovieId;
            pnl.Padding = new Padding(30);
            pnl.Size = new Size(375, 610);
            pnl.TabIndex = Convert.ToInt16(movie.MovieId);
            // 
            // picThumbnail
            // 
            picThumbnail.Cursor = Cursors.Hand;
            picThumbnail.Dock = DockStyle.Top;
            picThumbnail.Location = new Point(30, 30);
            picThumbnail.Margin = new Padding(0);
            picThumbnail.Name = movie.MovieId;
            picThumbnail.Size = new Size(315, 400);
            picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            picThumbnail.TabIndex = 0;
            picThumbnail.TabStop = false;
            using (var memoryStream = new MemoryStream(movie.Thumbnail))
            {
                picThumbnail.Image = Image.FromStream(memoryStream);
            }

            picThumbnail.Click += PictureBox_Click;

            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 430);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = movie.Title;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            lblGenre.Dock = DockStyle.Top;
            lblGenre.Location = new Point(30, 470);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(315, 35);
            lblGenre.TabIndex = 2;
            lblGenre.Text = @"Genre: " + movie.Genre;
            lblGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRuntime
            // 
            lblRuntime.Dock = DockStyle.Top;
            lblRuntime.Location = new Point(30, 505);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(315, 35);
            lblRuntime.TabIndex = 3;
            lblRuntime.Text = @"Runtime: " + movie.Runtime + @" minutes";
            lblRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.Dock = DockStyle.Top;
            lblReleaseDate.Location = new Point(30, 540);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(315, 35);
            lblReleaseDate.TabIndex = 4;
            lblReleaseDate.Text = @"Release Date: " + movie.ReleaseDate.Remove(9);
            lblReleaseDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            btnBook.AutoSize = true;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(350, 575);
            btnBook.Name = movie.MovieId;
            btnBook.Size = new Size(85, 35);
            btnBook.TabIndex = 5;
            btnBook.Text = @"BOOK";
            btnBook.Click += Button_Click;

            tlpNowShowing.Controls.Add(pnl);
        }

        private static void PictureBox_Click(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            Messenger.Notification(pic?.Name);
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            using (var frmBookTicket = new frmBookTicket(btn?.Name))
            {
                frmBookTicket.ShowDialog();
            }
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            try
            {
                if (_showComingSoon)
                {
                    var comingSoon = _movieBUS.GetComingSoon();
                    if (comingSoon == null) return;
                    foreach (var movie in comingSoon) AddMoviePanel(movie);
                }
                else
                {
                    var nowShowing = _movieBUS.GetNowShowing();
                    if (nowShowing == null) return;
                    foreach (var movie in nowShowing) AddMoviePanel(movie);
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
    }
}