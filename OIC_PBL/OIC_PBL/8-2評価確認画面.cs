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
    public partial class _8_2評価確認画面 : Form
    {
        public _8_2評価確認画面()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _8_2評価確認画面_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //8-1へ遷移（データ保持）
            var _8_1教員評価画面 = new _8_1教員評価画面();
            _8_1教員評価画面.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //7へ遷移
            var _7閲覧画面 = new _7閲覧画面();
            _7閲覧画面.Show();

            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
