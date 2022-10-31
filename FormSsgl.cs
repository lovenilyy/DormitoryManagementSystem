using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 高校宿舍管理系统
{
    public partial class FormSsgl : Form
    {
        public static SqlDataReader DR;
        public FormSsgl()
        {
            InitializeComponent();
            InitialYq();
            InitialLz();
        }

        //stuLz
        public class stuLz
        {

            /// <summary>
            /// id
            /// </summary>		
            private int _id;
            public int id
            {
                get { return _id; }
                set { _id = value; }
            }
            /// <summary>
            /// Name
            /// </summary>		
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public stuLz(string name)
            {
                Name = name;
            }

        }
        //stuYq
        public class stuYq
        {

            /// <summary>
            /// id
            /// </summary>		
            private int _id;
            public int id
            {
                get { return _id; }
                set { _id = value; }
            }
            /// <summary>
            /// Name
            /// </summary>		
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public stuYq(string name)
            {
                Name = name;
            }
        }
        public void InitialYq()
        {
            string sql = "select * from stuYq ";
            DR = DbTool.lstl(sql);
            List<stuYq> lstYq = new List<stuYq>();
            lstYq.Add(new stuYq("-请选择-"));
            while (DR.Read())
            {
                string name = DR.GetString(1);
                stuYq item = new stuYq(name);
                lstYq.Add(item);
            }
            this.CB_Yq.DataSource = lstYq;
            this.CB_Yq.DisplayMember = "Name";
            this.CB_Yq.ValueMember = "Name";
        }       
        public void InitialLz()
        {
            string sql = "select * from stuLz ";
            DR = DbTool.lstl(sql);
            List<stuLz> lstLz = new List<stuLz>();
            lstLz.Add(new stuLz("-请选择-"));
            while (DR.Read())
            {
                string name = DR.GetString(1);
                stuLz item = new stuLz(name);
                lstLz.Add(item);
            }
            this.CB_Lz.DataSource = lstLz;
            this.CB_Lz.DisplayMember = "Name";
            this.CB_Lz.ValueMember = "Name";
        }


        private void BT_Que_Click(object sender, EventArgs e)
        {
            try
            {
                string where = "";
                if (this.TB_Fjh.Text.Length > 0)
                {
                    where += " Fjh ='"+ TB_Fjh.Text.Trim() + "'";
                }
                string sql = "SELECT  * FROM V_同寝 where" + where + "";

                DataSet ds = new DataSet();
                ds = DbTool.GetDataSet(sql.ToString());
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT bed FROM stuRoom where Fjh='"+tbFjh.Text.Trim()+"' ";
            if (!string.IsNullOrEmpty(tbFjh.Text))
            {
                DataSet ds = DbTool.GetDataSet(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    tb_Bed.Text = ds.Tables[0].Rows[i]["bed"].ToString();                   
                }
            }
            else
            {
                MessageBox.Show("查询失败！！");
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            FormSsAdd fa=new FormSsAdd();
            fa.ShowDialog();
            this.Hide();
        }

        private void BT_Up_Click(object sender, EventArgs e)
        {
            FormSsupdate fa=new FormSsupdate();
            this.Hide();
            fa.Show();
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string sql = "delete ssXx where id = " + id;
            if (DbTool.Execute(sql))
                MessageBox.Show("删除成功！", "删除记录", MessageBoxButtons.OK);
            else
                MessageBox.Show("删除失败！");
        }
    }
}
