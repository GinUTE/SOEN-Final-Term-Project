using System.ComponentModel;
using System.Windows.Forms;

namespace movie_ticket_booking_system.FormMovie
{
    partial class frmMovie
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
            this.tlpNowShowing = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpNowShowing
            // 
            this.tlpNowShowing.AutoScroll = true;
            this.tlpNowShowing.ColumnCount = 3;
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNowShowing.Location = new System.Drawing.Point(0, 0);
            this.tlpNowShowing.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNowShowing.Name = "tlpNowShowing";
            this.tlpNowShowing.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.tlpNowShowing.RowCount = 1;
            this.tlpNowShowing.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNowShowing.Size = new System.Drawing.Size(1500, 900);
            this.tlpNowShowing.TabIndex = 0;
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.tlpNowShowing);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Showing";
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpNowShowing;
    }
}