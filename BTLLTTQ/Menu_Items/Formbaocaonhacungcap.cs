using BTLLTTQ.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLTTQ.Menu_Items
{
    public partial class Formbaocaonhacungcap : Form
    {
        Sql db = new Sql();
        public Formbaocaonhacungcap()
        {
            InitializeComponent();
            DataTable dt = db.DocBang("Select * from nhacungcap");
            dataGridView1.DataSource = dt;
            dt.Dispose();//Giải phóng bộ nhớ cho DataTable
            db.ThemVaoComboBox("select mancc from nhacungcap", cmboncc);
            //db.ThemVaoComboBox("select mh from nhacungcap", cmbomh);
        }

        private void Formbaocaonhacungcap_Load(object sender, EventArgs e)
        {

        }
    }
}
