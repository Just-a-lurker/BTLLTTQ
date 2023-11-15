﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLTTQ.NhapVaBan;
using FontAwesome.Sharp;
namespace BTLLTTQ
{
    public partial class FormMNN : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
         bool isCollapsed;
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
                //iconCurrentChildForm.IconColor = color;
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panel_od.Height += 10;
                if(panel_od.Height == panel_od.MaximumSize.Height)
                {
                   
                    isCollapsed = false; timer1.Stop();
                }
            }else
            {
                panel_od.Height -= 10;
                if (panel_od.Height == panel_od.MinimumSize.Height)
                {
                  
                    isCollapsed = true; timer1.Stop();
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_rp.Height += 10;
                if (panel_rp.Height == panel_rp.MaximumSize.Height)
                {

                    isCollapsed = false; timer3.Stop();
                }
            }
            else
            {
                panel_rp.Height -= 10;
                if (panel_rp.Height == panel_rp.MinimumSize.Height)
                {

                    isCollapsed = true; timer3.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_ct.Height += 10;
                if (panel_ct.Height == panel_ct.MaximumSize.Height)
                {

                    isCollapsed = false; timer2.Stop();
                }
            }
            else
            {
                panel_ct.Height -= 10;
                if (panel_ct.Height == panel_ct.MinimumSize.Height)
                {

                    isCollapsed = true; timer2.Stop();
                }
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ActivateButton(sender, RGBColors.color3);
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            timer2.Start();
            ActivateButton(sender, RGBColors.color6);
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
           
        }
        private void iconButton9_Click(object sender, EventArgs e)
        {
            timer3.Start();
            ActivateButton(sender, RGBColors.color4);
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
           
        }
        private void btn_home_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            pictureBox2.Visible = true;
            OpenChildForm(new FormMN());
        }

      

      

        private void btn_log_Click(object sender, EventArgs e)
        {
            this.Close();
            ActivateButton(sender, RGBColors.color7);
        }








        //ae đặt form mình làm ở đây nhé
        private void btn_pro_Click(object sender, EventArgs e)
        {
            //form san pham
            ActivateButton(sender, RGBColors.color2);
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            //OpenChildForm(new FormDashboard());
        }

        private void btn_stf_Click(object sender, EventArgs e)
        {
            //form nhan vien

            ActivateButton(sender, RGBColors.color5);
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            //OpenChildForm(new FormDashboard());
        }
        private void btn_ncc_Click(object sender, EventArgs e)
        {
            //form nha cung cap
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            //form nha khach hang
        }

        private void btn_ddh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDonDatHang());
            //don dat hang
        }

        private void btn_nh_Click(object sender, EventArgs e)
        {
            //form nhap hang
        }

        private void btn_rp4_Click(object sender, EventArgs e)
        {
            //form bao cao
        }

        private void btn_rp3_Click(object sender, EventArgs e)
        {
            //form bao cao
        }

        private void btn_rp2_Click(object sender, EventArgs e)
        {
            //form bao cao
        }

        private void btn_rp1_Click(object sender, EventArgs e)
        {
            //form bao cao
        }


    }
}

