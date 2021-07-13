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
    public partial class _3_2参加者確認画面 : Form
    {
        public _3_2参加者確認画面()
        {
            InitializeComponent();
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
            _3_3教員確認画面 f2 = new _3_3教員確認画面();
            f2.Show();
        }
    }
}
