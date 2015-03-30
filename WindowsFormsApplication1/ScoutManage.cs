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
    public partial class ScoutManage : Form
    {
        public ScoutManage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string a;
            if (listView1.SelectedIndices.Count == 0)
                MessageBox.Show("请先选中一个球探");
            else
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    ListView.SelectedIndexCollection c = listView1.SelectedIndices;
                    a = listView1.Items[c[0]].Text;
                    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("", conn);
                    string sql = "delete from Scout where S_name='" + a + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("开除成功");
                    int Index = 0;
                    Index = this.listView1.SelectedItems[0].Index;
                    listView1.Items[Index].Remove();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TeamHomePage a = new TeamHomePage();

            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "select Scout.S_name,Player.P_name,Player.Tid from Boss,Player,CommitApp,Scout where Boss.Bid='" + Inf.boss_id + "'and Boss.Tid=Scout.Tid and Scout.Sid=CommitApp.Sid and CommitApp.Pid=Player.Pid";
            cmd.CommandText = Inf.sql;
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.SubItems[0].Text = reader.GetValue(0).ToString();
                lv.SubItems.Add(reader.GetValue(1).ToString());
                lv.SubItems.Add(reader.GetValue(2).ToString());
                a.listView1.Items.Add(lv);
            }
            Inf.conn.Close();
            reader.Close();

            a.Show();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
