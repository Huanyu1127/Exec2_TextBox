namespace Q4
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
			this.peronlbl = new System.Windows.Forms.Label();
			this.catlbl = new System.Windows.Forms.Label();
			this.persontxt = new System.Windows.Forms.TextBox();
			this.cartxt = new System.Windows.Forms.TextBox();
			this.totalbtn = new System.Windows.Forms.Button();
			this.totallbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// peronlbl
			// 
			this.peronlbl.AutoSize = true;
			this.peronlbl.Location = new System.Drawing.Point(74, 86);
			this.peronlbl.Name = "peronlbl";
			this.peronlbl.Size = new System.Drawing.Size(29, 12);
			this.peronlbl.TabIndex = 0;
			this.peronlbl.Text = "人數";
			// 
			// catlbl
			// 
			this.catlbl.AutoSize = true;
			this.catlbl.Location = new System.Drawing.Point(230, 86);
			this.catlbl.Name = "catlbl";
			this.catlbl.Size = new System.Drawing.Size(29, 12);
			this.catlbl.TabIndex = 2;
			this.catlbl.Text = "車輛";
			// 
			// persontxt
			// 
			this.persontxt.Location = new System.Drawing.Point(109, 81);
			this.persontxt.Name = "persontxt";
			this.persontxt.Size = new System.Drawing.Size(100, 22);
			this.persontxt.TabIndex = 1;
			// 
			// cartxt
			// 
			this.cartxt.Location = new System.Drawing.Point(267, 81);
			this.cartxt.Name = "cartxt";
			this.cartxt.Size = new System.Drawing.Size(100, 22);
			this.cartxt.TabIndex = 3;
			// 
			// totalbtn
			// 
			this.totalbtn.Location = new System.Drawing.Point(336, 266);
			this.totalbtn.Name = "totalbtn";
			this.totalbtn.Size = new System.Drawing.Size(75, 23);
			this.totalbtn.TabIndex = 5;
			this.totalbtn.Text = "總費用";
			this.totalbtn.UseVisualStyleBackColor = true;
			this.totalbtn.Click += new System.EventHandler(this.totalbtn_Click);
			// 
			// totallbl
			// 
			this.totallbl.AutoEllipsis = true;
			this.totallbl.Location = new System.Drawing.Point(107, 162);
			this.totallbl.Name = "totallbl";
			this.totallbl.Size = new System.Drawing.Size(260, 61);
			this.totallbl.TabIndex = 4;
			this.totallbl.Text = "totallbl";
			this.totallbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 332);
			this.Controls.Add(this.totallbl);
			this.Controls.Add(this.totalbtn);
			this.Controls.Add(this.cartxt);
			this.Controls.Add(this.persontxt);
			this.Controls.Add(this.catlbl);
			this.Controls.Add(this.peronlbl);
			this.Name = "Form1";
			this.Text = "入場費用計算規則";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label peronlbl;
		private System.Windows.Forms.Label catlbl;
		private System.Windows.Forms.TextBox persontxt;
		private System.Windows.Forms.TextBox cartxt;
		private System.Windows.Forms.Button totalbtn;
		private System.Windows.Forms.Label totallbl;
	}
}

