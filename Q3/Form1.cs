using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	//經由輸入生日判斷是否已滿 13 歲
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultbtn_Click(object sender, EventArgs e)
		{
			DateTime btddt = new DateTime();
			string result=string.Empty;
			try
			{
				btddt = Getbtd();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			try
			{
				result = GetResult(btddt);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ;
			}
		}

		private string GetResult(DateTime btddt)
		{
			int yearsOld = DateTime.Today.Year - btddt.Year;
			if (btddt > DateTime.Today) throw new Exception("生日不可大於今天");
			return yearsOld >= 13 ? MessageBox.Show($"您的年紀是{yearsOld}歲\r\n大於等於13歲").ToString()
								  : MessageBox.Show($"您的年紀是{yearsOld}歲\r\n小於13歲").ToString();
		}

		private DateTime Getbtd()
		{
			string value = btdTextBox.Text;
			bool isdt = DateTime.TryParse(value, out DateTime btddt);
			return isdt ? btddt : throw new Exception("請輸入西元年/月/日");
		}

		
	}
}
