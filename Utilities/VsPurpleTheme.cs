using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Utilities
{
    /// <summary>
    /// Provides consistent Visual Studio Purple styling across all Windows Forms.
    /// Visual Studio Purple (#5C2D91) is the signature Microsoft developer theme color.
    /// </summary>
    public static class VsPurpleTheme
    {
        // Primary Palette - Visual Studio Purple Identity
        public static readonly Color DeepPurple = Color.FromArgb(45, 15, 75);      // #2D0F4B - Dark banner & sidebars
        public static readonly Color PrimaryPurple = Color.FromArgb(92, 45, 145);   // #5C2D91 - Visual Studio Classic Purple
        public static readonly Color AccentPurple = Color.FromArgb(126, 56, 183);   // #7E38B7 - Vivid Accent & selection
        public static readonly Color HoverPurple = Color.FromArgb(142, 68, 173);    // #8E44AD - Hover state
        public static readonly Color LightPurple = Color.FromArgb(243, 237, 247);   // #F3EDF7 - Soft lavender surface
        public static readonly Color AltRowPurple = Color.FromArgb(250, 247, 253);  // #FAF7FD - Alternating row
        public static readonly Color BorderPurple = Color.FromArgb(212, 196, 230);  // #D4C4E6 - Subtle card borders

        // Neutral & Surface Colors
        public static readonly Color SurfaceBackground = Color.FromArgb(248, 246, 251); // Soft neutral background
        public static readonly Color CardBackground = Color.White;
        public static readonly Color TextPrimary = Color.FromArgb(32, 24, 40);       // High-contrast charcoal
        public static readonly Color TextSecondary = Color.FromArgb(108, 97, 122);  // Muted purple-gray
        public static readonly Color TextLight = Color.White;

        // Semantic Status Colors
        public static readonly Color SuccessGreen = Color.FromArgb(34, 139, 34);    // #228B22
        public static readonly Color SuccessHover = Color.FromArgb(46, 160, 46);
        public static readonly Color DangerRed = Color.FromArgb(192, 41, 43);       // #C0292B
        public static readonly Color DangerHover = Color.FromArgb(217, 54, 56);
        public static readonly Color WarningAmber = Color.FromArgb(217, 119, 6);     // #D97706
        public static readonly Color WarningHover = Color.FromArgb(245, 158, 11);

        // Standard Typography (Segoe UI)
        public static readonly Font HeaderFont = new Font("Segoe UI", 16f, FontStyle.Bold);
        public static readonly Font TitleFont = new Font("Segoe UI Semibold", 12f, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 9.25f, FontStyle.Regular);
        public static readonly Font BodyFont = new Font("Segoe UI", 9.25f, FontStyle.Regular);
        public static readonly Font BodyBoldFont = new Font("Segoe UI", 9.25f, FontStyle.Bold);
        public static readonly Font CaptionFont = new Font("Segoe UI", 8.25f, FontStyle.Regular);

        /// <summary>
        /// Styles the entire form with the Visual Studio Purple theme.
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            if (form == null) return;
            form.Font = BodyFont;
            form.BackColor = SurfaceBackground;
            form.ForeColor = TextPrimary;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Styles a header panel with a deep purple gradient, title, and subtitle.
        /// </summary>
        public static void StyleHeaderPanel(Panel panel, Label lblTitle, Label lblSubtitle = null)
        {
            if (panel == null) return;

            panel.BackColor = DeepPurple;
            panel.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(
                    panel.ClientRectangle,
                    DeepPurple,
                    PrimaryPurple,
                    LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }

                // Bottom accent highlight line
                using (var pen = new Pen(AccentPurple, 2f))
                {
                    e.Graphics.DrawLine(pen, 0, panel.Height - 1, panel.Width, panel.Height - 1);
                }
            };

            if (lblTitle != null)
            {
                lblTitle.BackColor = Color.Transparent;
                lblTitle.ForeColor = TextLight;
                lblTitle.Font = HeaderFont;
            }

            if (lblSubtitle != null)
            {
                lblSubtitle.BackColor = Color.Transparent;
                lblSubtitle.ForeColor = Color.FromArgb(220, 210, 235);
                lblSubtitle.Font = SubtitleFont;
            }
        }

        /// <summary>
        /// Styles a primary action button (Save, Search, Main Action) in rich Visual Studio purple.
        /// </summary>
        public static void StylePrimaryButton(Button btn, string iconText = "")
        {
            if (btn == null) return;
            if (!string.IsNullOrEmpty(iconText) && !btn.Text.StartsWith(iconText))
            {
                btn.Text = iconText + " " + btn.Text;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = PrimaryPurple;
            btn.ForeColor = TextLight;
            btn.Font = BodyBoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = Math.Max(btn.Height, 34);

            btn.MouseEnter += (s, e) => btn.BackColor = HoverPurple;
            btn.MouseLeave += (s, e) => btn.BackColor = PrimaryPurple;
        }

        /// <summary>
        /// Styles a secondary action button (Clear, Refresh, Back).
        /// </summary>
        public static void StyleSecondaryButton(Button btn, string iconText = "")
        {
            if (btn == null) return;
            if (!string.IsNullOrEmpty(iconText) && !btn.Text.StartsWith(iconText))
            {
                btn.Text = iconText + " " + btn.Text;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderPurple;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = CardBackground;
            btn.ForeColor = PrimaryPurple;
            btn.Font = BodyBoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = Math.Max(btn.Height, 34);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = LightPurple;
                btn.FlatAppearance.BorderColor = AccentPurple;
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = CardBackground;
                btn.FlatAppearance.BorderColor = BorderPurple;
            };
        }

        /// <summary>
        /// Styles a success button (Create, Add).
        /// </summary>
        public static void StyleSuccessButton(Button btn, string iconText = "")
        {
            if (btn == null) return;
            if (!string.IsNullOrEmpty(iconText) && !btn.Text.StartsWith(iconText))
            {
                btn.Text = iconText + " " + btn.Text;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = SuccessGreen;
            btn.ForeColor = TextLight;
            btn.Font = BodyBoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = Math.Max(btn.Height, 34);

            btn.MouseEnter += (s, e) => btn.BackColor = SuccessHover;
            btn.MouseLeave += (s, e) => btn.BackColor = SuccessGreen;
        }

        /// <summary>
        /// Styles a dangerous action button (Delete, Remove) in solid red.
        /// </summary>
        public static void StyleDangerButton(Button btn, string iconText = "")
        {
            if (btn == null) return;
            if (!string.IsNullOrEmpty(iconText) && !btn.Text.StartsWith(iconText))
            {
                btn.Text = iconText + " " + btn.Text;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = DangerRed;
            btn.ForeColor = TextLight;
            btn.Font = BodyBoldFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = Math.Max(btn.Height, 34);

            btn.MouseEnter += (s, e) => btn.BackColor = DangerHover;
            btn.MouseLeave += (s, e) => btn.BackColor = DangerRed;
        }

        /// <summary>
        /// Styles a card container panel with a clean border and white background.
        /// </summary>
        public static void StyleCardPanel(Panel panel)
        {
            if (panel == null) return;
            panel.BackColor = CardBackground;
            panel.Padding = new Padding(12);

            panel.Paint += (s, e) =>
            {
                using (var pen = new Pen(BorderPurple, 1f))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                }
            };
        }

        /// <summary>
        /// Styles a DataGridView with the signature Visual Studio Purple header,
        /// zebra-striped alternating rows, and smooth selection colors.
        /// </summary>
        public static void StyleDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = SurfaceBackground;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = BorderPurple;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Column Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryPurple;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextLight;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Default Row Style
            dgv.DefaultCellStyle.BackColor = CardBackground;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.Font = BodyFont;
            dgv.DefaultCellStyle.SelectionBackColor = AccentPurple;
            dgv.DefaultCellStyle.SelectionForeColor = TextLight;
            dgv.DefaultCellStyle.Padding = new Padding(6, 2, 6, 2);

            // Alternating Row Style
            dgv.AlternatingRowsDefaultCellStyle.BackColor = AltRowPurple;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextPrimary;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = AccentPurple;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = TextLight;

            dgv.RowTemplate.Height = 32;
        }

        /// <summary>
        /// Styles a status strip with modern VS Purple branding.
        /// </summary>
        public static void StyleStatusStrip(StatusStrip statusStrip)
        {
            if (statusStrip == null) return;
            statusStrip.BackColor = DeepPurple;
            statusStrip.ForeColor = Color.FromArgb(230, 222, 242);
            statusStrip.Font = CaptionFont;
            statusStrip.SizingGrip = false;
        }
    }
}
