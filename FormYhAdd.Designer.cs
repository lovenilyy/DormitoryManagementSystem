
namespace 高校宿舍管理系统
{
    partial class FormYhAdd
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
            this.BT_Exit = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.TB_mm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Cel = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.CB_qx = new System.Windows.Forms.ComboBox();
            this.TB_qrmm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(15, 244);
            this.BT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(100, 29);
            this.BT_Exit.TabIndex = 27;
            this.BT_Exit.Text = "退出";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(216, 244);
            this.BT_Add.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(100, 29);
            this.BT_Add.TabIndex = 26;
            this.BT_Add.Text = "注册";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // TB_mm
            // 
            this.TB_mm.Location = new System.Drawing.Point(110, 130);
            this.TB_mm.Margin = new System.Windows.Forms.Padding(4);
            this.TB_mm.Name = "TB_mm";
            this.TB_mm.Size = new System.Drawing.Size(167, 25);
            this.TB_mm.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "新建密码：";
            // 
            // LB_Cel
            // 
            this.LB_Cel.AutoSize = true;
            this.LB_Cel.Location = new System.Drawing.Point(34, 82);
            this.LB_Cel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Cel.Name = "LB_Cel";
            this.LB_Cel.Size = new System.Drawing.Size(52, 15);
            this.LB_Cel.TabIndex = 16;
            this.LB_Cel.Text = "权限：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(110, 28);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(167, 25);
            this.TB_Name.TabIndex = 15;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(34, 32);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(52, 15);
            this.LB_Name.TabIndex = 14;
            this.LB_Name.Text = "姓名：";
            // 
            // CB_qx
            // 
            this.CB_qx.AutoCompleteCustomSource.AddRange(new string[] {
            "学生",
            "宿管",
            "教师"});
            this.CB_qx.FormattingEnabled = true;
            this.CB_qx.Items.AddRange(new object[] {
            "学生",
            "宿管",
            "教师"});
            this.CB_qx.Location = new System.Drawing.Point(110, 78);
            this.CB_qx.Name = "CB_qx";
            this.CB_qx.Size = new System.Drawing.Size(167, 23);
            this.CB_qx.TabIndex = 28;
            this.CB_qx.Text = "学生";
            // 
            // TB_qrmm
            // 
            this.TB_qrmm.Location = new System.Drawing.Point(110, 183);
            this.TB_qrmm.Margin = new System.Windows.Forms.Padding(4);
            this.TB_qrmm.Name = "TB_qrmm";
            this.TB_qrmm.Size = new System.Drawing.Size(167, 25);
            this.TB_qrmm.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "确认密码：";
            // 
            // FormYhAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 305);
            this.Controls.Add(this.TB_qrmm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_qx);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_mm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Cel);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormYhAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.TextBox TB_mm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Cel;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.ComboBox CB_qx;
        private System.Windows.Forms.TextBox TB_qrmm;
        private System.Windows.Forms.Label label1;
    }
}