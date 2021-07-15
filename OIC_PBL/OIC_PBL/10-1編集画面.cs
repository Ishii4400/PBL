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
    public partial class _10_1編集画面 : Form
    {
        public _10_1編集画面()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        private void button4_Click(object sender, EventArgs e)
        {
            //6-1へ遷移
            var _6_1上長承認画面 = new _6_1上長承認画面();
            _6_1上長承認画面.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //8-1へ遷移（データ保持）
            var _8_1教員評価画面 = new _8_1教員評価画面();
            _8_1教員評価画面.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //9へ遷移
            var _9詳細閲覧画面 = new _9詳細閲覧画面();
            _9詳細閲覧画面.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //10-2へ遷移
            var _10_2編集確認画面 = new _10_2編集確認画面();
            _10_2編集確認画面.Show();

            this.Hide();
        }

        private void _10_1編集画面_Load(object sender, EventArgs e)
        {
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ItemHeight=30;

            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.ItemHeight = 30;

            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox3.ItemHeight = 30;
        }
    }
}
