using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLTTQ.Menu;
using BTLLTTQ.Menu_Items;
using BTLLTTQ.NhapVaBan;
using FontAwesome.Sharp;
namespace BTLLTTQ
{
    public partial class FormMNN : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool isCollapsed;
        void checkcoll(Panel tenpanel,Timer timer)
        {
			if (isCollapsed)
			{
				tenpanel.Height += 10;
				if (tenpanel.Height == tenpanel.MaximumSize.Height)
				{

					isCollapsed = false; timer.Stop();
				}
			}
			else
			{
				tenpanel.Height -= 10;
				if (tenpanel.Height == tenpanel.MinimumSize.Height)
				{

					isCollapsed = true; timer.Stop();
				}
			}
		}
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 255, 0);
        }
        public FormMNN()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8,60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(childForm);
            panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(10, 18, 80);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelbar2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maz_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_miz_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMNN_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //form cho nha cung cap
		private void btn_supplier_Click(object sender, EventArgs e)
		{
			DisableButton();
		    OpenChildForm(new FormNhaCungCap());
		}
		//form cho khach hang
		private void btn_consumer_Click(object sender, EventArgs e)
		{
			DisableButton();
			OpenChildForm(new FormKhachHang());
		}
		//form cho dondat hang
		private void btn_ddh_Click(object sender, EventArgs e)
		{
			DisableButton();
			OpenChildForm(new FormDonDatHang());
		}
		//form cho don nhap hang
		private void btn_dnh_Click(object sender, EventArgs e)
		{
			DisableButton();
			OpenChildForm(new FormNhap());
		}
		//form cho bao cao
		private void btn_rp1_Click(object sender, EventArgs e)
		{
			DisableButton();
			//OpenChildForm(new FormDashboard());
		}
		//form cho bao cao
		private void btn_rp2_Click(object sender, EventArgs e)
		{
			DisableButton();
			//OpenChildForm(new FormDashboard());
		}
		//form cho bao cao
		private void btn_rp3_Click(object sender, EventArgs e)
		{
			DisableButton();
			//OpenChildForm(new FormDashboard());
		}
		//form cho bao cao
		private void btn_rp4_Click(object sender, EventArgs e)
		{
			DisableButton();
			//OpenChildForm(new FormDashboard());
		}

		private void btn_home_Click(object sender, EventArgs e)
		{

			ActivateButton(sender, RGBColors.color1);

			OpenChildForm(new FormMN());
		}

		private void btn_pro_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color2);

			OpenChildForm(new FormProduct());
		}


		private void btn_stf_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color5);
			OpenChildForm(new FormStaff());
		}

		private void btn_log_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color7);
		}
		private void ibtn_report_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
            timer3.Start();
			
		}

		private void ibtn_order_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
            timer1.Start();
		}

		private void ibtn_customer_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
            timer2.Start();	
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
            checkcoll(flp_order, timer1);
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			checkcoll(flp_cst, timer2);
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			checkcoll(panel_report, timer3);
		}
	}
}

