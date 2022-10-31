using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校宿舍管理系统
{
    public partial class FormYhAdd : Form
    {
        public FormYhAdd()
        {
            InitializeComponent();
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            string mm=TB_mm.Text.Trim();
            string qrmm=TB_qrmm.Text.Trim();
            string yhm=TB_Name.Text.Trim();
            string sf=CB_qx.Text.Trim();
            if (mm==qrmm)
            {
                string sql = "insert into Yh(Yhm, Mm, Sf) values('"+yhm+"','"+mm+"','"+sf+"')";
                if (DbTool.Execute(sql))
                {
                    MessageBox.Show("注册成功！");
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                FormYhgl fy=new FormYhgl();
                this.Hide();
                fy.Show();
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致！请重新输入！");
            }
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
