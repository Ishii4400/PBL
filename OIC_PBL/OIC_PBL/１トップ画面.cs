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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _2_1コロナ対応画面1 f1 = new _2_1コロナ対応画面1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            メニュー画面 f2 = new メニュー画面();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
