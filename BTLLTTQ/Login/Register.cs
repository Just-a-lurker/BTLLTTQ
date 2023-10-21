using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ
{
    public partial class Register : Form
    {
        private const int BTW = 0xA1;
        private const int HTC = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public Register()
        {
            InitializeComponent(); RoundCorners();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, BTW, HTC, 0);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            else
            {

            }
        }
        private void RoundCorners()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int ra = 15;
            path.AddArc(0, 0, ra, ra, 180, 90);
            path.AddArc(this.Width - ra, 0, ra, ra, 270, 90);
            path.AddArc(this.Width - ra, this.Height - ra, ra, ra, 0, 90);
            path.AddArc(0, this.Height - ra, ra, ra, 90, 90);

            this.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_cpw.Text = "";
            tb_id.Text = "";
            tb_un.Text = "";
            tb_pw.Text = "";
            tb_id.Focus();
        }

        private void check_sp_CheckedChanged(object sender, EventArgs e)
        {
            if (check_sp.Checked)
            {
                tb_pw.PasswordChar = '\0';
                tb_cpw.PasswordChar = '\0';
            }
            else
            {
                tb_pw.PasswordChar = '•';
                tb_cpw.PasswordChar = '•';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new Login()).Show();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkID(string id)
        {
            return true;
        }
    }
}
