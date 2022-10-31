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
    public partial class FormSsupdate : Form
    {
        private SqlDataReader DR;

        public FormSsupdate()
        {
            InitializeComponent();
            InitialYq();
            InitialLz();
        }
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

        private void BT_Sea_Click(object sender, EventArgs e)
        {
            string sql = "select * from ssXx ";
            if(CB_Yq.SelectedIndex>0)
                sql += "where Yq='"+ this.CB_Yq.SelectedValue.ToString().Substring(0, 2) + "'";
            if(CB_Lz.Text.Length>0)
                sql +="and Lz='"+ this.CB_Lz.Text.Trim() + "'";
            DataSet ds = DbTool.GetDataSet(sql);
            GV_Search.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {   
                TB_id.Text = ds.Tables[0].Rows[i]["id"].ToString();             
                TB_Lz.Text = ds.Tables[0].Rows[i]["Lz"].ToString();
                TB_Yq.Text = ds.Tables[0].Rows[i]["Yq"].ToString();               
                TB_Sg.Text = ds.Tables[0].Rows[i]["Sg"].ToString();
            }
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Up_Click(object sender, EventArgs e)
        {
            string sql = string.Format(" update  ssXx  set Yq = '{0}', Lz = '{1}', Sg = '{2}' where id='{3}'", TB_Yq.Text.Trim(), TB_Lz.Text.Trim(), TB_Sg.Text.Trim(), TB_id.Text.Trim());
            bool ds = DbTool.Execute(sql);
            if (ds)
                MessageBox.Show("修改成功！");
            else
                MessageBox.Show("修改失败！");
            FormSsgl fx = new FormSsgl();
            fx.Show();
            this.Hide();
        }
    }
}
