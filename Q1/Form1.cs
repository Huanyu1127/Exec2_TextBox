using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	//輸入數值是否在[1, 99]
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void inputbtn_Click(object sender, EventArgs e)
		{
			int number = 0;
			try
			{
				number = GetNumbers();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			string result = string.Empty;
			try
			{
				result = RightRange(number);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return ;
			}
		}

		private string RightRange(int number)
		{
			if (number <= 0 || number > 99)
			{
				throw new Exception("請輸入1~99的數字");
			}
			return MessageBox.Show($"您輸入的是{number},為[1,99]正確","訊息",MessageBoxButtons.OK).ToString();
		}

		private int GetNumbers()
		{
			string value = inputTxT.Text;
			bool isInt = int.TryParse(value, out int numbers);
			return isInt ? numbers : throw new Exception("請輸入數字");
		}
	}
}
