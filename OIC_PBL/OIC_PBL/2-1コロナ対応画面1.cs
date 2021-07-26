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
    public partial class _2_1コロナ対応画面1 : Form
    {
        public _2_1コロナ対応画面1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _2_4コロナ対応画面2 f1 = new _2_4コロナ対応画面2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _2_5コロナ対応画面3 f2 = new _2_5コロナ対応画面3();
            f2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form1 f3 = new Form1();
            f3.Show();
        }
    }
}
