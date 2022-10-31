using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校宿舍管理系统
{
    public partial class FormMain : Form
    {
        public FormMain()//超级管理
        {
            InitializeComponent();
        }
        public FormMain(string sf)//普通用户
        {
            InitializeComponent();
            宿舍管理ToolStripMenuItem.Visible = false;
        }
        public FormMain(string name, string sf)//普通管理
        {
            InitializeComponent();
            学生管理ToolStripMenuItem.Visible = false;
            用户管理ToolStripMenuItem.Visible = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSsgl fs = new FormSsgl();
            fs.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void 宿舍信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch();
            fs.ShowDialog();
            this.Hide();
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXsgl fx = new FormXsgl();
            fx.ShowDialog();
            this.Hide();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYhgl fy = new FormYhgl();
            fy.ShowDialog();
            this.Hide();
        }

        private void 保存toolStripMenuItem_Click(object sender, EventArgs e)
        { 
            saveFileDialog1.Filter = "文本文件|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string sql = "select * from stuXx";
                SqlDataReader dr = DbTool.ExecuteReader(sql);

                List<string> student = new List<string>();
                while (dr.Read())
                {
                    string id = dr["id"].ToString();
                    string name = dr["Name"].ToString();
                    string xb = dr["Xb"].ToString();
                    string yq = dr["Yq"].ToString();
                    string lz = dr["Lz"].ToString();
                    string fjh = dr["Fjh"].ToString();
                    string ch = dr["Ch"].ToString();
                    student.Add(id + "," + name + "," + xb + "," + yq + "," + lz + "," + fjh + "," + ch);
                }
                File.WriteAllLines(path, student.ToArray());
                MessageBox.Show("保存了" + student.Count);

            }
        }
    }
}
