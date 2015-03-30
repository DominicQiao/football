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
    public partial class ChangeTeamCode : Form
    {
        public ChangeTeamCode()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TeamHomePage a = new TeamHomePage();
            a.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Inf.conn.Open();
            Inf.sql = "select B_key from Boss where Bid='" + Inf.boss_id + "'";
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            cmd.CommandText = Inf.sql;
            if (TextBox1.Text == (string)cmd.ExecuteScalar())
            {
                if (TextBox2.Text.Length >= 6)
                {
                    if (TextBox2.Text == TextBox4.Text)
                    {
                        Inf.sql = "UPDATE Boss set B_key='" + TextBox2.Text + "' where Bid='" + Inf.boss_id + "'";
                        cmd.CommandText = Inf.sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功!");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("新密码不一致!");
                    }
                }
                else
                {
                    MessageBox.Show("密码长度过短!");
                }
            }
            else 
            {
                MessageBox.Show("球队密码错误!");
            }
            Inf.conn.Close();  
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
