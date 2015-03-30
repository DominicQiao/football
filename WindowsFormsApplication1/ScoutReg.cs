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

namespace WindowsFormsApplication1
{
    public partial class ScoutReg : Form
    {
        public ScoutReg()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn a = new LogIn();
            a.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
             string sftn="";                           //short for team name;
            switch (ComboBox1.Text)
            {
                case "阿森纳": sftn = "ASN"; break;
                case "阿斯顿维拉": sftn = "AVL"; break;
                case "卡迪夫城": sftn = "CAF"; break;
                case "切尔西": sftn = "CFC"; break;
                case "水晶宫": sftn = "CRY"; break;
                case "埃弗顿": sftn = "EVE"; break;
                case "富勒姆": sftn = "FUL"; break;
                case "胡尔城": sftn = "HUL"; break;
                case "利物浦": sftn = "LIV"; break;
                case "曼城": sftn = "MNC"; break;
                case "曼联": sftn = "MUN"; break;
                case "纽卡斯尔": sftn = "NCU"; break;
                case "诺维奇": sftn = "NWI"; break;
                case "南安普顿": sftn = "STN"; break;
                case "斯托克城": sftn = "STO"; break;
                case "桑德兰": sftn = "SUN"; break;
                case "斯旺西": sftn = "SWA"; break;
                case "热刺": sftn = "TOT"; break;
                case "西布朗": sftn = "WBA"; break;
                case "西汉姆联": sftn = "WHU"; break;
            }

            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            string s1 = "select Sid from Scout where Sid='" + TextBox1.Text + "'";
            cmd.CommandText = s1;
            if (null == cmd.ExecuteScalar())
            {
                string s = "select B_Key from Boss where Tid='" + sftn + "'";
                cmd.CommandText = s;
                DataTable ds = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                string a = ds.Rows[0][0].ToString();

                if (a == textBox5.Text)
                {
                    if(TextBox3.Text.Length>=6)
                    {
                    if (TextBox3.Text == TextBox4.Text)
                    {
                        string sql = "Insert into Scout Values('" + TextBox1.Text + "','" + sftn + "','" + TextBox2.Text + "','" + TextBox4.Text + "')";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("注册成功！");
                        this.Visible = false;
                        LogIn x = new LogIn();
                        x.Show();
                    }
                    else
                        MessageBox.Show("密码输入不一致");
                    }
                    else
                        MessageBox.Show("密码太简单！");
                }
                else
                    MessageBox.Show("球队密码错误");
            }
            else
                MessageBox.Show("账号已存在!");
               
                conn.Close();
        }
        }
    }

