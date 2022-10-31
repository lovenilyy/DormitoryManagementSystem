namespace 高校宿舍管理系统
{
    partial class FormXsgl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel欢迎 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GV_Search = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fjh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel欢迎,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(713, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel欢迎
            // 
            this.toolStripStatusLabel欢迎.Name = "toolStripStatusLabel欢迎";
            this.toolStripStatusLabel欢迎.Size = new System.Drawing.Size(231, 20);
            this.toolStripStatusLabel欢迎.Spring = true;
            this.toolStripStatusLabel欢迎.Text = "欢迎使用宿舍管理系统！";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(231, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(231, 20);
            this.toolStripStatusLabelTime.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登记ToolStripMenuItem,
            this.维护ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 登记ToolStripMenuItem
            // 
            this.登记ToolStripMenuItem.Name = "登记ToolStripMenuItem";
            this.登记ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.登记ToolStripMenuItem.Text = "登记";
            this.登记ToolStripMenuItem.Click += new System.EventHandler(this.登记ToolStripMenuItem_Click);
            // 
            // 维护ToolStripMenuItem
            // 
            this.维护ToolStripMenuItem.Name = "维护ToolStripMenuItem";
            this.维护ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.维护ToolStripMenuItem.Text = "信息修改";
            this.维护ToolStripMenuItem.Click += new System.EventHandler(this.维护ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // GV_Search
            // 
            this.GV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Xm,
            this.Xb,
            this.Yq,
            this.Lz,
            this.Fjh,
            this.Column1});
            this.GV_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_Search.Location = new System.Drawing.Point(0, 28);
            this.GV_Search.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Search.Name = "GV_Search";
            this.GV_Search.RowHeadersWidth = 51;
            this.GV_Search.RowTemplate.Height = 23;
            this.GV_Search.Size = new System.Drawing.Size(713, 353);
            this.GV_Search.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "学号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Xm
            // 
            this.Xm.DataPropertyName = "Name";
            this.Xm.HeaderText = "姓名";
            this.Xm.MinimumWidth = 6;
            this.Xm.Name = "Xm";
            this.Xm.Width = 125;
            // 
            // Xb
            // 
            this.Xb.DataPropertyName = "Xb";
            this.Xb.HeaderText = "性别";
            this.Xb.MinimumWidth = 6;
            this.Xb.Name = "Xb";
            this.Xb.Width = 125;
            // 
            // Yq
            // 
            this.Yq.DataPropertyName = "Yq";
            this.Yq.HeaderText = "园区";
            this.Yq.MinimumWidth = 6;
            this.Yq.Name = "Yq";
            this.Yq.Width = 125;
            // 
            // Lz
            // 
            this.Lz.DataPropertyName = "Lz";
            this.Lz.HeaderText = "楼座";
            this.Lz.MinimumWidth = 6;
            this.Lz.Name = "Lz";
            this.Lz.Width = 125;
            // 
            // Fjh
            // 
            this.Fjh.DataPropertyName = "Fjh";
            this.Fjh.HeaderText = "房间号";
            this.Fjh.MinimumWidth = 6;
            this.Fjh.Name = "Fjh";
            this.Fjh.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ch";
            this.Column1.HeaderText = "床号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // FormXsgl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 407);
            this.Controls.Add(this.GV_Search);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormXsgl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel欢迎;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView GV_Search;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fjh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

