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
    public partial class ScoutsApply : Form
    {
        public ScoutsApply()
        {
            InitializeComponent();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "select Application.Sid,Application.Pid from Application,Scout,Boss,Player where Boss.Bid='" + Inf.boss_id + "'and Boss.Tid=Scout.Tid and Scout.Sid=Application.Sid and Scout.S_name='" + listView1.FocusedItem.SubItems[0].Text + "' and Player.Pid=Application.Pid and Player.P_name='" + listView1.FocusedItem.SubItems[1].Text + "'and Player.Tid='" + listView1.FocusedItem.SubItems[2].Text + "'";
            cmd.CommandText = Inf.sql;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Inf.c_a = reader.GetValue(0).ToString();
            Inf.c_p = reader.GetValue(1).ToString();
            reader.Close();
            Inf.conn.Close();
           */

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                string sn, pna, ti;
                sn = listView1.FocusedItem.SubItems[0].Text;
                pna = listView1.FocusedItem.SubItems[1].Text;
                ti = listView1.FocusedItem.SubItems[2].Text;
                SqlCommand cmd = new SqlCommand("", Inf.conn);
                Inf.conn.Open();
                Inf.sql = "delete from Application where Sid=(select Sid from Scout where S_name='" + sn + "')and Pid=(select Pid from Player where P_name='" + pna + "' and Tid='" + ti + "')";
                cmd.CommandText = Inf.sql;
                cmd.ExecuteNonQuery();
                Inf.sql = "insert into CommitApp select Scout.Sid,Player.Pid from Scout,Player where Scout.S_name='" + sn + "'and Player.P_name='" + pna + "' and Player.Tid='" + ti + "'";
                cmd.CommandText = Inf.sql;
                cmd.ExecuteNonQuery();
                listView1.FocusedItem.Remove();
                MessageBox.Show("成功批准!");
                Inf.conn.Close();
            }
            else 
            {
                MessageBox.Show("未选中行!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
             if (listView1.FocusedItem != null)
            {
            string sn, pna, ti;
            sn = listView1.FocusedItem.SubItems[0].Text;
            pna = listView1.FocusedItem.SubItems[1].Text;
            ti = listView1.FocusedItem.SubItems[2].Text;
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "delete from Application where Sid=(select Sid from Scout where S_name='" + sn + "')and Pid=(select Pid from Player where P_name='" + pna + "' and Tid='" + ti + "')";
            cmd.CommandText = Inf.sql;
            cmd.ExecuteNonQuery();
            listView1.FocusedItem.Remove();
            MessageBox.Show("成功删除!");
            Inf.conn.Close();
            }
             else
             {
                 MessageBox.Show("未选中行!");
             }
        }
    }
}
