namespace movie_ticket_booking_system.FormDashboard
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnScreening = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.pnlSidebar.Controls.Add(this.btnScreening);
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 900);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1500, 900);
            this.pnlChildForm.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnScreening
            // 
            this.btnScreening.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreening.FlatAppearance.BorderSize = 0;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreening.ForeColor = System.Drawing.Color.White;
            this.btnScreening.Location = new System.Drawing.Point(0, 200);
            this.btnScreening.Name = "btnScreening";
            this.btnScreening.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnScreening.Size = new System.Drawing.Size(200, 50);
            this.btnScreening.TabIndex = 1;
            this.btnScreening.Text = "Screening";
            this.btnScreening.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreening.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.PictureBox picLogo;
    }
}