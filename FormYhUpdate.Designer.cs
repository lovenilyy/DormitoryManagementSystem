
namespace 高校宿舍管理系统
{
    partial class FormYhUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GV_Search = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Sea = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Up = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_sf = new System.Windows.Forms.ComboBox();
            this.TB_mm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GV_Search);
            this.groupBox1.Controls.Add(this.BT_Sea);
            this.groupBox1.Controls.Add(this.TB_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 219);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询信息";
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
            this.GV_Search.Location = new System.Drawing.Point(3, 54);
            this.GV_Search.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Search.Name = "GV_Search";
            this.GV_Search.RowHeadersWidth = 51;
            this.GV_Search.RowTemplate.Height = 23;
            this.GV_Search.Size = new System.Drawing.Size(677, 162);
            this.GV_Search.TabIndex = 22;
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
            // BT_Sea
            // 
            this.BT_Sea.Location = new System.Drawing.Point(521, 15);
            this.BT_Sea.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Sea.Name = "BT_Sea";
            this.BT_Sea.Size = new System.Drawing.Size(100, 31);
            this.BT_Sea.TabIndex = 19;
            this.BT_Sea.Text = "查询";
            this.BT_Sea.UseVisualStyleBackColor = true;
            this.BT_Sea.Click += new System.EventHandler(this.BT_Sea_Click);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(263, 17);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(167, 25);
            this.TB_id.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "请输入需要查询的工号：";
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(521, 233);
            this.BT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(100, 29);
            this.BT_Exit.TabIndex = 45;
            this.BT_Exit.Text = "退出";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // BT_Up
            // 
            this.BT_Up.Location = new System.Drawing.Point(521, 320);
            this.BT_Up.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Up.Name = "BT_Up";
            this.BT_Up.Size = new System.Drawing.Size(100, 31);
            this.BT_Up.TabIndex = 44;
            this.BT_Up.Text = "修改";
            this.BT_Up.UseVisualStyleBackColor = true;
            this.BT_Up.Click += new System.EventHandler(this.BT_Up_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(105, 275);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(121, 25);
            this.TB_Name.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "选择身份：";
            // 
            // CB_sf
            // 
            this.CB_sf.FormattingEnabled = true;
            this.CB_sf.Items.AddRange(new object[] {
            "学生",
            "宿管",
            "教师"});
            this.CB_sf.Location = new System.Drawing.Point(105, 237);
            this.CB_sf.Name = "CB_sf";
            this.CB_sf.Size = new System.Drawing.Size(121, 23);
            this.CB_sf.TabIndex = 47;
            // 
            // TB_mm
            // 
            this.TB_mm.Location = new System.Drawing.Point(105, 320);
            this.TB_mm.Name = "TB_mm";
            this.TB_mm.Size = new System.Drawing.Size(121, 25);
            this.TB_mm.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "密码：";
            // 
            // FormYhUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 373);
            this.Controls.Add(this.TB_mm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_sf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormYhUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户修改";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_Sea;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Up;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_sf;
        private System.Windows.Forms.TextBox TB_mm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GV_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yq;
        private System.Windows.Forms.DataGridViewTextBoxColumn sf;
    }
}