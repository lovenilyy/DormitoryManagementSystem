
namespace 高校宿舍管理系统
{
    partial class FormSsupdate
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
            this.BT_Sea = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Up = new System.Windows.Forms.Button();
            this.TB_Sg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Lz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Yq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_Yq = new System.Windows.Forms.ComboBox();
            this.CB_Lz = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Lz);
            this.groupBox1.Controls.Add(this.CB_Yq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GV_Search);
            this.groupBox1.Controls.Add(this.BT_Sea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 219);
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
            this.Xb,
            this.Column1});
            this.GV_Search.Location = new System.Drawing.Point(3, 67);
            this.GV_Search.Margin = new System.Windows.Forms.Padding(4);
            this.GV_Search.Name = "GV_Search";
            this.GV_Search.RowHeadersWidth = 51;
            this.GV_Search.RowTemplate.Height = 23;
            this.GV_Search.Size = new System.Drawing.Size(655, 145);
            this.GV_Search.TabIndex = 20;
            // 
            // BT_Sea
            // 
            this.BT_Sea.Location = new System.Drawing.Point(521, 22);
            this.BT_Sea.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Sea.Name = "BT_Sea";
            this.BT_Sea.Size = new System.Drawing.Size(100, 31);
            this.BT_Sea.TabIndex = 19;
            this.BT_Sea.Text = "查询";
            this.BT_Sea.UseVisualStyleBackColor = true;
            this.BT_Sea.Click += new System.EventHandler(this.BT_Sea_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(521, 294);
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
            this.BT_Up.Location = new System.Drawing.Point(521, 351);
            this.BT_Up.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Up.Name = "BT_Up";
            this.BT_Up.Size = new System.Drawing.Size(100, 31);
            this.BT_Up.TabIndex = 44;
            this.BT_Up.Text = "修改";
            this.BT_Up.UseVisualStyleBackColor = true;
            this.BT_Up.Click += new System.EventHandler(this.BT_Up_Click);
            // 
            // TB_Sg
            // 
            this.TB_Sg.Location = new System.Drawing.Point(454, 240);
            this.TB_Sg.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Sg.Name = "TB_Sg";
            this.TB_Sg.Size = new System.Drawing.Size(167, 25);
            this.TB_Sg.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "宿管：";
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(88, 351);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(167, 25);
            this.TB_id.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "楼号：";
            // 
            // TB_Lz
            // 
            this.TB_Lz.Location = new System.Drawing.Point(88, 297);
            this.TB_Lz.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Lz.Name = "TB_Lz";
            this.TB_Lz.Size = new System.Drawing.Size(167, 25);
            this.TB_Lz.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "楼座：";
            // 
            // TB_Yq
            // 
            this.TB_Yq.Location = new System.Drawing.Point(88, 240);
            this.TB_Yq.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Yq.Name = "TB_Yq";
            this.TB_Yq.Size = new System.Drawing.Size(167, 25);
            this.TB_Yq.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "园区：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "园区：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "楼座：";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "楼号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Xm
            // 
            this.Xm.DataPropertyName = "Yq";
            this.Xm.HeaderText = "园区";
            this.Xm.MinimumWidth = 6;
            this.Xm.Name = "Xm";
            this.Xm.Width = 125;
            // 
            // Xb
            // 
            this.Xb.DataPropertyName = "Lz";
            this.Xb.HeaderText = "楼座";
            this.Xb.MinimumWidth = 6;
            this.Xb.Name = "Xb";
            this.Xb.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sg";
            this.Column1.HeaderText = "宿管";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // CB_Yq
            // 
            this.CB_Yq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Yq.FormattingEnabled = true;
            this.CB_Yq.Location = new System.Drawing.Point(88, 26);
            this.CB_Yq.Name = "CB_Yq";
            this.CB_Yq.Size = new System.Drawing.Size(138, 23);
            this.CB_Yq.TabIndex = 35;
            // 
            // CB_Lz
            // 
            this.CB_Lz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Lz.FormattingEnabled = true;
            this.CB_Lz.Location = new System.Drawing.Point(328, 26);
            this.CB_Lz.Name = "CB_Lz";
            this.CB_Lz.Size = new System.Drawing.Size(138, 23);
            this.CB_Lz.TabIndex = 36;
            // 
            // FormSsupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Up);
            this.Controls.Add(this.TB_Sg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Lz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Yq);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSsupdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_Lz;
        private System.Windows.Forms.ComboBox CB_Yq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GV_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button BT_Sea;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Up;
        private System.Windows.Forms.TextBox TB_Sg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Lz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Yq;
        private System.Windows.Forms.Label label2;
    }
}