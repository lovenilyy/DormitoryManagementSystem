
namespace 高校宿舍管理系统
{
    partial class FormYhgl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_que = new System.Windows.Forms.Button();
            this.BT_Up = new System.Windows.Forms.Button();
            this.BT_del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_sf = new System.Windows.Forms.ComboBox();
            this.GV_Search = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(162, 177);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 39);
            this.BT_Add.TabIndex = 0;
            this.BT_Add.Text = "注册";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_que
            // 
            this.BT_que.Location = new System.Drawing.Point(266, 177);
            this.BT_que.Name = "BT_que";
            this.BT_que.Size = new System.Drawing.Size(75, 39);
            this.BT_que.TabIndex = 1;
            this.BT_que.Text = "查询";
            this.BT_que.UseVisualStyleBackColor = true;
            this.BT_que.Click += new System.EventHandler(this.BT_que_Click);
            // 
            // BT_Up
            // 
            this.BT_Up.Location = new System.Drawing.Point(66, 177);
            this.BT_Up.Name = "BT_Up";
            this.BT_Up.Size = new System.Drawing.Size(75, 39);
            this.BT_Up.TabIndex = 2;
            this.BT_Up.Text = "修改";
            this.BT_Up.UseVisualStyleBackColor = true;
            this.BT_Up.Click += new System.EventHandler(this.BT_Up_Click);
            // 
            // BT_del
            // 
            this.BT_del.Location = new System.Drawing.Point(376, 177);
            this.BT_del.Name = "BT_del";
            this.BT_del.Size = new System.Drawing.Size(75, 39);
            this.BT_del.TabIndex = 3;
            this.BT_del.Text = "删除";
            this.BT_del.UseVisualStyleBackColor = true;
            this.BT_del.Click += new System.EventHandler(this.BT_del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_sf);
            this.groupBox1.Controls.Add(this.BT_Add);
            this.groupBox1.Controls.Add(this.BT_del);
            this.groupBox1.Controls.Add(this.BT_que);
            this.groupBox1.Controls.Add(this.BT_Up);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(146, 131);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(121, 25);
            this.TB_id.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "工号：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(146, 86);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(121, 25);
            this.TB_Name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择身份：";
            // 
            // CB_sf
            // 
            this.CB_sf.FormattingEnabled = true;
            this.CB_sf.Items.AddRange(new object[] {
            "学生",
            "宿管",
            "教师"});
            this.CB_sf.Location = new System.Drawing.Point(146, 48);
            this.CB_sf.Name = "CB_sf";
            this.CB_sf.Size = new System.Drawing.Size(121, 23);
            this.CB_sf.TabIndex = 4;
            // 
            // GV_Search
            // 
            this.GV_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Xm,
            this.Yq,
            this.sf});
            this.GV_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GV_Search.Location = new System.Drawing.Point(0, 256);
            this.GV_Search.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Search.Name = "GV_Search";
            this.GV_Search.RowHeadersWidth = 51;
            this.GV_Search.RowTemplate.Height = 23;
            this.GV_Search.Size = new System.Drawing.Size(732, 194);
            this.GV_Search.TabIndex = 21;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "工号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Xm
            // 
            this.Xm.DataPropertyName = "Yhm";
            this.Xm.HeaderText = "姓名";
            this.Xm.MinimumWidth = 6;
            this.Xm.Name = "Xm";
            this.Xm.Width = 125;
            // 
            // Yq
            // 
            this.Yq.DataPropertyName = "Mm";
            this.Yq.HeaderText = "密码";
            this.Yq.MinimumWidth = 6;
            this.Yq.Name = "Yq";
            this.Yq.Width = 125;
            // 
            // sf
            // 
            this.sf.DataPropertyName = "Sf";
            this.sf.HeaderText = "身份";
            this.sf.MinimumWidth = 6;
            this.sf.Name = "sf";
            this.sf.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 25);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息预览";
            // 
            // FormYhgl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GV_Search);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormYhgl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_que;
        private System.Windows.Forms.Button BT_Up;
        private System.Windows.Forms.Button BT_del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GV_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yq;
        private System.Windows.Forms.DataGridViewTextBoxColumn sf;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_sf;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}