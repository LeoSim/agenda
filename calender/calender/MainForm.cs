/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2017-09-17
 * Time: 오후 2:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calender
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int year = 2017;
		int month = 7;	
		
		void buttons(Button[] b)
		{
			b[0] = button1;
			b[1] = button2;
			b[2] = button3;
			b[3] = button4;
			b[4] = button5;
			b[5] = button6;
			b[6] = button7;
			b[7] = button8;
			b[8] = button9;
			b[9] = button10;
			b[10] = button11;
			b[11] = button12;
			b[12] = button13;
			b[13] = button14;
			b[14] = button15;
			b[15] = button16;
			b[16] = button17;
			b[17] = button18;
			b[18] = button19;
			b[19] = button20;
			b[20] = button21;
			b[21] = button22;
			b[22] = button23;
			b[23] = button24;
			b[24] = button25;
			b[25] = button26;
			b[26] = button27;
			b[27] = button28;
			b[28] = button29;
			b[29] = button30;
			b[30] = button31;
			b[31] = button32;
			b[32] = button33;
			b[33] = button34;
			b[34] = button35;
			b[35] = button36;
			b[36] = button37;
			b[37] = button38;
			b[38] = button39;
			b[39] = button40;
			b[40] = button41;
			b[41] = button42;
		}
		
		int day_of_week(int q, int m, int y)//q is day of month, m is the month, y is the year 
		{
			int h;
			h = (q + (13*(m+1)/5) + (y%100) + ((y%100)/4) + ((y/100)/4) + 5*(y/100))%7;
			if(m == 13 || m == 14)
			{
				if(h == 0)
					h = 6;
				else
					h--;
				
			}
			return h;
		}
		
		void clndr(int curryear, int currmonth)
		{
			int a = 1;
			int firstday = 1;
			int day_in_months;
			int firstdate;//(0 = Saturday, 1 = Sunday, 2 = Monday, ..., 6  = Friday), first date of the month
			int[] lmonths = {3,5,7,8,10,12,13};//january is 13 feburary is 14 but still march is 3
			int[] smonths = {4,6,9,11};
			int?[] calendar = new int?[42];
			Button[] dates = new Button[42];
			buttons(dates);
			Array.Clear(calendar, 0, 41);
			if(currmonth != 14 && currmonth != 13)
				label8.Text = currmonth.ToString();
			else if(currmonth == 14)
				label8.Text = "2";
			else if(currmonth == 13)
				label8.Text = "1";
			
			label9.Text = curryear.ToString();
			
			if(Array.IndexOf(lmonths, currmonth) != -1)
			{
				day_in_months = 31;
				firstdate = day_of_week(firstday, currmonth, curryear);
				for(int x = (firstdate - 1); x < (day_in_months + x) && a <= day_in_months; x++)
				{
					if(a > day_in_months)
					{
						break;
					}
					if(x == -1)
					{
						x = 6;
					}
					
					calendar[x] = a++;
				}
			}
			else if(Array.IndexOf(smonths, currmonth) != -1)
			{
				day_in_months = 30;
				firstdate = day_of_week(firstday, currmonth, curryear);
				for(int x = (firstdate - 1); x < (day_in_months + x); x++)
				{
					if(a > day_in_months)
					{
						break;
					}
					if(x == -1)
					{
						x = 7;
					}
					
					calendar[x] = a++;
				}
			}
			
			else if(currmonth == 14)
			{	
				if(curryear%4 == 0)
					day_in_months = 29;
				else
					day_in_months = 28;
				
				firstdate = day_of_week(firstday, currmonth, curryear);
				
				for(int x = (firstdate - 1); x < (day_in_months + x) && a <= day_in_months; x++)
				{
					if(a > day_in_months)
					{
						break;
					}
					if(x == -1)
					{
						x = 7;
					}
					
					calendar[x] = a++;
				}
			}
			
			/*for(firstday = 0; firstday < calendar.Length; firstday++)
			{
				calendar[firstday] = (firstday+1);
			}*/
			
			for(int x = 0; x < calendar.Length; x++)
			{
				dates[x].Text = calendar[x].ToString();
			}
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			clndr(year, month);
			
			
			
		}
		void Button43Click(object sender, EventArgs e)
		{
			if(month < 14)
				month++;
			else if(month == 14)
				month = 3;
			if(month == 13)
				year++;
			
			clndr(year, month);
		}
		void Button44Click(object sender, EventArgs e)
		{
			if(month > 3)
				month--;
			else if(month == 3)
				month = 14;
			if(month == 12)
				year--;
			
			clndr(year, month);
		}
	}
}
