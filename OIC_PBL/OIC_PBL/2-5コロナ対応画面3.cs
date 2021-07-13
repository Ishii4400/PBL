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
    public partial class _2_5コロナ対応画面3 : Form
    {
        public _2_5コロナ対応画面3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            _2_4コロナ対応画面2 f1 = new _2_4コロナ対応画面2();
            f1.Show();

        }
}
}
