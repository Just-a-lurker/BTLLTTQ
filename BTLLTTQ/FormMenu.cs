using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ
{
    public partial class FormMenu : Form
    {
        private const int BTW = 0xA1;
        private const int HTC = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
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
        public FormMenu()
        {
            random = new Random();
            InitializeComponent();
            RoundCorners();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private Color SelectThemeColor()
        {
            int index=random.Next(BackGR.ColorList.Count);

            while(tempIndex==index)
            {
                 random.Next(BackGR.ColorList.Count);
            }
            tempIndex = index;
            string color = BackGR.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                DisableButton();
                if (currentButton!=(Button)btnsender)
                {
                    Color color = SelectThemeColor();
                    currentButton=(Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panel_bar.BackColor = color;
                    panel2.BackColor = BackGR.ChangeColorBrightness(color,-0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 18, 80);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btn_pd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu.FormProduct(), sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu.FormOrder(), sender);
        }
        private void btn_ct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu.FormCustomer(), sender);
        }
        private void btn_rp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu.FormReport(), sender);
        }
        private void btn_st_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btn_lo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(childForm);
            this.panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
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

        private void panel_bar_MouseDown(object sender, MouseEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_backpr_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
           
                activeForm.Close();
                Reset();
            
        }
        private void Reset()
        {
            DisableButton();
            label1.Text = "HOME";
            panel_bar.BackColor = Color.FromArgb(10, 18, 80);
            panel2.BackColor = Color.FromArgb(212, 175, 55);
            currentButton = null;
            btn_backpr.Visible = false;
        }
    }
}
