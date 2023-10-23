using BTLLTTQ.Menu_Items;
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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Formbcdsspchokhachhang f = new Formbcdsspchokhachhang();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormTongtiennhaphangcuanv f = new FormTongtiennhaphangcuanv();
            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormTongTienbanhang f = new FormTongTienbanhang();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Formbaocaonhacungcap f = new Formbaocaonhacungcap();
            f.ShowDialog();
        }
    }
}
