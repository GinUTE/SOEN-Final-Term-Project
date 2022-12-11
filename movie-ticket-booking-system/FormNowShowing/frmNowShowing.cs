using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormNowShowing
{
    public partial class frmNowShowing : Form
    {
        private readonly MovieBUS _movieBUS;

        public frmNowShowing()
        {
            InitializeComponent();

            _movieBUS = new MovieBUS();
        }

        private void AddMoviePanel(Movie movie)
        {
            var pnl = new Panel();
            var picThumbnail = new PictureBox();
            var lblTitle = new Label();
            var lblGenre = new Label();
            var lblRuntime = new Label();
            var lblReleaseDate = new Label();

            pnl.Controls.Add(lblReleaseDate);
            pnl.Controls.Add(lblRuntime);
            pnl.Controls.Add(lblGenre);
            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(picThumbnail);
            pnl.Dock = DockStyle.Fill;
            pnl.Location = new Point(0, 0);
            pnl.Margin = new Padding(0);
            pnl.Name = "pnlMovieInfo" + movie.MovieId;
            pnl.Padding = new Padding(30);
            pnl.Size = new Size(375, 600);
            pnl.TabIndex = Convert.ToInt16(movie.MovieId);
            // 
            // picThumbnail
            // 
            picThumbnail.Cursor = Cursors.Hand;
            picThumbnail.Dock = DockStyle.Top;
            picThumbnail.Location = new Point(30, 30);
            picThumbnail.Margin = new Padding(0);
            picThumbnail.Name = "picThumbnail";
            picThumbnail.Size = new Size(315, 400);
            picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            picThumbnail.TabIndex = 0;
            picThumbnail.TabStop = false;
            using (var memoryStream = new MemoryStream(movie.Thumbnail))
            {
                picThumbnail.Image = Image.FromStream(memoryStream);
            }

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

            tlpNowShowing.Controls.Add(pnl);
        }

        private void frmNowShowing_Load(object sender, EventArgs e)
        {
            var nowShowing = _movieBUS.GetNowShowing();
            if (nowShowing == null) return;
            foreach (var movie in nowShowing) AddMoviePanel(movie);
        }
    }
}