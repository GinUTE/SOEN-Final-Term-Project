using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using movie_ticket_booking_system.BLL;
using movie_ticket_booking_system.FormCreateAccount;
using movie_ticket_booking_system.FormUser;
using movie_ticket_booking_system.Models;

namespace movie_ticket_booking_system.FormLogIn
{
    public partial class frmLogIn : Form
    {
        private readonly frmUser _parentForm;
        private readonly UserBUS _userBUS;

        public frmLogIn(frmUser parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _userBUS = new UserBUS();
        }

        private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            _parentForm.LoadChildForm(new frmCreateAccount(_parentForm));
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                lblUnregisteredPhone.Visible = lblWrongPassword.Visible = false;
                txtPhone.BorderFocusedColor = txtPassword.BorderFocusedColor = Color.Blue;

                var phone = txtPhone.CustomText.Trim();
                if (!string.IsNullOrEmpty(phone) && _userBUS.PhoneDoesExist(phone))
                {
                    var password = txtPassword.CustomText.Trim();

                    var account = new Account(phone, password);
                    if (!string.IsNullOrEmpty(password) && _userBUS.AccountDoesExist(account))
                    {
                        _userBUS.UpdateAccountLastSeen(phone);

                        _parentForm.DialogResult = _userBUS.IsAdmin(phone) ? DialogResult.Yes : DialogResult.OK;
                        _parentForm.Close();
                    }
                    else
                    {
                        lblWrongPassword.Visible = true;
                        txtPassword.BorderFocusedColor = Color.Red;
                        txtPassword.Focus();
                    }
                }
                else
                {
                    lblUnregisteredPhone.Visible = true;
                    txtPhone.BorderFocusedColor = Color.Red;
                    txtPhone.Focus();
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
            if (Messenger.Confirm("Are you sure you want to quit logging in?") == DialogResult.Yes)
                Application.Exit();
        }
    }
}