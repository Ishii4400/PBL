﻿using System;
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
    public partial class _10_2編集確認画面 : Form
    {
        public _10_2編集確認画面()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10-1へ遷移
            var _10_1編集画面 = new _10_1編集画面();
            _10_1編集画面.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //9へ遷移
            var _9詳細閲覧画面 = new _9詳細閲覧画面();
            _9詳細閲覧画面.Show();

            this.Hide();
        }

        private void _10_2編集確認画面_Load(object sender, EventArgs e)
        {

        }
    }
}
