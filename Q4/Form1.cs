using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
//	//入場費用計算規則:
//每一個團體要進入園區時,可以用比較便宜的團體, 限制是只能採
//取以下兩種裡的一種, 不能拆分成兩個團體
//按車輛計費:
//每部車收 200 元, 不管裡面坐多少乘客
//按人頭計費:
//每人收 60 元, 無論多少部車

	//負數
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			totallbl.Text=string.Empty;
		}

		private void totalbtn_Click(object sender, EventArgs e)
		{
			int person = 0;
			int car = 0;
			try
			{
				person = GetPerson();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			try
			{
				car = GetCar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			string price = GetPrice(person, car);

			DisplayPrice(price);
		}
		private int GetNumber(TextBox control,string title)
		{
			string value = control.Text;
			bool isInt = int.TryParse(value, out int numbers);
			numbers =isInt ? numbers : throw new Exception($"{title}未輸入數字");
			return numbers >= 0 ? numbers : throw new Exception($"{title}不可為負數");
		}
		private int GetPerson()
		{
			TextBox person = persontxt;
			string title="人數";
			return GetNumber(person,title);
		}
		private int GetCar()
		{
			TextBox person = cartxt;
			string title = "車輛";
			return GetNumber(person, title);
		}
		private string GetPrice(int person, int car)
		{
			string result=string.Empty;
			result = $"人數 {person * 60 } 元 + 車輛 {car * 200} 元 = 總金額 {person * 60 + car * 200} 元";
			return result;
		}
		private void DisplayPrice(string price)
		{
			totallbl.Text = price;
			MessageBox.Show(price);
		}
		
	}
}


