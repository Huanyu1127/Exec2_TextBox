using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	//輸入日期是否不大於今天
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void inputbtn_Click(object sender, EventArgs e)
		{
			DateTime inputdt = new DateTime();
			try
			{
				inputdt = GetDateTime();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			try
			{
				GetResult(inputdt);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ;
			}
		}

		private string GetResult(DateTime inputdt)
		{
			//if(inputdt > DateTime.Today) throw new Exception("輸入的日期不能大於今天");
			//else { return MessageBox.Show($"您輸入的日期是{inputdt:yyyy,MM,dd}，等於小於今天").ToString(); }

			return inputdt > DateTime.Today ? throw new Exception("輸入的日期不能大於今天") 
											: MessageBox.Show($"您輸入的日期是{inputdt:yyyy年MM月dd日}，等於小於今天").ToString();
		}

		private DateTime GetDateTime()
		{
			string value= inputTextBox.Text;
			bool isDT = DateTime.TryParse(value, out DateTime inputdt);
			return isDT ? inputdt : throw new Exception("請輸入西元年/月/日");
		}

		
	}
}
