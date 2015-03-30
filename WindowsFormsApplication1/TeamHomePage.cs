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
    public partial class TeamHomePage : Form
    {
        public TeamHomePage()
        {
            InitializeComponent();
            if (Inf.boss_id == "ASN001")
                PictureBox1.Image = Image.FromFile("ASN.png");
            if (Inf.boss_id == "AVL001")
                PictureBox1.Image = Image.FromFile("AVL.jpg");
            if (Inf.boss_id == "CAF001")
                PictureBox1.Image = Image.FromFile("CAF.jpg");
            if (Inf.boss_id == "CFC001")
                PictureBox1.Image = Image.FromFile("CFC.jpg");
            if (Inf.boss_id == "CRY001")
                PictureBox1.Image = Image.FromFile("CRY.jpg");
            if (Inf.boss_id == "EVE001")
                PictureBox1.Image = Image.FromFile("EVE.jpg");
            if (Inf.boss_id == "FUL001")
                PictureBox1.Image = Image.FromFile("FUL.jpg");
            if (Inf.boss_id == "HUL001")
                PictureBox1.Image = Image.FromFile("HUL.jpg");
            if (Inf.boss_id == "LIV001")
                PictureBox1.Image = Image.FromFile("LIV.jpg");
            if (Inf.boss_id == "MNC001")
                PictureBox1.Image = Image.FromFile("MNC.jpg");
            if (Inf.boss_id == "MUN001")
                PictureBox1.Image = Image.FromFile("MUN.jpg");
            if (Inf.boss_id == "NCU001")
                PictureBox1.Image = Image.FromFile("NCU.jpg");
            if (Inf.boss_id == "NWI001")
                PictureBox1.Image = Image.FromFile("NWI.jpg");
            if (Inf.boss_id == "STN001")
                PictureBox1.Image = Image.FromFile("STN.jpg");
            if (Inf.boss_id == "STO001")
                PictureBox1.Image = Image.FromFile("STO.jpg");
            if (Inf.boss_id == "SUN001")
                PictureBox1.Image = Image.FromFile("SUN.jpg");
            if (Inf.boss_id == "SWA001")
                PictureBox1.Image = Image.FromFile("SWA.jpg");
            if (Inf.boss_id == "TOT001")
                PictureBox1.Image = Image.FromFile("TOT.jpg");
            if (Inf.boss_id == "WBA001")
                PictureBox1.Image = Image.FromFile("WBA.jpg");
            if (Inf.boss_id == "WHU001")
                PictureBox1.Image = Image.FromFile("WHU.jpg");
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            ScoutsApply a = new ScoutsApply();
            SqlCommand cmd = new SqlCommand("", Inf.conn);
            Inf.conn.Open();
            Inf.sql = "select Scout.S_name,Player.P_name,Player.Tid from Boss,Player,Application,Scout where Boss.Bid='"+Inf.boss_id+"'and Boss.Tid=Scout.Tid and Scout.Sid=Application.Sid and Application.Pid=Player.Pid";
            cmd.CommandText = Inf.sql;
            SqlDataReader reader =cmd.ExecuteReader();
            

            while(reader.Read())
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScoutManage a = new ScoutManage();
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Integrated Security=True");
            conn.Open();
            SqlCommand com = new SqlCommand();

            com.CommandText = "select Scout.S_name from Scout , Boss where Scout.Tid=Boss.Tid and Boss.Bid='" + Inf.boss_id + "'";
            com.CommandType = CommandType.Text;
            com.Connection = conn;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.SubItems[0].Text = reader.GetValue(0).ToString();

                a.listView1.Items.Add(lv);
            }
            conn.Close();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangeTeamCode a = new ChangeTeamCode();
            a.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                string sn,pna, ti;
                sn=listView1.FocusedItem.SubItems[0].Text;
                pna = listView1.FocusedItem.SubItems[1].Text;
                ti = listView1.FocusedItem.SubItems[2].Text;
                SqlCommand cmd = new SqlCommand("", Inf.conn);
                Inf.conn.Open();
                Inf.sql = "delete from CommitApp where Sid=(select Sid from Scout where S_name='" + sn + "') and Pid=(select Pid from Player where P_name='" + pna + "' and Tid='" + ti + "')";
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
