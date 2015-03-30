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
    public partial class LogIn : Form
    {
        public LogIn()
        {

            InitializeComponent();
        

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScoutReg a=new ScoutReg();
            a.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void 登陆_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("", conn);
            string sql = "select Bid from Boss where Bid='" + TextBox1.Text.Trim() + "' and B_password='" + TextBox2.Text.Trim() + "'";
            cmd.CommandText = sql;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                sql = "select Bid from Boss where Bid='" + TextBox1.Text.Trim() + "' and B_password='" + TextBox2.Text.Trim() + "'";
                cmd.CommandText = sql;
                if (null != cmd.ExecuteScalar())
                {
                    this.Visible = false;
                    TeamHomePage a = new TeamHomePage();
                    Inf.boss_id = TextBox1.Text;
                    a.Show();
                    if (Inf.boss_id == "ASN001")
                        a.PictureBox1.Image = Image.FromFile("ASN.png");
                    if (Inf.boss_id == "AVL001")
                        a.PictureBox1.Image = Image.FromFile("AVL.jpg");
                    if (Inf.boss_id == "CAF001")
                        a.PictureBox1.Image = Image.FromFile("CAF.jpg");
                    if (Inf.boss_id == "CFC001")
                        a.PictureBox1.Image = Image.FromFile("CFC.jpg");
                    if (Inf.boss_id == "CRY001")
                        a.PictureBox1.Image = Image.FromFile("CRY.jpg");
                    if (Inf.boss_id == "EVE001")
                        a.PictureBox1.Image = Image.FromFile("EVE.jpg");
                    if (Inf.boss_id == "FUL001")
                        a.PictureBox1.Image = Image.FromFile("FUL.jpg");
                    if (Inf.boss_id == "HUL001")
                        a.PictureBox1.Image = Image.FromFile("HUL.jpg");
                    if (Inf.boss_id == "LIV001")
                        a.PictureBox1.Image = Image.FromFile("LIV.jpg");
                    if (Inf.boss_id == "MNC001")
                        a.PictureBox1.Image = Image.FromFile("MNC.jpg");
                    if (Inf.boss_id == "MUN001")
                        a.PictureBox1.Image = Image.FromFile("MUN.jpg");
                    if (Inf.boss_id == "NCU001")
                        a.PictureBox1.Image = Image.FromFile("NCU.jpg");
                    if (Inf.boss_id == "NWI001")
                        a.PictureBox1.Image = Image.FromFile("NWI.jpg");
                    if (Inf.boss_id == "STN001")
                        a.PictureBox1.Image = Image.FromFile("STN.jpg");
                    if (Inf.boss_id == "STO001")
                        a.PictureBox1.Image = Image.FromFile("STO.jpg");
                    if (Inf.boss_id == "SUN001")
                        a.PictureBox1.Image = Image.FromFile("SUN.jpg");
                    if (Inf.boss_id == "SWA001")
                        a.PictureBox1.Image = Image.FromFile("SWA.jpg");
                    if (Inf.boss_id == "TOT001")
                        a.PictureBox1.Image = Image.FromFile("TOT.jpg");
                    if (Inf.boss_id == "WBA001")
                        a.PictureBox1.Image = Image.FromFile("WBA.jpg");
                    if (Inf.boss_id == "WHU001")
                        a.PictureBox1.Image = Image.FromFile("WHU.jpg");
                    //MessageBox.Show(Inf.scout_id);
                 
                    Inf.conn.Open();
                    Inf.sql = "select Scout.S_name,Player.P_name,Player.Tid from Boss,Player,CommitApp,Scout where Boss.Bid='" + Inf.boss_id + "'and Boss.Tid=Scout.Tid and Scout.Sid=CommitApp.Sid and CommitApp.Pid=Player.Pid";
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
                    }

                
                else
                {
                    MessageBox.Show("帐号或密码错误！");
                }

            }
           
            if (checkBox2.CheckState == CheckState.Checked)
            {
                sql = "select Sid from Scout where Sid='" + TextBox1.Text.Trim() + "' and S_password='" + TextBox2.Text.Trim() + "'";
                cmd.CommandText = sql;
                if (null != cmd.ExecuteScalar())
                {
                    this.Visible = false;
                    ScoutHomePage a = new ScoutHomePage();
                    Inf.scout_id = TextBox1.Text;
                    //MessageBox.Show(Inf.scout_id);
                    Inf.sql = "select Player.P_name,Player.Tid from Player,Application,Scout where Scout.Sid='"+Inf.scout_id+"' and Scout.Sid=Application.Sid and Application.Pid=Player.Pid";
                    cmd.CommandText = Inf.sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem();
                        lv.SubItems[0].Text = reader.GetValue(0).ToString();
                        lv.SubItems.Add(reader.GetValue(1).ToString());
                        //MessageBox.Show(reader.GetValue(0).ToString());
                        a.listView1.Items.Add(lv);
                    }
                    
                    a.Show();
           


                }
                else
                {
                    MessageBox.Show("帐号或密码错误！");
                }
           
            }
        
            if (checkBox3.CheckState == CheckState.Checked)
            {
                sql = "select Super_id from SuperManager where Super_id='" + TextBox1.Text.Trim() + "' and Password='" + TextBox2.Text.Trim() + "'";
                cmd.CommandText = sql;
                if (null != cmd.ExecuteScalar())
                {
                    this.Visible = false;
                    PlayerManage a = new PlayerManage();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("帐号或密码错误！");
                }
       
            }
         

            if (checkBox1.CheckState != CheckState.Checked && checkBox2.CheckState != CheckState.Checked && checkBox3.CheckState != CheckState.Checked)
            {
                MessageBox.Show("未选择身份!","错误");
            }
             conn.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
