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
    public partial class _3_1受付画面 : Form
    {
        public _3_1受付画面()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _3_2参加者確認画面 f1 = new _3_2参加者確認画面();
            f1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form1 f2 = new Form1();
            f2.Show();
        }

         private void _3_1受付画面_Load(object sender, EventArgs e)
        {
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ItemHeight = 30;

            comboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox2.ItemHeight = 30;

            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox3.ItemHeight = 30;

            comboBox4.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox4.ItemHeight = 30;
        }
    }
}
