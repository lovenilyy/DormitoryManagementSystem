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
    public partial class FormXsupdate : Form
    {
        public FormXsupdate()
        {
            InitializeComponent();
        }

        private void BT_Up_Click(object sender, EventArgs e)
        {
            string sql = string.Format(" update  stuXx  set Name ='{0}' ,Xb ='{1}', Yq = '{2}', Lz = '{3}', Fjh = '{4}', Ch = '{5}' where id='"+TB_Xh.Text.Trim()+"'", TB_Name.Text.Trim(), TB_Xb.Text.Trim(), TB_Yq.Text.Trim(), TB_Lz.Text.Trim(), TB_Fjh.Text.Trim(), TB_Ch.Text.Trim());
            bool ds = DbTool.Execute(sql);
            if (ds)
                MessageBox.Show("修改成功！");
            else
                MessageBox.Show("修改失败！");
            FormXsgl fx = new FormXsgl();
            fx.Show();
            this.Hide();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Sea_Click(object sender, EventArgs e)
        {
            string id = TB_Xh.Text.Trim();
            if (!string.IsNullOrEmpty(id))
            {
                string sql = "select * from stuXx where id='" + id + "'";
                DataSet ds = DbTool.GetDataSet(sql);

                GV_Search.DataSource = ds.Tables[0];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TB_Name.Text = ds.Tables[0].Rows[i]["Name"].ToString();
                    TB_Xb.Text = ds.Tables[0].Rows[i]["Xb"].ToString();
                    TB_Lz.Text = ds.Tables[0].Rows[i]["Lz"].ToString();
                    TB_Yq.Text = ds.Tables[0].Rows[i]["Yq"].ToString();
                    TB_Fjh.Text = ds.Tables[0].Rows[i]["Fjh"].ToString();
                    TB_Ch.Text = ds.Tables[0].Rows[i]["Ch"].ToString();
                }
            }
            else
            {
                MessageBox.Show("查无此人！");
            }          
        }
    }
}
