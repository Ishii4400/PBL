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
    public partial class _3_1受付画面 : Form
    {
        public _3_1受付画面()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ItemHeight = 30;
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

        }

        private void _3_1受付画面_Load_1(object sender, EventArgs e)
        {
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.ItemHeight = 30;

            
            var source = new AutoCompleteStringCollection();

            string constr = @"Data Source=LAPTOP-4CBL2ODE\SQLEXPRESS;Initial Catalog=test;Connect Timeout=60;Persist Security Info=True;User ID=sa;Password=saPassword";

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                string sqlstr = "use OIC;" +
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

            comboBox5.AutoCompleteCustomSource = source;
            comboBox5.AutoCompleteMode =
                                  AutoCompleteMode.SuggestAppend;
            comboBox5.AutoCompleteSource =
                                  AutoCompleteSource.CustomSource;

            SqlConnection con1 = new SqlConnection(constr);
            con1.Open();
            try
            {
                string sqlstr1 = "use OIC;" +
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
    }
}
