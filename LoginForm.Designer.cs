
namespace 高校宿舍管理系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Yhm = new System.Windows.Forms.Label();
            this.panelDL = new System.Windows.Forms.Panel();
            this.CB_sf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Close = new System.Windows.Forms.Button();
            this.TB_Pwd = new System.Windows.Forms.TextBox();
            this.BT_DL = new System.Windows.Forms.Button();
            this.TB_Yhm = new System.Windows.Forms.TextBox();
            this.LB_Pwd = new System.Windows.Forms.Label();
            this.BT_zc = new System.Windows.Forms.Button();
            this.panelDL.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Yhm
            // 
            this.LB_Yhm.AutoSize = true;
            this.LB_Yhm.Location = new System.Drawing.Point(97, 111);
            this.LB_Yhm.Name = "LB_Yhm";
            this.LB_Yhm.Size = new System.Drawing.Size(67, 15);
            this.LB_Yhm.TabIndex = 0;
            this.LB_Yhm.Text = "用户名：";
            // 
            // panelDL
            // 
            this.panelDL.Controls.Add(this.BT_zc);
            this.panelDL.Controls.Add(this.CB_sf);
            this.panelDL.Controls.Add(this.label1);
            this.panelDL.Controls.Add(this.BT_Close);
            this.panelDL.Controls.Add(this.TB_Pwd);
            this.panelDL.Controls.Add(this.BT_DL);
            this.panelDL.Controls.Add(this.TB_Yhm);
            this.panelDL.Controls.Add(this.LB_Pwd);
            this.panelDL.Controls.Add(this.LB_Yhm);
            this.panelDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDL.Location = new System.Drawing.Point(0, 0);
            this.panelDL.Name = "panelDL";
            this.panelDL.Size = new System.Drawing.Size(437, 313);
            this.panelDL.TabIndex = 1;
            // 
            // CB_sf
            // 
            this.CB_sf.FormattingEnabled = true;
            this.CB_sf.Items.AddRange(new object[] {
            "学生",
            "宿管",
            "教师"});
            this.CB_sf.Location = new System.Drawing.Point(194, 66);
            this.CB_sf.Name = "CB_sf";
            this.CB_sf.Size = new System.Drawing.Size(130, 23);
            this.CB_sf.TabIndex = 7;
            this.CB_sf.Text = "-请选择-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "登录身份：";
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(47, 209);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(81, 35);
            this.BT_Close.TabIndex = 5;
            this.BT_Close.Text = "取消";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // TB_Pwd
            // 
            this.TB_Pwd.Location = new System.Drawing.Point(194, 158);
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.PasswordChar = '*';
            this.TB_Pwd.Size = new System.Drawing.Size(130, 25);
            this.TB_Pwd.TabIndex = 3;
            this.TB_Pwd.Text = "123";
            // 
            // BT_DL
            // 
            this.BT_DL.Location = new System.Drawing.Point(344, 209);
            this.BT_DL.Name = "BT_DL";
            this.BT_DL.Size = new System.Drawing.Size(81, 35);
            this.BT_DL.TabIndex = 4;
            this.BT_DL.Text = "登录";
            this.BT_DL.UseVisualStyleBackColor = true;
            this.BT_DL.Click += new System.EventHandler(this.BT_DL_Click);
            // 
            // TB_Yhm
            // 
            this.TB_Yhm.Location = new System.Drawing.Point(194, 108);
            this.TB_Yhm.Name = "TB_Yhm";
            this.TB_Yhm.Size = new System.Drawing.Size(130, 25);
            this.TB_Yhm.TabIndex = 2;
            this.TB_Yhm.Text = "刘老师";
            // 
            // LB_Pwd
            // 
            this.LB_Pwd.AutoSize = true;
            this.LB_Pwd.Location = new System.Drawing.Point(97, 161);
            this.LB_Pwd.Name = "LB_Pwd";
            this.LB_Pwd.Size = new System.Drawing.Size(68, 15);
            this.LB_Pwd.TabIndex = 1;
            this.LB_Pwd.Text = "密  码：";
            // 
            // BT_zc
            // 
            this.BT_zc.Location = new System.Drawing.Point(194, 209);
            this.BT_zc.Name = "BT_zc";
            this.BT_zc.Size = new System.Drawing.Size(81, 35);
            this.BT_zc.TabIndex = 8;
            this.BT_zc.Text = "注册";
            this.BT_zc.UseVisualStyleBackColor = true;
            this.BT_zc.Click += new System.EventHandler(this.BT_zc_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BT_DL;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 313);
            this.Controls.Add(this.panelDL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎登录宿舍管理系统！";
            this.panelDL.ResumeLayout(false);
            this.panelDL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Yhm;
        private System.Windows.Forms.Panel panelDL;
        private System.Windows.Forms.TextBox TB_Pwd;
        private System.Windows.Forms.TextBox TB_Yhm;
        private System.Windows.Forms.Label LB_Pwd;
        private System.Windows.Forms.Button BT_DL;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.ComboBox CB_sf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_zc;
    }
}

