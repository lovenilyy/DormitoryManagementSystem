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
using System.Configuration;

namespace 高校宿舍管理系统
{
    public partial class LoginForm : Form
    {
        public static DbTool Db = new DbTool();
        private SqlDataReader DR;

        public LoginForm()
        {
            InitializeComponent();            
        }       
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=DB_Xsgl;Uid=Long;pwd=123";
            return con;
        }

        private void BT_DL_Click(object sender, EventArgs e)
        {
            string name = TB_Yhm.Text.ToString().Trim();
            string pwd = TB_Pwd.Text.ToString().Trim();
            string sf = CB_sf.Text.Trim();
            string sql = "SELECT * from Yh where Yhm='" + name + "'and Mm='" + pwd + "'and Sf='" + sf + "'";

            SqlConnection con = getCon();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                switch (sf)
                {
                    case "学生":
                        FormMain fm = new FormMain(sf);
                        fm.Show();
                        this.Hide();
                        break;
                    case "宿管":
                        FormMain fm1 = new FormMain(name,sf);
                        fm1.Show();
                        this.Hide();
                        break;
                    case "教师": 
                        FormMain fm2 = new FormMain();
                        fm2.Show();
                        this.Hide(); 
                        break;
                    default:
                        break;
                }          
            }
            else
            {
                MessageBox.Show("用户名或密码或身份输入错误！", "登入提示", MessageBoxButtons.OK);
            }
        }

        private void BT_zc_Click(object sender, EventArgs e)
        {
            FormYhAdd fa=new FormYhAdd();
            fa.Show();
            this.Hide();
        }
    }
}
