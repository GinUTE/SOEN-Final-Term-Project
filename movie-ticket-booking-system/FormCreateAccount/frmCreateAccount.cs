using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;
using movie_ticket_booking_system.FormLogIn;
using movie_ticket_booking_system.FormUser;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormCreateAccount
{
    public partial class frmCreateAccount : Form
    {
        private readonly frmUser _parentForm;
        private readonly UserBUS _userBUS;

        public frmCreateAccount(frmUser parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _userBUS = new UserBUS();
        }

        private void llbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            _parentForm.LoadChildForm(new frmLogIn(_parentForm));
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtConfirmPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                lblRegisteredPhone.Visible = false;
                txtPhone.BorderFocusedColor = Color.Blue;

                var phone = txtPhone.CustomText.Trim();
                if (string.IsNullOrEmpty(phone) || !_userBUS.PhoneDoesExist(phone)) return;

                lblRegisteredPhone.Visible = true;
                txtPhone.BorderFocusedColor = Color.Red;
                txtPhone.Focus();
            }
            catch (SqlException ex)
            {
                Messenger.Error("Unexpected SQL related error: " + ex.Number);
            }
            catch (Exception ex)
            {
                Messenger.Error("Unexpected runtime error: " + ex);
            }
        }

        private bool IsAllFilledIn()
        {
            var isFilled = true;
            foreach (var control in Controls)
                switch (control)
                {
                    case TextBox txt:
                        isFilled &= !string.IsNullOrEmpty(txt.Text);
                        break;
                    case ComboBox cmb:
                        isFilled &= !string.IsNullOrEmpty(cmb.Text);
                        break;
                }

            return isFilled;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                lblRegisteredPhone.Visible = lblUnmatchedPassword.Visible = false;
                txtPhone.BorderFocusedColor = txtConfirmPassword.BorderFocusedColor = Color.Blue;

                if (!IsAllFilledIn()) return;

                var password = txtPassword.CustomText.Trim();
                var confirmPassword = txtConfirmPassword.CustomText.Trim();
                if (password.Equals(confirmPassword))
                {
                    var phone = txtPhone.CustomText.Trim();
                    var fullName = txtFullName.CustomText.Trim();
                    var email = txtEmail.CustomText.Trim();
                    var dateOfBirth = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
                    var isMale = chkMale.Checked;
                    var city = cmbCity.SelectedItem.ToString();

                    var user = new User(phone, fullName, dateOfBirth, isMale, email, city);
                    _userBUS.CreateUserAccount(user, password);
                    Messenger.Notification("Account created successfully!");
                }
                else
                {
                    lblUnmatchedPassword.Visible = true;
                    txtConfirmPassword.BorderFocusedColor = Color.Red;
                    txtConfirmPassword.Focus();
                }
            }
            catch (SqlException ex)
            {
                Messenger.Error("Unexpected SQL related error: " + ex.Number);
            }
            catch (Exception ex)
            {
                Messenger.Error("Unexpected runtime error: " + ex);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (Messenger.Confirm("Are you sure you want to quit creating an account?") == DialogResult.Yes)
                Application.Exit();
        }
    }
}