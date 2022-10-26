namespace Q3
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
			this.resultbtn = new System.Windows.Forms.Button();
			this.btdTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultbtn
			// 
			this.resultbtn.Location = new System.Drawing.Point(204, 184);
			this.resultbtn.Name = "resultbtn";
			this.resultbtn.Size = new System.Drawing.Size(75, 23);
			this.resultbtn.TabIndex = 2;
			this.resultbtn.Text = "結果";
			this.resultbtn.UseVisualStyleBackColor = true;
			this.resultbtn.Click += new System.EventHandler(this.resultbtn_Click);
			// 
			// btdTextBox
			// 
			this.btdTextBox.Location = new System.Drawing.Point(179, 118);
			this.btdTextBox.Name = "btdTextBox";
			this.btdTextBox.Size = new System.Drawing.Size(100, 22);
			this.btdTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "生日";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 291);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btdTextBox);
			this.Controls.Add(this.resultbtn);
			this.MinimumSize = new System.Drawing.Size(418, 330);
			this.Name = "Form1";
			this.Text = "是否滿13歲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultbtn;
		private System.Windows.Forms.TextBox btdTextBox;
		private System.Windows.Forms.Label label1;
	}
}

