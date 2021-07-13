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
    public partial class _5_2参加人数集計表 : Form
    {
        public _5_2参加人数集計表()
        {
            InitializeComponent();

            //フルスクリーン
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void 戻る_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _5_1検索画面 = new _5_1検索画面();
            _5_1検索画面.Show();

            this.Hide();
        }

        private void _5_2参加人数集計表_Load(object sender, EventArgs e)
        {

        }
    }
}
