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
    public partial class _7閲覧画面 : Form
    {
        public _7閲覧画面()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void TOP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void メニュー_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var メニュー画面 = new メニュー画面();
            メニュー画面.Show();

            this.Hide();
        }

        private void 編集_Click(object sender, EventArgs e)
        {
            var _10_1編集画面 = new _10_1編集画面();
            _10_1編集画面.Show();

            this.Hide();
        }

        private void 詳細閲覧_Click(object sender, EventArgs e)
        {
            var _9詳細閲覧画面 = new _9詳細閲覧画面();
            _9詳細閲覧画面.Show();

            this.Hide();
        }

        private void 評価入力_Click(object sender, EventArgs e)
        {
            var _8_1教員評価画面 = new _8_1教員評価画面();
            _8_1教員評価画面.Show();

            this.Hide();
        }

        private void エクスポート_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var _5_1検索画面 = new _5_1検索画面();
            _5_1検索画面.Show();

            this.Hide();
        }
    }
}
