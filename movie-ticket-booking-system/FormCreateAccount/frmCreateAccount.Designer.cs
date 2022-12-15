using System.ComponentModel;
using System.Windows.Forms;
using movie_ticket_booking_system.CustomControls;

namespace movie_ticket_booking_system.FormCreateAccount
{
    partial class frmCreateAccount
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
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRegisteredPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.llbLogIn = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblUnmatchedPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new movie_ticket_booking_system.CustomControls.CustomTextBox();
            this.txtPassword = new movie_ticket_booking_system.CustomControls.CustomTextBox();
            this.txtEmail = new movie_ticket_booking_system.CustomControls.CustomTextBox();
            this.txtFullName = new movie_ticket_booking_system.CustomControls.CustomTextBox();
            this.txtPhone = new movie_ticket_booking_system.CustomControls.CustomTextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.Location = new System.Drawing.Point(12, 9);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(200, 46);
            this.lblGetStarted.TabIndex = 0;
            this.lblGetStarted.Text = "Get Started";
            this.lblGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegisteredPhone
            // 
            this.lblRegisteredPhone.AutoSize = true;
            this.lblRegisteredPhone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredPhone.Location = new System.Drawing.Point(16, 137);
            this.lblRegisteredPhone.Name = "lblRegisteredPhone";
            this.lblRegisteredPhone.Size = new System.Drawing.Size(120, 19);
            this.lblRegisteredPhone.TabIndex = 3;
            this.lblRegisteredPhone.Text = "Registered phone!";
            this.lblRegisteredPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegisteredPhone.Visible = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(16, 340);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(84, 23);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Full name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(201, 549);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(69, 27);
            this.chkMale.TabIndex = 16;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(16, 520);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(107, 23);
            this.lblDateOfBirth.TabIndex = 14;
            this.lblDateOfBirth.Text = "Date of birth";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOfBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(20, 546);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(135, 30);
            this.dtpDateOfBirth.TabIndex = 15;
            this.dtpDateOfBirth.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 430);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hồ Chí Minh",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cmbCity.Location = new System.Drawing.Point(20, 621);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(250, 31);
            this.cmbCity.Sorted = true;
            this.cmbCity.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 595);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 23);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Location = new System.Drawing.Point(52, 675);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(90, 35);
            this.btnSignUp.TabIndex = 19;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Location = new System.Drawing.Point(148, 675);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 35);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // llbLogIn
            // 
            this.llbLogIn.AutoSize = true;
            this.llbLogIn.LinkColor = System.Drawing.Color.Black;
            this.llbLogIn.Location = new System.Drawing.Point(116, 713);
            this.llbLogIn.Name = "llbLogIn";
            this.llbLogIn.Size = new System.Drawing.Size(57, 23);
            this.llbLogIn.TabIndex = 21;
            this.llbLogIn.TabStop = true;
            this.llbLogIn.Text = "Log in";
            this.llbLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogIn_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(16, 250);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(147, 23);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnmatchedPassword
            // 
            this.lblUnmatchedPassword.AutoSize = true;
            this.lblUnmatchedPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnmatchedPassword.Location = new System.Drawing.Point(16, 317);
            this.lblUnmatchedPassword.Name = "lblUnmatchedPassword";
            this.lblUnmatchedPassword.Size = new System.Drawing.Size(146, 19);
            this.lblUnmatchedPassword.TabIndex = 9;
            this.lblUnmatchedPassword.Text = "Unmatched password!";
            this.lblUnmatchedPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnmatchedPassword.Visible = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AutoSize = true;
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderFocusedColor = System.Drawing.Color.Blue;
            this.txtConfirmPassword.BorderWidth = 0;
            this.txtConfirmPassword.CustomText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 276);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 38);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.Underline = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.BorderWidth = 0;
            this.txtPassword.CustomText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 186);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Underline = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.BorderWidth = 0;
            this.txtEmail.CustomText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 456);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 38);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Underline = true;
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.BorderColor = System.Drawing.Color.Black;
            this.txtFullName.BorderFocusedColor = System.Drawing.Color.Blue;
            this.txtFullName.BorderWidth = 0;
            this.txtFullName.CustomText = "";
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(20, 366);
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFullName.PasswordChar = false;
            this.txtFullName.Size = new System.Drawing.Size(250, 38);
            this.txtFullName.TabIndex = 11;
            this.txtFullName.Underline = true;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderFocusedColor = System.Drawing.Color.Blue;
            this.txtPhone.BorderWidth = 0;
            this.txtPhone.CustomText = "";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(20, 96);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(250, 38);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Underline = true;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(152, 226);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(126, 23);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // frmCreateAccount
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(290, 745);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblUnmatchedPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.llbLogIn);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblRegisteredPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGetStarted);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGetStarted;
        private Label lblPhone;
        private CustomTextBox txtPhone;
        private Label lblRegisteredPhone;
        private Label lblFullName;
        private CustomTextBox txtFullName;
        private CheckBox chkMale;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblEmail;
        private CustomTextBox txtEmail;
        private ComboBox cmbCity;
        private Label lblCity;
        private Button btnSignUp;
        private Button btnQuit;
        private LinkLabel llbLogIn;
        private Label lblPassword;
        private CustomTextBox txtPassword;
        private Label lblConfirmPassword;
        private CustomTextBox txtConfirmPassword;
        private Label lblUnmatchedPassword;
        private CheckBox chkShowPassword;
    }
}