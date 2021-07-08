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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

       
    }
}
