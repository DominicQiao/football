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
    public partial class PlayerOut : Form
    {
        public PlayerOut()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SMSearch2 a = new SMSearch2();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "select Pid from Player where P_name='" + listView1.FocusedItem.SubItems[0].Text + "' and Tid='" + listView1.FocusedItem.SubItems[1].Text + "'";
            cmd.CommandText = Inf.sql;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Inf.s = reader.GetValue(0).ToString();
            //MessageBox.Show(Inf.s);
            reader.Close();
            Inf.conn.Close();
        }

        private void PlayerOut_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "delete from Player where Pid='" + Inf.s + "'";
            cmd.CommandText = Inf.sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("成功退役!");
            Inf.conn.Close();
        }
    }
}
