namespace ppt2pdf.net
{
    partial class mainForm
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
            this.button_Explore = new System.Windows.Forms.Button();
            this.button_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Explore
            // 
            this.button_Explore.Location = new System.Drawing.Point(12, 12);
            this.button_Explore.Name = "button_Explore";
            this.button_Explore.Size = new System.Drawing.Size(75, 24);
            this.button_Explore.TabIndex = 1;
            this.button_Explore.Text = "浏览";
            this.button_Explore.UseVisualStyleBackColor = true;
            this.button_Explore.Click += new System.EventHandler(this.button_Explore_Click);
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(99, 12);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(75, 24);
            this.button_Convert.TabIndex = 2;
            this.button_Convert.Text = "转换";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 48);
            this.ControlBox = false;
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.button_Explore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ppt2pdf.net";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Explore;
        private System.Windows.Forms.Button button_Convert;
    }
}

