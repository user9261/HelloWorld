namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.helloButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.helloButton.Location = new System.Drawing.Point(110, 309);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(277, 88);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "クリック！";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.HelloButtonClicked);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.helloLabel.Location = new System.Drawing.Point(161, 123);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(127, 35);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "???????";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 491);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label helloLabel;
    }
}

