﻿using BTLLTTQ.NhapVaBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.Menu
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNhap f1 = new FormNhap();
            f1.ShowDialog();
        }
    }
}
