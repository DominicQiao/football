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
    public partial class PlayerIn : Form
    {
        public PlayerIn()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
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
            string S = "select MAX(Pid) from Player";
            cmd.CommandText = S;
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            string a = ds.Rows[0][0].ToString();
            a = a.Substring(a.Length - 3);
            int a1 = int.Parse(a);
            a1++;
            string a2 = a1.ToString();
            string a3 = "P";
            a2 = a3 + a2;
            string age = textBox3.Text;
            int birth = 2014 - int.Parse(age);
            string sql = "Insert into Player Values('" + a2 + "','" + TextBox1.Text + "','" + ComboBox3.Text + "', 0 ,0,0,'" + birth + "',0,0,0,0,'" + sftn + "')";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("添加成功！");
            this.Visible = false;
            PlayerIn b = new PlayerIn();
            b.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlayerManage a = new PlayerManage();
            a.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
