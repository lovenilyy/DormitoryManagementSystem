
namespace 高校宿舍管理系统
{
    partial class FormXsupdate
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
            this.BT_Sea = new System.Windows.Forms.Button();
            this.TB_Xh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GV_Search = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fjh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Up = new System.Windows.Forms.Button();
            this.TB_Ch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Fjh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Lz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Yq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Xb = new System.Windows.Forms.TextBox();
            this.LB_Cel = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // TB_Xh
            // 
            this.TB_Xh.Location = new System.Drawing.Point(263, 17);
            this.TB_Xh.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Xh.Name = "TB_Xh";
            this.TB_Xh.Size = new System.Drawing.Size(167, 25);
            this.TB_Xh.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "请输入需要查询的学号：";
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
            this.Fjh});
            this.GV_Search.Location = new System.Drawing.Point(3, 50);
            this.GV_Search.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Search.Name = "GV_Search";
            this.GV_Search.RowHeadersWidth = 51;
            this.GV_Search.RowTemplate.Height = 23;
            this.GV_Search.Size = new System.Drawing.Size(675, 162);
            this.GV_Search.TabIndex = 20;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GV_Search);
            this.groupBox1.Controls.Add(this.BT_Sea);
            this.groupBox1.Controls.Add(this.TB_Xh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 219);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询信息";
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(71, 396);
            this.BT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(100, 29);
            this.BT_Exit.TabIndex = 30;
            this.BT_Exit.Text = "退出";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // BT_Up
            // 
            this.BT_Up.Location = new System.Drawing.Point(521, 395);
            this.BT_Up.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Up.Name = "BT_Up";
            this.BT_Up.Size = new System.Drawing.Size(100, 31);
            this.BT_Up.TabIndex = 29;
            this.BT_Up.Text = "修改";
            this.BT_Up.UseVisualStyleBackColor = true;
            this.BT_Up.Click += new System.EventHandler(this.BT_Up_Click);
            // 
            // TB_Ch
            // 
            this.TB_Ch.Location = new System.Drawing.Point(454, 342);
            this.TB_Ch.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Ch.Name = "TB_Ch";
            this.TB_Ch.Size = new System.Drawing.Size(167, 25);
            this.TB_Ch.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "床号：";
            // 
            // TB_Fjh
            // 
            this.TB_Fjh.Location = new System.Drawing.Point(144, 339);
            this.TB_Fjh.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Fjh.Name = "TB_Fjh";
            this.TB_Fjh.Size = new System.Drawing.Size(167, 25);
            this.TB_Fjh.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "房间号：";
            // 
            // TB_Lz
            // 
            this.TB_Lz.Location = new System.Drawing.Point(454, 293);
            this.TB_Lz.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Lz.Name = "TB_Lz";
            this.TB_Lz.Size = new System.Drawing.Size(167, 25);
            this.TB_Lz.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "楼座：";
            // 
            // TB_Yq
            // 
            this.TB_Yq.Location = new System.Drawing.Point(454, 246);
            this.TB_Yq.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Yq.Name = "TB_Yq";
            this.TB_Yq.Size = new System.Drawing.Size(167, 25);
            this.TB_Yq.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "园区：";
            // 
            // TB_Xb
            // 
            this.TB_Xb.Location = new System.Drawing.Point(144, 293);
            this.TB_Xb.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Xb.Name = "TB_Xb";
            this.TB_Xb.Size = new System.Drawing.Size(167, 25);
            this.TB_Xb.TabIndex = 20;
            // 
            // LB_Cel
            // 
            this.LB_Cel.AutoSize = true;
            this.LB_Cel.Location = new System.Drawing.Point(68, 297);
            this.LB_Cel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Cel.Name = "LB_Cel";
            this.LB_Cel.Size = new System.Drawing.Size(52, 15);
            this.LB_Cel.TabIndex = 19;
            this.LB_Cel.Text = "性别：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(144, 245);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(167, 25);
            this.TB_Name.TabIndex = 18;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(68, 249);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(52, 15);
            this.LB_Name.TabIndex = 17;
            this.LB_Name.Text = "姓名：";
            // 
            // FormXsupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Up);
            this.Controls.Add(this.TB_Ch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Fjh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Lz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Yq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Xb);
            this.Controls.Add(this.LB_Cel);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormXsupdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息修改";
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Sea;
        private System.Windows.Forms.TextBox TB_Xh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GV_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Up;
        private System.Windows.Forms.TextBox TB_Ch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Fjh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Lz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Yq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Xb;
        private System.Windows.Forms.Label LB_Cel;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fjh;
    }
}