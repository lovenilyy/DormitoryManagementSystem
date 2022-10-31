namespace 高校宿舍管理系统
{
    partial class FormXsAdd
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
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Xb = new System.Windows.Forms.TextBox();
            this.LB_Cel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Ch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Yq = new System.Windows.Forms.ComboBox();
            this.CB_Lz = new System.Windows.Forms.ComboBox();
            this.lb_zt = new System.Windows.Forms.Label();
            this.CB_Fjh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(43, 75);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(52, 15);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "姓名：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(119, 71);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(167, 25);
            this.TB_Name.TabIndex = 1;
            // 
            // TB_Xb
            // 
            this.TB_Xb.Location = new System.Drawing.Point(119, 121);
            this.TB_Xb.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Xb.Name = "TB_Xb";
            this.TB_Xb.Size = new System.Drawing.Size(167, 25);
            this.TB_Xb.TabIndex = 3;
            // 
            // LB_Cel
            // 
            this.LB_Cel.AutoSize = true;
            this.LB_Cel.Location = new System.Drawing.Point(43, 125);
            this.LB_Cel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Cel.Name = "LB_Cel";
            this.LB_Cel.Size = new System.Drawing.Size(52, 15);
            this.LB_Cel.TabIndex = 2;
            this.LB_Cel.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "园区：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "楼座：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "房间号：";
            // 
            // TB_Ch
            // 
            this.TB_Ch.Location = new System.Drawing.Point(119, 318);
            this.TB_Ch.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Ch.Name = "TB_Ch";
            this.TB_Ch.Size = new System.Drawing.Size(167, 25);
            this.TB_Ch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "床号：";
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(225, 373);
            this.BT_Add.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(100, 29);
            this.BT_Add.TabIndex = 12;
            this.BT_Add.Text = "登记";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(24, 373);
            this.BT_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(100, 29);
            this.BT_Exit.TabIndex = 13;
            this.BT_Exit.Text = "退出";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(119, 24);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(167, 25);
            this.TB_id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "学号：";
            // 
            // CB_Yq
            // 
            this.CB_Yq.FormattingEnabled = true;
            this.CB_Yq.Location = new System.Drawing.Point(119, 175);
            this.CB_Yq.Name = "CB_Yq";
            this.CB_Yq.Size = new System.Drawing.Size(167, 23);
            this.CB_Yq.TabIndex = 16;
            // 
            // CB_Lz
            // 
            this.CB_Lz.FormattingEnabled = true;
            this.CB_Lz.Location = new System.Drawing.Point(119, 220);
            this.CB_Lz.Name = "CB_Lz";
            this.CB_Lz.Size = new System.Drawing.Size(167, 23);
            this.CB_Lz.TabIndex = 17;
            // 
            // lb_zt
            // 
            this.lb_zt.AutoSize = true;
            this.lb_zt.Location = new System.Drawing.Point(303, 274);
            this.lb_zt.Name = "lb_zt";
            this.lb_zt.Size = new System.Drawing.Size(0, 15);
            this.lb_zt.TabIndex = 19;
            // 
            // CB_Fjh
            // 
            this.CB_Fjh.FormattingEnabled = true;
            this.CB_Fjh.Location = new System.Drawing.Point(119, 269);
            this.CB_Fjh.Name = "CB_Fjh";
            this.CB_Fjh.Size = new System.Drawing.Size(167, 23);
            this.CB_Fjh.TabIndex = 20;
            // 
            // FormXsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 419);
            this.Controls.Add(this.CB_Fjh);
            this.Controls.Add(this.lb_zt);
            this.Controls.Add(this.CB_Lz);
            this.Controls.Add(this.CB_Yq);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_Ch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Xb);
            this.Controls.Add(this.LB_Cel);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormXsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生登记";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Xb;
        private System.Windows.Forms.Label LB_Cel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Ch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Yq;
        private System.Windows.Forms.ComboBox CB_Lz;
        private System.Windows.Forms.Label lb_zt;
        private System.Windows.Forms.ComboBox CB_Fjh;
    }
}