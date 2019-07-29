namespace bug解决器
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
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.searchTitle = new System.Windows.Forms.Button();
            this.searchContent = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.saveContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(106, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(149, 21);
            this.title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "bug位置";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "bug关键字";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(106, 31);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(166, 37);
            this.content.TabIndex = 3;
            // 
            // searchTitle
            // 
            this.searchTitle.Location = new System.Drawing.Point(14, 91);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(91, 23);
            this.searchTitle.TabIndex = 4;
            this.searchTitle.Text = "搜索bug位置";
            this.searchTitle.UseVisualStyleBackColor = true;
            this.searchTitle.Click += new System.EventHandler(this.searchTitle_Click);
            // 
            // searchContent
            // 
            this.searchContent.Location = new System.Drawing.Point(131, 91);
            this.searchContent.Name = "searchContent";
            this.searchContent.Size = new System.Drawing.Size(91, 23);
            this.searchContent.TabIndex = 5;
            this.searchContent.Text = "搜索bug关键字";
            this.searchContent.UseVisualStyleBackColor = true;
            this.searchContent.Click += new System.EventHandler(this.searchContent_Click);
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(14, 135);
            this.searchResult.Multiline = true;
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(258, 54);
            this.searchResult.TabIndex = 6;
            this.searchResult.Text = "记录解决思路（第一行自己填写，第二行开始为查询结果）";
            this.searchResult.TextChanged += new System.EventHandler(this.searchResult_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(14, 298);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveContent
            // 
            this.saveContent.Location = new System.Drawing.Point(14, 225);
            this.saveContent.Multiline = true;
            this.saveContent.Name = "saveContent";
            this.saveContent.Size = new System.Drawing.Size(258, 54);
            this.saveContent.TabIndex = 8;
            this.saveContent.Text = "记录解决办法";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 350);
            this.Controls.Add(this.saveContent);
            this.Controls.Add(this.save);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchContent);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button searchTitle;
        private System.Windows.Forms.Button searchContent;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox saveContent;
    }
}

