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
    public partial class _9詳細閲覧画面 : Form
    {
        public _9詳細閲覧画面()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //1へ遷移
            var form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //4へ遷移
            var メニュー画面 = new メニュー画面();
            メニュー画面.Show();

            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //6-1へ遷移
            var _6_1上長承認画面 = new _6_1上長承認画面();
            _6_1上長承認画面.Show();

            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //10-1へ遷移
            var _10_1編集画面 = new _10_1編集画面();
            _10_1編集画面.Show();

            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //7へ遷移
            var _7閲覧画面 = new _7閲覧画面();
            _7閲覧画面.Show();

            this.Hide();
        }
    }
}
