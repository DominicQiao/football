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
    public partial class SMSearch2 : Form
    {
        public SMSearch2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Inf.conn.Open();
            Inf.sql = "select Pid from Player";
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            cmd.CommandText = Inf.sql;
            if (TextBox1.Text != "")
            {
                Inf.sql = "select Pid from Player where P_name='" + TextBox1.Text + "'";
                cmd.CommandText = cmd.CommandText + "\n intersect \n" + Inf.sql;
            }

            if (ComboBox1.SelectedIndex != -1)
            {
                string sftn = "";
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
                Inf.sql = "select Pid from Player where Tid='" + sftn + "'";
                cmd.CommandText = cmd.CommandText + "\n intersect \n" + Inf.sql;
            }
            if (ComboBox2.SelectedIndex != -1)
            {
                switch (ComboBox2.Text)
                {
                    case "15-19":
                        Inf.sql = "select Pid from Player where Birth_Year>=1995 and Birth_Year<=1999";
                        break;
                    case "20-24":
                        Inf.sql = "select Pid from Player where Birth_Year>=1990 and Birth_Year<=1994";
                        break;
                    case "25-29":
                        Inf.sql = "select Pid from Player where Birth_Year>=1985 and Birth_Year<=1989";
                        break;
                    case "30-34":
                        Inf.sql = "select Pid from Player where Birth_Year>=1980 and Birth_Year<=1984";
                        break;
                    case "35及以上":
                        Inf.sql = "select Pid from Player where Birth_Year<=1983";
                        break;
                }
                cmd.CommandText = cmd.CommandText + "\n intersect \n" + Inf.sql;
            }
            if (ComboBox3.SelectedIndex != -1)
            {
                Inf.sql = "select Pid from Player where Position='" + ComboBox3.Text + "'";
                cmd.CommandText = cmd.CommandText + "\n intersect \n" + Inf.sql;
            }

            SqlDataReader reader = cmd.ExecuteReader();
            Inf.n = 0;
            Inf.id = new string[1000];
            while (reader.Read())
            {
                Inf.id[Inf.n++] = reader.GetValue(0).ToString();
                //MessageBox.Show(Inf.id[Inf.n-1]);
            }
            reader.Close();

            this.Visible = false;
            PlayerOut a = new PlayerOut();
            int i = 0;
            string str = "";
            SqlDataReader reader1;
            while (i <= Inf.n)
            {
                str = Inf.id[i];
                Inf.sql = "select P_name,Tid,Birth_year from Player where Pid='" + str + "'";
                //MessageBox.Show(str);
                cmd.CommandText = Inf.sql;
                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    ListViewItem lv = new ListViewItem();
                    lv.SubItems[0].Text = reader1.GetValue(0).ToString();
                    lv.SubItems.Add(reader1.GetValue(1).ToString());
                    string str1 = reader1.GetValue(2).ToString();
                    int c;
                    c = int.Parse(str1);
                    c = 2014 - c;
                    lv.SubItems.Add(c.ToString());
                    a.listView1.Items.Add(lv);
                    //MessageBox.Show("1");

                }
                //MessageBox.Show("2");
                i++;
                //MessageBox.Show(i + " " + Inf.n);
                reader1.Close();
            }

            //MessageBox.Show("s");
            Inf.conn.Close();
            a.Show();
            
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlayerManage a = new PlayerManage();
            a.Show();
        }
    }
}
