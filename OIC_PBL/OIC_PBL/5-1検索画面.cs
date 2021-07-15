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
    public partial class _5_1検索画面 : Form
    {
        public _5_1検索画面()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _5_1検索画面_Load(object sender, EventArgs e)
        {
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ItemHeight = 30;
            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.ItemHeight = 30;
            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox3.ItemHeight = 30;
            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox4.ItemHeight = 30;
            comboBox4.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox4.ItemHeight = 30;
            comboBox5.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox5.ItemHeight = 30;
            comboBox6.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox6.ItemHeight = 30;

        }

        private void 検索_Click(object sender, EventArgs e)
        {

            var _7閲覧画面 = new _7閲覧画面();
            _7閲覧画面.Show();

            this.Hide();
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

        private void 本日の参加人数_Click(object sender, EventArgs e)
        {

            var _5_2参加人数集計表 = new _5_2参加人数集計表();
            _5_2参加人数集計表.Show();

            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 入学金免除対象者checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
