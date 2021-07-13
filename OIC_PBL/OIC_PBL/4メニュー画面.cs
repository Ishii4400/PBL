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
    public partial class メニュー画面 : Form
    {
        public メニュー画面()
        {
            InitializeComponent();

        }

        private void メニュー画面_Load(object sender, EventArgs e)
        {
           
        }

        

        private void 一般教員用_Click(object sender, EventArgs e)
        {
            var _5_1検索画面 = new _5_1検索画面();
            _5_1検索画面.Show();

            this.Hide();
        }

        private void TOP_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void 上長用_Click(object sender, EventArgs e)
        {
            var _6_1上長承認画面 = new _6_1上長承認画面();
            _6_1上長承認画面.Show();

            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
