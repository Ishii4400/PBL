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
    public partial class _6_1上長承認画面 : Form
    {
        public _6_1上長承認画面()
        {
            InitializeComponent();

            //フルスクリーン
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TOP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();

            this.Hide();
        }

        private void メニュー_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var メニュー画面 = new メニュー画面();
            メニュー画面.Show();

            this.Hide();
        }

        private void 詳細閲覧_Click(object sender, EventArgs e)
        {
            var _9詳細閲覧画面 = new _9詳細閲覧画面();
            _9詳細閲覧画面.Show();

            this.Hide();
        }

        private void 否認_Click(object sender, EventArgs e)
        {
            var _6_2承認確認画面 = new _6_2承認確認画面();
            _6_2承認確認画面.Show();

            this.Hide();
        }

        private void 承認_Click(object sender, EventArgs e)
        {
            var _6_2承認確認画面 = new _6_2承認確認画面();
            _6_2承認確認画面.Show();

            this.Hide();
        }

        private void _6_1上長承認画面_Load(object sender, EventArgs e)
        {

        }
    }
}
