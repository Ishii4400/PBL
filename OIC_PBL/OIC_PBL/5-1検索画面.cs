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
            this.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _5_1検索画面_Load(object sender, EventArgs e)
        {
           

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
