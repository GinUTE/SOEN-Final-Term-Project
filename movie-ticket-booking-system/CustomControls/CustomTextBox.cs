using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace movie_ticket_booking_system.CustomControls
{
    public partial class CustomTextBox : UserControl
    {
        private Color _borderColor;
        private Color _borderFocusedColor;
        private int _borderWidth;
        private bool _isFocused;
        private bool _isUnderlined;

        public CustomTextBox()
        {
            InitializeComponent();

            _borderWidth = 0;
            _borderColor = Color.White;
            _borderFocusedColor = Color.Blue;
            _isFocused = _isUnderlined = false;
        }

        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color BorderFocusedColor
        {
            get => _borderFocusedColor;
            set
            {
                _borderFocusedColor = value;
                Invalidate();
            }
        }

        public bool Underline
        {
            get => _isUnderlined;
            set
            {
                _isUnderlined = value;
                Invalidate();
            }
        }

        public bool PasswordChar
        {
            get => txtCustom.UseSystemPasswordChar;
            set => txtCustom.UseSystemPasswordChar = value;
        }

        public bool Multiline
        {
            get => txtCustom.Multiline;
            set => txtCustom.Multiline = value;
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                txtCustom.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                txtCustom.ForeColor = value;
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                txtCustom.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        public string CustomText
        {
            get => txtCustom.Text;
            set => txtCustom.Text = value;
        }

        public event EventHandler CustomTextChanged;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (var g = e.Graphics)
            {
                using (var pen = new Pen(_borderColor, _borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    if (_isFocused)
                        pen.Color = _borderFocusedColor;
                    if (_isUnderlined)
                        g.DrawLine(pen, 0, Height - 1, Width, Height - 1);
                    else g.DrawRectangle(pen, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (txtCustom.Multiline) return;

            var height = TextRenderer.MeasureText("Text", Font).Height + 1;
            txtCustom.Multiline = true;
            txtCustom.MinimumSize = new Size(0, height);
            txtCustom.Multiline = false;
            Height = txtCustom.Height + Padding.Top + Padding.Bottom;
        }

        private void txtCustom_Leave(object sender, EventArgs e)
        {
            _isFocused = false;
            Invalidate();
        }

        private void txtCustom_Enter(object sender, EventArgs e)
        {
            _isFocused = true;
            Invalidate();
        }

        private void txtCustom_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void txtCustom_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void txtCustom_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void txtCustom_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void txtCustom_TextChanged(object sender, EventArgs e)
        {
            CustomTextChanged?.Invoke(sender, e);
        }
    }
}