namespace BTLLTTQ
{
    partial class FormMNN
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
            this.panelbar2 = new System.Windows.Forms.Panel();
            this.btn_miz = new System.Windows.Forms.Button();
            this.btn_maz = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.btn_pro = new FontAwesome.Sharp.IconButton();
            this.btn_ord = new FontAwesome.Sharp.IconButton();
            this.btn_rp = new FontAwesome.Sharp.IconButton();
            this.btn_stf = new FontAwesome.Sharp.IconButton();
            this.btn_cst = new FontAwesome.Sharp.IconButton();
            this.btn_log = new FontAwesome.Sharp.IconButton();
            this.panelbar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelbar2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbar2
            // 
            this.panelbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panelbar2.Controls.Add(this.btn_miz);
            this.panelbar2.Controls.Add(this.btn_maz);
            this.panelbar2.Controls.Add(this.btn_close);
            this.panelbar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbar2.Location = new System.Drawing.Point(0, 0);
            this.panelbar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelbar2.Name = "panelbar2";
            this.panelbar2.Size = new System.Drawing.Size(1184, 34);
            this.panelbar2.TabIndex = 0;
            this.panelbar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbar2_MouseDown);
            // 
            // btn_miz
            // 
            this.btn_miz.BackColor = System.Drawing.Color.Transparent;
            this.btn_miz.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_miz.FlatAppearance.BorderSize = 0;
            this.btn_miz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_miz.Image = global::BTLLTTQ.Properties.Resources.Horizontal_Line;
            this.btn_miz.Location = new System.Drawing.Point(1078, 0);
            this.btn_miz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_miz.Name = "btn_miz";
            this.btn_miz.Size = new System.Drawing.Size(32, 34);
            this.btn_miz.TabIndex = 4;
            this.btn_miz.UseVisualStyleBackColor = false;
            this.btn_miz.Click += new System.EventHandler(this.btn_miz_Click);
            // 
            // btn_maz
            // 
            this.btn_maz.BackColor = System.Drawing.Color.Transparent;
            this.btn_maz.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maz.FlatAppearance.BorderSize = 0;
            this.btn_maz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maz.Image = global::BTLLTTQ.Properties.Resources.Rounded_Square;
            this.btn_maz.Location = new System.Drawing.Point(1110, 0);
            this.btn_maz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_maz.Name = "btn_maz";
            this.btn_maz.Size = new System.Drawing.Size(37, 34);
            this.btn_maz.TabIndex = 3;
            this.btn_maz.UseVisualStyleBackColor = false;
            this.btn_maz.Click += new System.EventHandler(this.btn_maz_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::BTLLTTQ.Properties.Resources.Close;
            this.btn_close.Location = new System.Drawing.Point(1147, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 34);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btn_home);
            this.panelMenu.Controls.Add(this.btn_pro);
            this.panelMenu.Controls.Add(this.btn_ord);
            this.panelMenu.Controls.Add(this.btn_rp);
            this.panelMenu.Controls.Add(this.btn_stf);
            this.panelMenu.Controls.Add(this.btn_cst);
            this.panelMenu.Controls.Add(this.btn_log);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 885);
            this.panelMenu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 91);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTLLTTQ.Properties.Resources._395121130_657484653168360_1957556047445657044_n;
            this.pictureBox1.Location = new System.Drawing.Point(33, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_home.IconColor = System.Drawing.Color.White;
            this.btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(2, 97);
            this.btn_home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(172, 63);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Dashboard";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_pro
            // 
            this.btn_pro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pro.FlatAppearance.BorderSize = 0;
            this.btn_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro.ForeColor = System.Drawing.Color.White;
            this.btn_pro.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btn_pro.IconColor = System.Drawing.Color.White;
            this.btn_pro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_pro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pro.Location = new System.Drawing.Point(2, 164);
            this.btn_pro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.Size = new System.Drawing.Size(172, 63);
            this.btn_pro.TabIndex = 3;
            this.btn_pro.Text = "Products";
            this.btn_pro.UseVisualStyleBackColor = true;
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // btn_ord
            // 
            this.btn_ord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ord.FlatAppearance.BorderSize = 0;
            this.btn_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ord.ForeColor = System.Drawing.Color.White;
            this.btn_ord.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btn_ord.IconColor = System.Drawing.Color.White;
            this.btn_ord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ord.Location = new System.Drawing.Point(2, 231);
            this.btn_ord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ord.Name = "btn_ord";
            this.btn_ord.Size = new System.Drawing.Size(172, 63);
            this.btn_ord.TabIndex = 4;
            this.btn_ord.Text = "Orders";
            this.btn_ord.UseVisualStyleBackColor = true;
            this.btn_ord.Click += new System.EventHandler(this.btn_ord_Click);
            // 
            // btn_rp
            // 
            this.btn_rp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rp.FlatAppearance.BorderSize = 0;
            this.btn_rp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rp.ForeColor = System.Drawing.Color.White;
            this.btn_rp.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btn_rp.IconColor = System.Drawing.Color.White;
            this.btn_rp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rp.Location = new System.Drawing.Point(2, 298);
            this.btn_rp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rp.Name = "btn_rp";
            this.btn_rp.Size = new System.Drawing.Size(172, 63);
            this.btn_rp.TabIndex = 5;
            this.btn_rp.Text = "Report";
            this.btn_rp.UseVisualStyleBackColor = true;
            this.btn_rp.Click += new System.EventHandler(this.btn_rp_Click);
            // 
            // btn_stf
            // 
            this.btn_stf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stf.FlatAppearance.BorderSize = 0;
            this.btn_stf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stf.ForeColor = System.Drawing.Color.White;
            this.btn_stf.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btn_stf.IconColor = System.Drawing.Color.White;
            this.btn_stf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stf.Location = new System.Drawing.Point(2, 365);
            this.btn_stf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_stf.Name = "btn_stf";
            this.btn_stf.Size = new System.Drawing.Size(172, 63);
            this.btn_stf.TabIndex = 6;
            this.btn_stf.Text = "Staff";
            this.btn_stf.UseVisualStyleBackColor = true;
            this.btn_stf.Click += new System.EventHandler(this.btn_stf_Click);
            // 
            // btn_cst
            // 
            this.btn_cst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cst.FlatAppearance.BorderSize = 0;
            this.btn_cst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cst.ForeColor = System.Drawing.Color.White;
            this.btn_cst.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_cst.IconColor = System.Drawing.Color.White;
            this.btn_cst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cst.Location = new System.Drawing.Point(2, 432);
            this.btn_cst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cst.Name = "btn_cst";
            this.btn_cst.Size = new System.Drawing.Size(172, 63);
            this.btn_cst.TabIndex = 7;
            this.btn_cst.Text = "Customer";
            this.btn_cst.UseVisualStyleBackColor = true;
            this.btn_cst.Click += new System.EventHandler(this.btn_cst_Click);
            // 
            // btn_log
            // 
            this.btn_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.White;
            this.btn_log.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btn_log.IconColor = System.Drawing.Color.White;
            this.btn_log.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log.Location = new System.Drawing.Point(2, 499);
            this.btn_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(172, 63);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "LogOut";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // panelbar
            // 
            this.panelbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panelbar.Controls.Add(this.lblTitleChildForm);
            this.panelbar.Controls.Add(this.iconCurrentChildForm);
            this.panelbar.Controls.Add(this.panelbar2);
            this.panelbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbar.Location = new System.Drawing.Point(174, 0);
            this.panelbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelbar.Name = "panelbar";
            this.panelbar.Size = new System.Drawing.Size(1184, 70);
            this.panelbar.TabIndex = 2;
            this.panelbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 37);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(75, 26);
            this.lblTitleChildForm.TabIndex = 6;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 41;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 27);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(143, 41);
            this.iconCurrentChildForm.TabIndex = 5;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(174, 70);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1184, 815);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BTLLTTQ.Properties.Resources.Khabanh1140x761;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1184, 815);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 885);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelbar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMNN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMNN";
            this.Resize += new System.EventHandler(this.FormMNN_Resize);
            this.panelbar2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbar.ResumeLayout(false);
            this.panelbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbar2;
        private System.Windows.Forms.Button btn_miz;
        private System.Windows.Forms.Button btn_maz;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_pro;
        private FontAwesome.Sharp.IconButton btn_ord;
        private FontAwesome.Sharp.IconButton btn_rp;
        private FontAwesome.Sharp.IconButton btn_stf;
        private FontAwesome.Sharp.IconButton btn_cst;
        private FontAwesome.Sharp.IconButton btn_log;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelbar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}