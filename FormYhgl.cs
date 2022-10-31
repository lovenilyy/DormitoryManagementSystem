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
    public partial class FormYhgl : Form
    {
        public FormYhgl()
        {
            InitializeComponent();
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            FormYhAdd fa = new FormYhAdd();
            fa.Show();
            this.Hide();
        }

        private void BT_que_Click(object sender, EventArgs e)
        {
            string sf = CB_sf.Text.ToString().Trim();
            string Yhm = TB_Name.Text.Trim();

            string sql = "";
            if (sf != "" && Yhm == "")
                sql = "select * from Yh where Sf='" + sf + "'";
            else if (sf == "" && Yhm != "")
                sql = "select * from Yh where Yhm='" + Yhm + "'";
            else if (sf != "" && Yhm != "")
                sql = "select * from Yh where Yhm='" + Yhm + "' and Sf='" + sf + "'";
            else if (sf == "" && Yhm == "")
                sql = "select * from Yh where id='" + TB_id.Text.Trim() + "'";
            else
                sql = "select * from Yh";

            DataSet ds = new DataSet();
            ds = DbTool.GetDataSet(sql.ToString());
            GV_Search.DataSource = ds.Tables[0];
        }

        private void BT_del_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.GV_Search.CurrentRow.Cells["id"].Value.ToString());
            string sql = "delete Yh where id = " + id;
            if (DbTool.Execute(sql))
                MessageBox.Show("删除成功！", "删除记录", MessageBoxButtons.OK);
            else
                MessageBox.Show("删除失败！");
        }

        private void BT_Up_Click(object sender, EventArgs e)
        {
            FormYhUpdate fu = new FormYhUpdate();
            fu.Show();
            this.Hide();
        }
    }
}
