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
    public partial class _6_2承認確認画面 : Form
    {
        public _6_2承認確認画面()
        {
            InitializeComponent();
        }

        private void 編集_Click(object sender, EventArgs e)
        {
            var _6_1上長承認画面 = new _6_1上長承認画面();
            _6_1上長承認画面.Show();

            this.Hide();
        }

        private void 確定_Click(object sender, EventArgs e)
        {
            var _6_1上長承認画面 = new _6_1上長承認画面();
            _6_1上長承認画面.Show();

            this.Hide();
        }
    }
}
