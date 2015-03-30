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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
         
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScoutSearch a = new ScoutSearch();
            a.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pid="";
            Inf.conn.Open();
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.sql = "select Pid from Player where P_name='" + listView1.FocusedItem.SubItems[0].Text + "'and Tid='" + listView1.FocusedItem.SubItems[1].Text + "'";
            cmd.CommandText=Inf.sql;
            pid = cmd.ExecuteScalar().ToString();
            string s1 = "select Pid from Application where Sid='" + Inf.scout_id + "'and Pid='"+pid+"'";
            cmd.CommandText = s1;
            if (null == cmd.ExecuteScalar())
            {
                //MessageBox.Show(Inf.scout_id + "','" + pid);
                Inf.sql = "insert into Application values('" + Inf.scout_id + "','" + pid + "')";
                cmd.CommandText = Inf.sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("申请成功!");
                Inf.conn.Close();
            }
            else
            {
                MessageBox.Show("你已提交对该球员的申请!");
                Inf.conn.Close();
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inf.conn.Open();
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.sql = "select Game_Played,Goal_num,Ass_num from Player where P_name='" + listView1.FocusedItem.SubItems[0].Text + "'";
            cmd.CommandText = Inf.sql;
            

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label17.Text = reader.GetValue(0).ToString();
                label18.Text = reader.GetValue(1).ToString();
                label19.Text = reader.GetValue(2).ToString();
            }
            reader.Close();
            Inf.conn.Close();
            
        }
    }
}
