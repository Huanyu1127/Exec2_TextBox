namespace Q1
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
			this.inputTxT = new System.Windows.Forms.TextBox();
			this.inputbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// inputTxT
			// 
			this.inputTxT.Location = new System.Drawing.Point(85, 117);
			this.inputTxT.MaxLength = 2;
			this.inputTxT.Name = "inputTxT";
			this.inputTxT.Size = new System.Drawing.Size(100, 22);
			this.inputTxT.TabIndex = 0;
			// 
			// inputbtn
			// 
			this.inputbtn.Location = new System.Drawing.Point(256, 117);
			this.inputbtn.Name = "inputbtn";
			this.inputbtn.Size = new System.Drawing.Size(75, 23);
			this.inputbtn.TabIndex = 1;
			this.inputbtn.Text = "結果";
			this.inputbtn.UseVisualStyleBackColor = true;
			this.inputbtn.Click += new System.EventHandler(this.inputbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 271);
			this.Controls.Add(this.inputbtn);
			this.Controls.Add(this.inputTxT);
			this.MinimumSize = new System.Drawing.Size(428, 310);
			this.Name = "Form1";
			this.Text = "數值[1,99]";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTxT;
		private System.Windows.Forms.Button inputbtn;
	}
}

