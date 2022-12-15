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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnlMoviesSubmenu = new System.Windows.Forms.Panel();
            this.btnComingSoon = new System.Windows.Forms.Button();
            this.btnNowShowing = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlMoviesSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
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
            this.btnComingSoon.Size = new System.Drawing.Size(200, 50);
            this.btnComingSoon.TabIndex = 1;
            this.btnComingSoon.Text = "Coming Soon";
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
            this.btnNowShowing.Size = new System.Drawing.Size(200, 50);
            this.btnNowShowing.TabIndex = 0;
            this.btnNowShowing.Text = "Now Showing";
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
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 200);
            this.pnlLogo.TabIndex = 4;
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
    }
}