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
    public partial class _2_3交通費確認画面2 : Form
    {
        public _2_3交通費確認画面2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _2_2交通費確認画面1 f1 = new _2_2交通費確認画面1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_4コロナ対応画面2 f1 = new _2_4コロナ対応画面2();
            f1.Show();
        }
    }
}
