namespace movie_ticket_booking_system.FormBookTicket
{
    partial class frmBookTicket
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
            this.tlpTime = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.pnlShowtime = new System.Windows.Forms.Panel();
            this.pnlShowtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTime
            // 
            this.tlpTime.AutoScroll = true;
            this.tlpTime.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTime.ColumnCount = 1;
            this.tlpTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpTime.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlpTime.Location = new System.Drawing.Point(0, 75);
            this.tlpTime.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTime.Name = "tlpTime";
            this.tlpTime.RowCount = 1;
            this.tlpTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTime.Size = new System.Drawing.Size(1000, 75);
            this.tlpTime.TabIndex = 1;
            // 
            // tlpDate
            // 
            this.tlpDate.AutoScroll = true;
            this.tlpDate.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDate.ColumnCount = 1;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDate.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlpDate.Location = new System.Drawing.Point(0, 0);
            this.tlpDate.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 1;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Size = new System.Drawing.Size(1000, 75);
            this.tlpDate.TabIndex = 0;
            // 
            // pnlShowtime
            // 
            this.pnlShowtime.Controls.Add(this.tlpDate);
            this.pnlShowtime.Controls.Add(this.tlpTime);
            this.pnlShowtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShowtime.Location = new System.Drawing.Point(0, 0);
            this.pnlShowtime.Margin = new System.Windows.Forms.Padding(0);
            this.pnlShowtime.Name = "pnlShowtime";
            this.pnlShowtime.Size = new System.Drawing.Size(1000, 150);
            this.pnlShowtime.TabIndex = 0;
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlShowtime);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlShowtime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTime;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.Panel pnlShowtime;
    }
}