namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.inputbtn = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputbtn
			// 
			this.inputbtn.Location = new System.Drawing.Point(253, 135);
			this.inputbtn.Name = "inputbtn";
			this.inputbtn.Size = new System.Drawing.Size(75, 23);
			this.inputbtn.TabIndex = 2;
			this.inputbtn.Text = "結果";
			this.inputbtn.UseVisualStyleBackColor = true;
			this.inputbtn.Click += new System.EventHandler(this.inputbtn_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(228, 82);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入西元年/月/日";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 247);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.inputbtn);
			this.MinimumSize = new System.Drawing.Size(423, 286);
			this.Name = "Form1";
			this.Text = "判斷日期是否大於今天";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button inputbtn;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label label1;
	}
}

