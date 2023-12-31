﻿using System;

namespace BTLLTTQ
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btn_lo = new System.Windows.Forms.Button();
            this.btn_st = new System.Windows.Forms.Button();
            this.btn_rp = new System.Windows.Forms.Button();
            this.btn_partner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_pd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_bar = new System.Windows.Forms.Panel();
            this.btn_backpr = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.panel_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.pMenu.Controls.Add(this.btn_lo);
            this.pMenu.Controls.Add(this.btn_st);
            this.pMenu.Controls.Add(this.btn_rp);
            this.pMenu.Controls.Add(this.btn_partner);
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.btn_pd);
            this.pMenu.Controls.Add(this.panel2);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(190, 569);
            this.pMenu.TabIndex = 0;
            // 
            // btn_lo
            // 
            this.btn_lo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lo.FlatAppearance.BorderSize = 0;
            this.btn_lo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_lo.Image = global::BTLLTTQ.Properties.Resources.Open_Pane;
            this.btn_lo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lo.Location = new System.Drawing.Point(0, 364);
            this.btn_lo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_lo.Name = "btn_lo";
            this.btn_lo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_lo.Size = new System.Drawing.Size(190, 57);
            this.btn_lo.TabIndex = 6;
            this.btn_lo.Text = "    LogOut";
            this.btn_lo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lo.UseVisualStyleBackColor = true;
            this.btn_lo.Click += new System.EventHandler(this.btn_lo_Click);
            // 
            // btn_st
            // 
            this.btn_st.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_st.FlatAppearance.BorderSize = 0;
            this.btn_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_st.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_st.Image = global::BTLLTTQ.Properties.Resources.Settings;
            this.btn_st.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_st.Location = new System.Drawing.Point(0, 307);
            this.btn_st.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_st.Name = "btn_st";
            this.btn_st.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_st.Size = new System.Drawing.Size(190, 57);
            this.btn_st.TabIndex = 5;
            this.btn_st.Text = "    Staff";
            this.btn_st.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_st.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_st.UseVisualStyleBackColor = true;
            this.btn_st.Click += new System.EventHandler(this.btn_st_Click);
            // 
            // btn_rp
            // 
            this.btn_rp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rp.FlatAppearance.BorderSize = 0;
            this.btn_rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_rp.Image = global::BTLLTTQ.Properties.Resources.Graph_Report;
            this.btn_rp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rp.Location = new System.Drawing.Point(0, 250);
            this.btn_rp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rp.Name = "btn_rp";
            this.btn_rp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_rp.Size = new System.Drawing.Size(190, 57);
            this.btn_rp.TabIndex = 4;
            this.btn_rp.Text = "    Reporting";
            this.btn_rp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rp.UseVisualStyleBackColor = true;
            this.btn_rp.Click += new System.EventHandler(this.btn_rp_Click);
            // 
            // btn_partner
            // 
            this.btn_partner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_partner.FlatAppearance.BorderSize = 0;
            this.btn_partner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_partner.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_partner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_partner.Image = global::BTLLTTQ.Properties.Resources.Customer;
            this.btn_partner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_partner.Location = new System.Drawing.Point(0, 237);
            this.btn_partner.Name = "btn_partner";
            this.btn_partner.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_partner.Size = new System.Drawing.Size(254, 70);
            this.btn_partner.TabIndex = 3;
            this.btn_partner.Text = "    Partner";
            this.btn_partner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_partner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_partner.UseVisualStyleBackColor = true;
            this.btn_partner.Click += new System.EventHandler(this.btn_ct_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = global::BTLLTTQ.Properties.Resources.Purchase_Order;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(190, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "    Orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pd
            // 
            this.btn_pd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pd.FlatAppearance.BorderSize = 0;
            this.btn_pd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pd.Image = global::BTLLTTQ.Properties.Resources.Shopping_Cart;
            this.btn_pd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pd.Location = new System.Drawing.Point(0, 79);
            this.btn_pd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_pd.Name = "btn_pd";
            this.btn_pd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pd.Size = new System.Drawing.Size(190, 57);
            this.btn_pd.TabIndex = 1;
            this.btn_pd.Text = "    Products";
            this.btn_pd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pd.UseVisualStyleBackColor = true;
            this.btn_pd.Click += new System.EventHandler(this.btn_pd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 79);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel_bar
            // 
            this.panel_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel_bar.Controls.Add(this.btn_backpr);
            this.panel_bar.Controls.Add(this.btn_close);
            this.panel_bar.Controls.Add(this.label1);
            this.panel_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bar.Location = new System.Drawing.Point(190, 0);
            this.panel_bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_bar.Name = "panel_bar";
            this.panel_bar.Size = new System.Drawing.Size(710, 81);
            this.panel_bar.TabIndex = 1;
            this.panel_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_bar_MouseDown);
            // 
            // btn_backpr
            // 
            this.btn_backpr.FlatAppearance.BorderSize = 0;
            this.btn_backpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backpr.Image = global::BTLLTTQ.Properties.Resources.Home;
            this.btn_backpr.Location = new System.Drawing.Point(0, 0);
            this.btn_backpr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_backpr.Name = "btn_backpr";
            this.btn_backpr.Size = new System.Drawing.Size(38, 41);
            this.btn_backpr.TabIndex = 1;
            this.btn_backpr.UseVisualStyleBackColor = true;
            this.btn_backpr.Visible = false;
            this.btn_backpr.Click += new System.EventHandler(this.btn_backpr_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::BTLLTTQ.Properties.Resources.Close;
            this.btn_close.Location = new System.Drawing.Point(672, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 41);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(190, 81);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(710, 488);
            this.panel_main.TabIndex = 2;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bar);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pMenu.ResumeLayout(false);
            this.panel_bar.ResumeLayout(false);
            this.panel_bar.PerformLayout();
            this.ResumeLayout(false);

        }

		private void btn_partner_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pd;
        private System.Windows.Forms.Button btn_lo;
        private System.Windows.Forms.Button btn_st;
        private System.Windows.Forms.Button btn_rp;
        private System.Windows.Forms.Button btn_partner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_backpr;
    }
}