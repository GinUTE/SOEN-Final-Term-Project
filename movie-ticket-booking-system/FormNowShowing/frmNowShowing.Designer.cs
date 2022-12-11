namespace movie_ticket_booking_system.FormNowShowing
{
    partial class frmNowShowing
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
            this.tlpNowShowing = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpNowShowing
            // 
            this.tlpNowShowing.HorizontalScroll.Maximum = 0;
            this.tlpNowShowing.AutoScroll = false;
            this.tlpNowShowing.VerticalScroll.Visible = false;
            this.tlpNowShowing.AutoScroll = true;
            this.tlpNowShowing.AutoSize = true;
            this.tlpNowShowing.ColumnCount = 3;
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNowShowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNowShowing.Location = new System.Drawing.Point(0, 0);
            this.tlpNowShowing.Name = "tlpNowShowing";
            this.tlpNowShowing.RowCount = 1;
            this.tlpNowShowing.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNowShowing.Size = new System.Drawing.Size(1500, 900);
            this.tlpNowShowing.TabIndex = 0;
            // 
            // frmNowShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.tlpNowShowing);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNowShowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Showing";
            this.Load += new System.EventHandler(this.frmNowShowing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNowShowing;
    }
}