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
    public partial class DataUpdate : Form
    {
        public DataUpdate()
        {
            InitializeComponent();
            
                                       //short for team name;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            PlayerManage a = new PlayerManage();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.sql = "select Game_Played,Goal_num,Ass_num from Player where P_name='" + listView1.FocusedItem.SubItems[0].Text + "'and Tid='"+Inf.sftn+"'";
            cmd.CommandText = Inf.sql;
            Inf.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //Label17.Text=
            while (reader.Read())
              {
                  label17.Text = reader.GetValue(0).ToString();
                  label18.Text = reader.GetValue(1).ToString();
                  label19.Text = reader.GetValue(2).ToString();
            }
            reader.Close();
            Inf.conn.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            listView1.Items.Clear();
            switch (ComboBox1.Text) 
            {
                case "阿森纳": Inf.sftn = "ASN"; break;
                case "阿斯顿维拉":Inf.sftn="AVL"; break;
                case "卡迪夫城": Inf.sftn = "CAF"; break;
                case "切尔西": Inf.sftn = "CFC"; break;
                case "水晶宫": Inf.sftn = "CRY"; break;
                case "埃弗顿": Inf.sftn = "EVE"; break;
                case "富勒姆": Inf.sftn = "FUL"; break;
                case "胡尔城": Inf.sftn = "HUL"; break;
                case "利物浦": Inf.sftn = "LIV"; break;
                case "曼城": Inf.sftn = "MNC"; break;
                case "曼联": Inf.sftn = "MUN"; break;
                case "纽卡斯尔": Inf.sftn = "NCU"; break;
                case "诺维奇": Inf.sftn = "NWI"; break;
                case "南安普顿": Inf.sftn = "STN"; break;
                case "斯托克城":Inf.sftn="STO";break;
                case "桑德兰": Inf.sftn = "SUN"; break;
                case "斯旺西": Inf.sftn = "SWA"; break;
                case "热刺": Inf.sftn = "TOT"; break;
                case "西布朗": Inf.sftn = "WBA"; break;
                case "西汉姆联": Inf.sftn = "WHU"; break;
            };
            Inf.sql = "select P_name,Tid from Player where Tid='" + Inf.sftn + "'";
            cmd.CommandText = Inf.sql;
            SqlDataReader reader = cmd.ExecuteReader();
       
       
            while (reader.Read())
              {
                  ListViewItem lv = new ListViewItem();
                  lv.SubItems[0].Text = reader.GetValue(0).ToString();
                  lv.SubItems.Add(reader.GetValue(1).ToString());
                  listView1.Items.Add(lv);
               /* for (int i = 0; i < reader.FieldCount; i++)
               {
            
                    listView1.Items.Add(reader.GetValue(i).ToString());
                 
              }*/
               }
           

            reader.Close();
            Inf.conn.Close();
            //columnHeader2

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            int result1,result2,result3;
            if(int.TryParse(TextBox1.Text,out result1)==false||int.TryParse(TextBox2.Text,out result2)==false||int.TryParse(TextBox3.Text,out result3)==false)
               {
                      MessageBox.Show("请输入数字");
               }
                else
           {
                label17.Text = (Convert.ToInt32(label17.Text) + Convert.ToInt32(TextBox1.Text)).ToString();
                label18.Text = (Convert.ToInt32(label18.Text) + Convert.ToInt32(TextBox2.Text)).ToString();
                label19.Text = (Convert.ToInt32(label19.Text) + Convert.ToInt32(TextBox3.Text)).ToString();
                Inf.sql = "Update Player set Game_Played=" + Convert.ToInt32(label17.Text) + ",Goal_num=" + Convert.ToInt32(label18.Text) + ",Ass_num=" + Convert.ToInt32(label19.Text) + " where P_name='" + listView1.FocusedItem.SubItems[0].Text + "'and Tid='" + Inf.sftn + "'";
                cmd.CommandText = Inf.sql;
                cmd.ExecuteNonQuery();
                Inf.conn.Close();
                MessageBox.Show("上传成功!");
            }
            
        }
    }
}
