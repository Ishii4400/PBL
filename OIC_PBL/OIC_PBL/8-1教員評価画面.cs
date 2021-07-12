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
    public partial class _8_1教員評価画面 : Form
    {
        public _8_1教員評価画面()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void _8_1教員評価画面_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            //7へ遷移
            var _7閲覧画面 = new _7閲覧画面();
            _7閲覧画面.Show();

            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //8-2へ遷移
            var _8_2評価確認画面 = new _8_2評価確認画面();
            _8_2評価確認画面.Show();

            this.Hide();
        }
    }
}
