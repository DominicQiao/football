namespace WindowsFormsApplication1
{
    partial class ScoutSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ComboBox6 = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.ComboBox4 = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.足球经理 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button2.Location = new System.Drawing.Point(474, 480);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 28);
            this.Button2.TabIndex = 71;
            this.Button2.Text = "取消";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button1.Location = new System.Drawing.Point(335, 480);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 28);
            this.Button1.TabIndex = 70;
            this.Button1.Text = "查找";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ComboBox6
            // 
            this.ComboBox6.FormattingEnabled = true;
            this.ComboBox6.Items.AddRange(new object[] {
            "0-5",
            "6-10",
            "11-15",
            "16-20",
            "21-25",
            "26-30",
            "30以上"});
            this.ComboBox6.Location = new System.Drawing.Point(462, 349);
            this.ComboBox6.Name = "ComboBox6";
            this.ComboBox6.Size = new System.Drawing.Size(144, 20);
            this.ComboBox6.TabIndex = 66;
            this.ComboBox6.SelectedIndexChanged += new System.EventHandler(this.ComboBox6_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label8.Location = new System.Drawing.Point(280, 345);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(114, 20);
            this.Label8.TabIndex = 64;
            this.Label8.Text = "赛季总助攻";
            // 
            // ComboBox4
            // 
            this.ComboBox4.FormattingEnabled = true;
            this.ComboBox4.Items.AddRange(new object[] {
            "0-5",
            "6-10",
            "11-15",
            "16-20",
            "21-25",
            "26-30",
            "30以上"});
            this.ComboBox4.Location = new System.Drawing.Point(462, 302);
            this.ComboBox4.Name = "ComboBox4";
            this.ComboBox4.Size = new System.Drawing.Size(144, 20);
            this.ComboBox4.TabIndex = 61;
            this.ComboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label6.Location = new System.Drawing.Point(280, 302);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(114, 20);
            this.Label6.TabIndex = 60;
            this.Label6.Text = "赛季总进球";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Items.AddRange(new object[] {
            "前锋",
            "中场",
            "后卫",
            "门将"});
            this.ComboBox3.Location = new System.Drawing.Point(462, 258);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(144, 20);
            this.ComboBox3.TabIndex = 59;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label4.Location = new System.Drawing.Point(280, 258);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 20);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "位置";
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "15-19",
            "20-24",
            "25-29",
            "30-34",
            "35及以上"});
            this.ComboBox2.Location = new System.Drawing.Point(462, 221);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(144, 20);
            this.ComboBox2.TabIndex = 57;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label3.Location = new System.Drawing.Point(280, 217);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 20);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "年龄";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(462, 137);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 21);
            this.TextBox1.TabIndex = 53;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label1.Location = new System.Drawing.Point(280, 138);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 20);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "球员姓名";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "阿森纳",
            "阿斯顿维拉",
            "卡迪夫城",
            "切尔西",
            "水晶宫",
            "埃弗顿",
            "富勒姆",
            "胡尔城",
            "利物浦",
            "曼城",
            "曼联",
            "纽卡斯尔",
            "诺维奇",
            "南安普顿",
            "斯托克城",
            "桑德兰",
            "斯旺西",
            "热刺",
            "西布朗",
            "西汉姆联"});
            this.ComboBox1.Location = new System.Drawing.Point(462, 179);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(144, 20);
            this.ComboBox1.TabIndex = 51;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label5.Location = new System.Drawing.Point(280, 179);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 20);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "球队";
            // 
            // 足球经理
            // 
            this.足球经理.BackColor = System.Drawing.Color.Transparent;
            this.足球经理.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.足球经理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.足球经理.Location = new System.Drawing.Point(274, 52);
            this.足球经理.Name = "足球经理";
            this.足球经理.Size = new System.Drawing.Size(341, 59);
            this.足球经理.TabIndex = 49;
            this.足球经理.Text = "球 员 搜 索";
            // 
            // ScoutSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._D_SA_MRM__2P5G_FXXJ11Q;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 524);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ComboBox6);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ComboBox4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.ComboBox3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.足球经理);
            this.Name = "ScoutSearch";
            this.Text = "足球经理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox ComboBox6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox ComboBox4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox ComboBox3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label 足球经理;
    }
}