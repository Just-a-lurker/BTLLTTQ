﻿using System;
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
    public partial class Login : Form
    {
        Modify modify = new Modify();
        CDataBase dbase = new CDataBase();
        private const int BTW = 0xA1;
        private const int HTC = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public Login()
        {
            InitializeComponent();
            RoundCorners();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            } else
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0) {
                    ReleaseCapture();
                    SendMessage(this.Handle, BTW, HTC, 0);
                }
            }
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == ""||tb_password.Text== "")
            {
                MessageBox.Show("Điền đầy đủ thông tin đi fen", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(tb_username.Text =="") tb_username.Focus();
                else if(tb_password.Text =="") tb_password.Focus();
            }else
            {
                string username = tb_username.Text;
                string password = tb_password.Text;
                string querry = "Select Count(*) from TaiKhoan where TenTK=@username and MatKhau=@password";
                int cnt = dbase.Check_Account(querry, "@username", "@password", username, password);
                if (cnt != 0)
                {
                    this.Hide();
                    new FormMenu().Show();
                }
                else
                {
                    MessageBox.Show("Authentication Failed");
                }
                //string username = tb_username.Text;
                //string password=tb_password.Text;
                //string querry = "Select * from TaiKhoan where TenTK='"+username+"' and MatKhau ='"+password+"'";
                //if(modify.Accounts(querry).Count!=0)
                //{
                //    this.Hide();
                //    (new FormMenu()).Show();
                    
                //}
                //else
                //{
                //    MessageBox.Show("Authentication Failed");
                  
                   
                //}
            }
        }

        private void check_sp_CheckedChanged(object sender, EventArgs e)
        {
            if(check_sp.Checked)
            {
                tb_password.PasswordChar = '\0';
            }else
            {
                tb_password.PasswordChar = '•';
            }
        }
    }
}
