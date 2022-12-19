using System.ComponentModel;
using System.Windows.Forms;

namespace movie_ticket_booking_system.FormDashboard
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlUserSubmenu = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMyTicket = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlAdminSubmenu = new System.Windows.Forms.Panel();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnlMoviesSubmenu = new System.Windows.Forms.Panel();
            this.btnComingSoon = new System.Windows.Forms.Button();
            this.btnNowShowing = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserSubmenu.SuspendLayout();
            this.pnlAdminSubmenu.SuspendLayout();
            this.pnlMoviesSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.pnlSidebar.Controls.Add(this.pnlUserSubmenu);
            this.pnlSidebar.Controls.Add(this.btnUser);
            this.pnlSidebar.Controls.Add(this.pnlAdminSubmenu);
            this.pnlSidebar.Controls.Add(this.btnAdmin);
            this.pnlSidebar.Controls.Add(this.btnLogIn);
            this.pnlSidebar.Controls.Add(this.pnlMoviesSubmenu);
            this.pnlSidebar.Controls.Add(this.btnMovies);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 900);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlUserSubmenu
            // 
            this.pnlUserSubmenu.Controls.Add(this.btnProfile);
            this.pnlUserSubmenu.Controls.Add(this.btnMyTicket);
            this.pnlUserSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSubmenu.Location = new System.Drawing.Point(0, 550);
            this.pnlUserSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUserSubmenu.Name = "pnlUserSubmenu";
            this.pnlUserSubmenu.Size = new System.Drawing.Size(200, 100);
            this.pnlUserSubmenu.TabIndex = 5;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 50);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnMyTicket
            // 
            this.btnMyTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyTicket.FlatAppearance.BorderSize = 0;
            this.btnMyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTicket.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTicket.ForeColor = System.Drawing.Color.White;
            this.btnMyTicket.Location = new System.Drawing.Point(0, 0);
            this.btnMyTicket.Margin = new System.Windows.Forms.Padding(0);
            this.btnMyTicket.Name = "btnMyTicket";
            this.btnMyTicket.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMyTicket.Size = new System.Drawing.Size(200, 50);
            this.btnMyTicket.TabIndex = 0;
            this.btnMyTicket.Text = "My Tickets";
            this.btnMyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTicket.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 500);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(200, 50);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlAdminSubmenu
            // 
            this.pnlAdminSubmenu.Controls.Add(this.btnScreening);
            this.pnlAdminSubmenu.Controls.Add(this.btnMovie);
            this.pnlAdminSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminSubmenu.Location = new System.Drawing.Point(0, 400);
            this.pnlAdminSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdminSubmenu.Name = "pnlAdminSubmenu";
            this.pnlAdminSubmenu.Size = new System.Drawing.Size(200, 100);
            this.pnlAdminSubmenu.TabIndex = 5;
            // 
            // btnScreening
            // 
            this.btnScreening.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScreening.FlatAppearance.BorderSize = 0;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreening.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreening.ForeColor = System.Drawing.Color.White;
            this.btnScreening.Location = new System.Drawing.Point(0, 50);
            this.btnScreening.Margin = new System.Windows.Forms.Padding(0);
            this.btnScreening.Name = "btnScreening";
            this.btnScreening.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnScreening.Size = new System.Drawing.Size(200, 50);
            this.btnScreening.TabIndex = 1;
            this.btnScreening.Text = "Screenings";
            this.btnScreening.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreening.UseVisualStyleBackColor = true;
            // 
            // btnMovie
            // 
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.Location = new System.Drawing.Point(0, 0);
            this.btnMovie.Margin = new System.Windows.Forms.Padding(0);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMovie.Size = new System.Drawing.Size(200, 50);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.Text = "Movies";
            this.btnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 350);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(200, 50);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(0, 850);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogIn.Size = new System.Drawing.Size(200, 50);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnlMoviesSubmenu
            // 
            this.pnlMoviesSubmenu.Controls.Add(this.btnComingSoon);
            this.pnlMoviesSubmenu.Controls.Add(this.btnNowShowing);
            this.pnlMoviesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoviesSubmenu.Location = new System.Drawing.Point(0, 250);
            this.pnlMoviesSubmenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMoviesSubmenu.Name = "pnlMoviesSubmenu";
            this.pnlMoviesSubmenu.Size = new System.Drawing.Size(200, 100);
            this.pnlMoviesSubmenu.TabIndex = 2;
            // 
            // btnComingSoon
            // 
            this.btnComingSoon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComingSoon.FlatAppearance.BorderSize = 0;
            this.btnComingSoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComingSoon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComingSoon.ForeColor = System.Drawing.Color.White;
            this.btnComingSoon.Location = new System.Drawing.Point(0, 50);
            this.btnComingSoon.Margin = new System.Windows.Forms.Padding(0);
            this.btnComingSoon.Name = "btnComingSoon";
            this.btnComingSoon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnComingSoon.Size = new System.Drawing.Size(200, 50);
            this.btnComingSoon.TabIndex = 1;
            this.btnComingSoon.Text = "Coming Soon";
            this.btnComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComingSoon.UseVisualStyleBackColor = true;
            this.btnComingSoon.Click += new System.EventHandler(this.btnComingSoon_Click);
            // 
            // btnNowShowing
            // 
            this.btnNowShowing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNowShowing.FlatAppearance.BorderSize = 0;
            this.btnNowShowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowShowing.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowShowing.ForeColor = System.Drawing.Color.White;
            this.btnNowShowing.Location = new System.Drawing.Point(0, 0);
            this.btnNowShowing.Margin = new System.Windows.Forms.Padding(0);
            this.btnNowShowing.Name = "btnNowShowing";
            this.btnNowShowing.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNowShowing.Size = new System.Drawing.Size(200, 50);
            this.btnNowShowing.TabIndex = 0;
            this.btnNowShowing.Text = "Now Showing";
            this.btnNowShowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowShowing.UseVisualStyleBackColor = true;
            this.btnNowShowing.Click += new System.EventHandler(this.btnNowShowing_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.White;
            this.btnMovies.Location = new System.Drawing.Point(0, 200);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(0);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMovies.Size = new System.Drawing.Size(200, 50);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Text = "Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 200);
            this.pnlLogo.TabIndex = 4;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 80);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1500, 820);
            this.pnlChildForm.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(200, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1500, 80);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "HEADER";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlUserSubmenu.ResumeLayout(false);
            this.pnlAdminSubmenu.ResumeLayout(false);
            this.pnlMoviesSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlChildForm;
        private Button btnMovies;
        private Label lblHeader;
        private Panel pnlMoviesSubmenu;
        private Button btnComingSoon;
        private Button btnNowShowing;
        private Button btnLogIn;
        private Button btnAdmin;
        private Panel pnlLogo;
        private Panel pnlAdminSubmenu;
        private Button btnScreening;
        private Button btnMovie;
        private Panel pnlUserSubmenu;
        private Button btnProfile;
        private Button btnMyTicket;
        private Button btnUser;
    }
}