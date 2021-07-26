using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIC_PBL
{
    public partial class _3_3教員確認画面 : Form
    {
        public _3_3教員確認画面()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _3_1受付画面 f1 = new _3_1受付画面();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _2_1コロナ対応画面1 f2 = new _2_1コロナ対応画面1();
            f2.Show();
        }
    }
}
