namespace movie_ticket_booking_system.FormYourTicket
{
    partial class frmMyTicket
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
            this.dgvYourTicket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYourTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYourTicket
            // 
            this.dgvYourTicket.AllowUserToAddRows = false;
            this.dgvYourTicket.AllowUserToDeleteRows = false;
            this.dgvYourTicket.AllowUserToOrderColumns = true;
            this.dgvYourTicket.AllowUserToResizeRows = false;
            this.dgvYourTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYourTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYourTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYourTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYourTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYourTicket.Location = new System.Drawing.Point(0, 0);
            this.dgvYourTicket.Margin = new System.Windows.Forms.Padding(0);
            this.dgvYourTicket.Name = "dgvYourTicket";
            this.dgvYourTicket.ReadOnly = true;
            this.dgvYourTicket.RowHeadersVisible = false;
            this.dgvYourTicket.RowHeadersWidth = 51;
            this.dgvYourTicket.RowTemplate.Height = 24;
            this.dgvYourTicket.Size = new System.Drawing.Size(1500, 900);
            this.dgvYourTicket.TabIndex = 0;
            // 
            // frmMyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.dgvYourTicket);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMyTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYourTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYourTicket;
    }
}