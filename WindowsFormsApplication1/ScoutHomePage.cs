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
    public partial class ScoutHomePage : Form
    {
        public ScoutHomePage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScoutSearch a = new ScoutSearch();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                string pna, ti;
                pna = listView1.FocusedItem.SubItems[0].Text;
                ti = listView1.FocusedItem.SubItems[1].Text;
                SqlCommand cmd = new SqlCommand("", Inf.conn);
                Inf.conn.Open();
                Inf.sql = "delete from Application where Sid='" + Inf.scout_id + "' and Pid=(select Pid from Player where P_name='" + pna + "' and Tid='" + ti + "')";
                cmd.CommandText = Inf.sql;
                cmd.ExecuteNonQuery();
                listView1.FocusedItem.Remove();
                MessageBox.Show("删除成功!");
                Inf.conn.Close();
            }
            else
            {
                MessageBox.Show("未选中行!");
            }


        }
    }
}
