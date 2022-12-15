namespace movie_ticket_booking_system.FormAddScreening
{
    partial class frmAddScreening
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
            this.dgvScreening = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreening)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScreening
            // 
            this.dgvScreening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreening.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvScreening.Location = new System.Drawing.Point(0, 200);
            this.dgvScreening.Margin = new System.Windows.Forms.Padding(0);
            this.dgvScreening.Name = "dgvScreening";
            this.dgvScreening.ReadOnly = true;
            this.dgvScreening.RowHeadersVisible = false;
            this.dgvScreening.RowHeadersWidth = 51;
            this.dgvScreening.RowTemplate.Height = 24;
            this.dgvScreening.Size = new System.Drawing.Size(1500, 700);
            this.dgvScreening.TabIndex = 0;
            // 
            // frmAddScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.dgvScreening);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Screening";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreening)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScreening;
    }
}