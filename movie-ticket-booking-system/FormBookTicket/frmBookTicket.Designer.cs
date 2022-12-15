using System.ComponentModel;
using System.Windows.Forms;

namespace movie_ticket_booking_system.FormBookTicket
{
    partial class frmBookTicket
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
            this.tlpTime = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.pnlShowtime = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tlpSeat = new System.Windows.Forms.TableLayoutPanel();
            this.pnlScreeningInfo = new System.Windows.Forms.Panel();
            this.pnlShowtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTime
            // 
            this.tlpTime.AutoScroll = true;
            this.tlpTime.ColumnCount = 1;
            this.tlpTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpTime.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tlpTime.Location = new System.Drawing.Point(0, 50);
            this.tlpTime.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTime.Name = "tlpTime";
            this.tlpTime.RowCount = 1;
            this.tlpTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTime.Size = new System.Drawing.Size(882, 50);
            this.tlpTime.TabIndex = 1;
            // 
            // tlpDate
            // 
            this.tlpDate.AutoScroll = true;
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
            this.tlpDate.Size = new System.Drawing.Size(882, 50);
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
            this.pnlShowtime.Size = new System.Drawing.Size(882, 100);
            this.pnlShowtime.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(0, 100);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(882, 35);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please select your preferred showtime for the movie!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSeat
            // 
            this.tlpSeat.AutoScroll = true;
            this.tlpSeat.ColumnCount = 10;
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeat.Location = new System.Drawing.Point(0, 135);
            this.tlpSeat.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSeat.Name = "tlpSeat";
            this.tlpSeat.RowCount = 3;
            this.tlpSeat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSeat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSeat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSeat.Size = new System.Drawing.Size(882, 418);
            this.tlpSeat.TabIndex = 2;
            this.tlpSeat.Visible = false;
            // 
            // pnlScreeningInfo
            // 
            this.pnlScreeningInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlScreeningInfo.Location = new System.Drawing.Point(0, 483);
            this.pnlScreeningInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlScreeningInfo.Name = "pnlScreeningInfo";
            this.pnlScreeningInfo.Size = new System.Drawing.Size(882, 70);
            this.pnlScreeningInfo.TabIndex = 3;
            this.pnlScreeningInfo.Visible = false;
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnlScreeningInfo);
            this.Controls.Add(this.tlpSeat);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlShowtime);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlShowtime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpTime;
        private TableLayoutPanel tlpDate;
        private Panel pnlShowtime;
        private Label lblMessage;
        private TableLayoutPanel tlpSeat;
        private Panel pnlScreeningInfo;
    }
}