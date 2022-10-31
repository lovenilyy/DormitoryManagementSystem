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

namespace 高校宿舍管理系统
{
    public partial class FormXsgl : Form
    {
        public FormXsgl()
        {
            InitializeComponent();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void 登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXsAdd fa = new FormXsAdd();
            this.Hide();
            fa.ShowDialog();
            
        }

        private void 维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXsupdate fx = new FormXsupdate();
            this.Hide();
            fx.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT  * FROM stuXx");
            DataSet ds = new DataSet();
            ds = DbTool.GetDataSet(sql.ToString());
            GV_Search.DataSource = ds.Tables[0];
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.GV_Search.CurrentRow.Cells["id"].Value.ToString());
            string sql = "delete stuXx where id = " + id;
            if (DbTool.Execute(sql))
                MessageBox.Show("删除成功！", "删除记录", MessageBoxButtons.OK);
            else
                MessageBox.Show("删除失败！");
        }
    }
}
