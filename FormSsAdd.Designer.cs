namespace 高校宿舍管理系统
{
    partial class FormSsAdd
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
            this.CB_Lz = new System.Windows.Forms.ComboBox();
            this.CB_Yq = new System.Windows.Forms.ComboBox();
            this.TB_Sg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_fh = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CB_Lz
            // 
            this.CB_Lz.FormattingEnabled = true;
            this.CB_Lz.Location = new System.Drawing.Point(118, 124);
            this.CB_Lz.Name = "CB_Lz";
            this.CB_Lz.Size = new System.Drawing.Size(167, 23);
            this.CB_Lz.TabIndex = 27;
            // 
            // CB_Yq
            // 
            this.CB_Yq.FormattingEnabled = true;
            this.CB_Yq.Location = new System.Drawing.Point(118, 84);
            this.CB_Yq.Name = "CB_Yq";
            this.CB_Yq.Size = new System.Drawing.Size(167, 23);
            this.CB_Yq.TabIndex = 26;
            // 
            // TB_Sg
            // 
            this.TB_Sg.Location = new System.Drawing.Point(118, 164);
            this.TB_Sg.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Sg.Name = "TB_Sg";
            this.TB_Sg.Size = new System.Drawing.Size(167, 25);
            this.TB_Sg.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "宿管：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "楼号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "楼座：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "园区：";
            // 
            // BT_fh
            // 
            this.BT_fh.Location = new System.Drawing.Point(47, 229);
            this.BT_fh.Name = "BT_fh";
            this.BT_fh.Size = new System.Drawing.Size(75, 23);
            this.BT_fh.TabIndex = 29;
            this.BT_fh.Text = "退出";
            this.BT_fh.UseVisualStyleBackColor = true;
            this.BT_fh.Click += new System.EventHandler(this.BT_fh_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(210, 229);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 30;
            this.BT_Add.Text = "添加";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(118, 43);
            this.TB_id.Margin = new System.Windows.Forms.Padding(4);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(167, 25);
            this.TB_id.TabIndex = 31;
            // 
            // FormSsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.BT_fh);
            this.Controls.Add(this.CB_Lz);
            this.Controls.Add(this.CB_Yq);
            this.Controls.Add(this.TB_Sg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍楼添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_Lz;
        private System.Windows.Forms.ComboBox CB_Yq;
        private System.Windows.Forms.TextBox TB_Sg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_fh;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.TextBox TB_id;
    }
}