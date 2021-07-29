using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            入試免除対象者checkBox.Width = 33;
            入試免除対象者checkBox.Height = 33;

            入学金免除対象者checkBox.Width = 33;
            入学金免除対象者checkBox.Height = 33;

            var source = new AutoCompleteStringCollection();

            string constr = @"Data Source=LAPTOP-JG8J4QGP\SQLEXPRESS ;Initial Catalog=test;Connect Timeout=60;Persist Security Info=True;User ID=sa;Password=1111";

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                string sqlstr = "use PBLDB;" +
                    "select 学校名 from school_master";
                SqlCommand com = new SqlCommand(sqlstr, con);
                SqlDataReader sdr = com.ExecuteReader();

                while (sdr.Read() == true)
                {
                    string school_name = (string)sdr["学校名"];
                    source.AddRange(new string[] { string.Format("{0},", school_name.Trim()) });
                }
                sdr.Close();
                com.Dispose();
            }
            finally
            {
                con.Close();
            }

            comboBox7.AutoCompleteCustomSource = source;
            comboBox7.AutoCompleteMode =
                                  AutoCompleteMode.SuggestAppend;
            comboBox7.AutoCompleteSource =
                                  AutoCompleteSource.CustomSource;

            SqlConnection con1 = new SqlConnection(constr);
            con1.Open();
            try
            {
                string sqlstr1 = "use PBLDB;" +
                    "select 学科名 from dep_master";
                SqlCommand com1 = new SqlCommand(sqlstr1, con1);
                SqlDataReader sdr1 = com1.ExecuteReader();

                while (sdr1.Read() == true)
                {
                    string dep_name = (string)sdr1["学科名"];
                    comboBox3.Items.Add(string.Format("{0}", dep_name.Trim()));
                }
                sdr1.Close();
                com1.Dispose();
            }
            finally
            {
                con1.Close();
            }
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox3.SelectedIndex = 0;

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
