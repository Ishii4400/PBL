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
    public partial class _3_4受付番号表示画面 : Form
    {
        public _3_4受付番号表示画面()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //2-1へ遷移
            var _2_1コロナ対応画面1 = new _2_1コロナ対応画面1();
            _2_1コロナ対応画面1.Show();

            this.Hide();
        }

        private void _3_4受付番号表示画面_Load(object sender, EventArgs e)
        {
            //オートインクリメント
            int num = 1;
            this.textBox1.Text = String.Format("{0:D3}", num);
        }
    }
}
