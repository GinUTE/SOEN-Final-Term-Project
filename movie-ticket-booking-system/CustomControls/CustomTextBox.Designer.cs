namespace movie_ticket_booking_system.CustomControls
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustom
            // 
            this.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustom.Location = new System.Drawing.Point(7, 7);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(236, 23);
            this.txtCustom.TabIndex = 0;
            this.txtCustom.Click += new System.EventHandler(this.txtCustom_Click);
            this.txtCustom.TextChanged += new System.EventHandler(this.txtCustom_TextChanged);
            this.txtCustom.Enter += new System.EventHandler(this.txtCustom_Enter);
            this.txtCustom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustom_KeyPress);
            this.txtCustom.Leave += new System.EventHandler(this.txtCustom_Leave);
            this.txtCustom.MouseEnter += new System.EventHandler(this.txtCustom_MouseEnter);
            this.txtCustom.MouseLeave += new System.EventHandler(this.txtCustom_MouseLeave);
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtCustom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustom;
    }
}
