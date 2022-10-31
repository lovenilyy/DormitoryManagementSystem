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
    public partial class FormSearch : Form
    {
        public static SqlDataReader DR;
        public FormSearch()
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

                if (this.CB_Yq.Text.Trim()!=null || CB_Yq.Text.Trim()!= "-请选择-")
                {
                    where += " Yq ='" + CB_Yq.Text.Trim() + "'";
                }
                if (this.CB_Lz.Text.Trim() !=null || CB_Lz.Text.Trim()!= "-请选择-")
                {
                    where += " and Lz ='" + CB_Lz.Text.Trim() + "'";
                }
                if (this.TB_Fjh.Text.Trim()!=null)
                {
                    where += " AND  Fjh ='" + TB_Fjh.Text.Trim() + "'";
                }
                string sql = "SELECT  * FROM stuXx where" + where + "";

                DataSet ds = new DataSet();
                ds = DbTool.GetDataSet(sql.ToString());
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw (ex);
                MessageBox.Show("查询失败！！");
            }
        }
    }
}
