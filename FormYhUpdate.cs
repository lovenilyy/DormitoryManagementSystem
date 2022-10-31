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
    public partial class FormYhUpdate : Form
    {
        public FormYhUpdate()
        {
            InitializeComponent();
        }

        private void BT_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BT_Up_Click(object sender, EventArgs e)
        {
            string sql = "update Yh set Yhm='"+TB_Name.Text.Trim()+"',Mm='"+TB_mm.Text.Trim()+"',Sf='"+CB_sf.Text.Trim()+"' where id='"+TB_id.Text.Trim()+"'";
            bool ds = DbTool.Execute(sql);
            if (ds)
                MessageBox.Show("修改成功！");
            else
                MessageBox.Show("修改失败！");
            FormYhUpdate fyu = new FormYhUpdate();
            fyu.Show();
            this.Hide();
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Sea_Click(object sender, EventArgs e)
        {
            string id = TB_id.Text.Trim();
            if (!string.IsNullOrEmpty(id))
            {
                string sql = "select * from Yh where id='" + id + "'";
                DataSet ds = DbTool.GetDataSet(sql);

                GV_Search.DataSource = ds.Tables[0];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    TB_Name.Text = ds.Tables[0].Rows[i]["Yhm"].ToString();
                    TB_mm.Text = ds.Tables[0].Rows[i]["Mm"].ToString();
                    CB_sf.Text = ds.Tables[0].Rows[i]["Sf"].ToString();                                       
                }
            }
            else
            {
                MessageBox.Show("查无此人！");
            }
        }
    }
}
