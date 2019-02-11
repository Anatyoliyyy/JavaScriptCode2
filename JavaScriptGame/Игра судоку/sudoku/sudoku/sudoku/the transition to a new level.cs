/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 27.07.2012
 * Time: 5:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace sudoku
{
	/// <summary>
	/// Description of the_transition_to_a_new_level.
	/// </summary>
	public partial class the_transition_to_a_new_level : Form
	{
		private string str;
		private string cl;
		public the_transition_to_a_new_level(string znak,string sloj)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			str=znak;
			cl=sloj;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	public	void save ()
		{
			string temp="";
			string temp1=" ";
			string url= string.Format(@"{0}\{1}","file restaet","YRAven-Slojnosti.tt");
			variants varit=new variants();
			open_TO_file filet=new open_TO_file();
			filet.Open_ToGoo_mas("YRAven-Slojnosti.tt");
			for(int i=1;i<=12;i++)
			{
				if(str==varit.SSR[i])
				{
					i++;
					temp="radioButton"+i.ToString();
					break;
				}
			}
			for(int i=0;i<6;i++)
			{
				temp1 +=filet.Mas[i]+"\r\n";
				temp1=temp1.Trim(' ');
				if(filet.Mas[i]==cl)
				{
					
					i=i+1;
					filet.Mas[i]+=',';
					filet.Mas[i]+=temp+",\r\n";
					temp1 +=filet.Mas[i];
				}
			}
			StreamWriter sev=new StreamWriter(url);
			sev.Write(temp1);
			sev.Close();
	
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			save();
			this.DialogResult= DialogResult.OK;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.DialogResult= DialogResult.Retry;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.No;
			save();
		}
		
	}
}
