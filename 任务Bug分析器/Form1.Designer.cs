namespace 任务Bug分析器
{
    partial class Form1
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
            this.TaskContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.url1 = new System.Windows.Forms.TextBox();
            this.url2 = new System.Windows.Forms.TextBox();
            this.first1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.otherUrl1 = new System.Windows.Forms.TextBox();
            this.otherUrl2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.first2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Zh = new System.Windows.Forms.TextBox();
            this.En = new System.Windows.Forms.TextBox();
            this.addViewFieldBtn = new System.Windows.Forms.Button();
            this.before = new System.Windows.Forms.TextBox();
            this.after = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskContent
            // 
            this.TaskContent.Location = new System.Drawing.Point(12, 20);
            this.TaskContent.Name = "TaskContent";
            this.TaskContent.Size = new System.Drawing.Size(283, 21);
            this.TaskContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入任务的工作内容：";
            // 
            // url1
            // 
            this.url1.Location = new System.Drawing.Point(12, 66);
            this.url1.Name = "url1";
            this.url1.Size = new System.Drawing.Size(101, 21);
            this.url1.TabIndex = 2;
            // 
            // url2
            // 
            this.url2.Location = new System.Drawing.Point(12, 93);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(100, 21);
            this.url2.TabIndex = 3;
            // 
            // first1
            // 
            this.first1.Location = new System.Drawing.Point(188, 66);
            this.first1.Name = "first1";
            this.first1.Size = new System.Drawing.Size(100, 21);
            this.first1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "对应的控制器/视图/...组成";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "发生前提条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "其他相关控制器/视图";
            // 
            // otherUrl1
            // 
            this.otherUrl1.Location = new System.Drawing.Point(375, 65);
            this.otherUrl1.Name = "otherUrl1";
            this.otherUrl1.Size = new System.Drawing.Size(100, 21);
            this.otherUrl1.TabIndex = 8;
            // 
            // otherUrl2
            // 
            this.otherUrl2.Location = new System.Drawing.Point(375, 93);
            this.otherUrl2.Name = "otherUrl2";
            this.otherUrl2.Size = new System.Drawing.Size(97, 21);
            this.otherUrl2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "原因";
            // 
            // first2
            // 
            this.first2.Location = new System.Drawing.Point(188, 93);
            this.first2.Name = "first2";
            this.first2.Size = new System.Drawing.Size(100, 21);
            this.first2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "表头显示";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "对应字段";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "页面内容";
            // 
            // Zh
            // 
            this.Zh.Location = new System.Drawing.Point(83, 136);
            this.Zh.Name = "Zh";
            this.Zh.Size = new System.Drawing.Size(392, 21);
            this.Zh.TabIndex = 15;
            // 
            // En
            // 
            this.En.Location = new System.Drawing.Point(83, 160);
            this.En.Name = "En";
            this.En.Size = new System.Drawing.Size(392, 21);
            this.En.TabIndex = 16;
            // 
            // addViewFieldBtn
            // 
            this.addViewFieldBtn.Location = new System.Drawing.Point(16, 187);
            this.addViewFieldBtn.Name = "addViewFieldBtn";
            this.addViewFieldBtn.Size = new System.Drawing.Size(75, 23);
            this.addViewFieldBtn.TabIndex = 17;
            this.addViewFieldBtn.Text = "新增表头";
            this.addViewFieldBtn.UseVisualStyleBackColor = true;
            this.addViewFieldBtn.Click += new System.EventHandler(this.addViewFieldBtn_Click);
            // 
            // before
            // 
            this.before.Location = new System.Drawing.Point(172, 188);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(100, 21);
            this.before.TabIndex = 18;
            // 
            // after
            // 
            this.after.Location = new System.Drawing.Point(361, 189);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(100, 21);
            this.after.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "前面一个字段";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "后面一个字段";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.after);
            this.Controls.Add(this.before);
            this.Controls.Add(this.addViewFieldBtn);
            this.Controls.Add(this.En);
            this.Controls.Add(this.Zh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.first2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.otherUrl2);
            this.Controls.Add(this.otherUrl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first1);
            this.Controls.Add(this.url2);
            this.Controls.Add(this.url1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url1;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.TextBox first1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox otherUrl1;
        private System.Windows.Forms.TextBox otherUrl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Zh;
        private System.Windows.Forms.TextBox En;
        private System.Windows.Forms.Button addViewFieldBtn;
        private System.Windows.Forms.TextBox before;
        private System.Windows.Forms.TextBox after;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

