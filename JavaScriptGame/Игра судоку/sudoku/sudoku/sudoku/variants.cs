/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 11.07.2012
 * Time: 7:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of variants.
	/// </summary>
	public partial class variants : Form
	{
		private string []slognost={"Легкий","Средний", "Ад...!!"};
		private int  flog=0;
		private int index=0;
		private bool cl=false;
        private bool clos;
		public variants()
		{
			//
			// ThSystem.Drawing.Bitmape InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
		
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(cl==true)
			{
			MainForm MAns=new MainForm(struck[index],label1.Text);
			this.Hide();
			if(MAns.ShowDialog()== DialogResult.OK)
			{
				this.Close();
				
			}else if(MAns.DialogResult== DialogResult.No)
			{
				open_TO_file  to_file=new open_TO_file();
				to_file.Open_ToGoo_mas("YRAven-Slojnosti.tt");
				to_file.Resojes(label1.Text);
				mas_ok_pz(to_file.SL);
				this.Visible=true;
			}
			}else{MessageBox.Show("Вы не выбрали карту"," ощибка");}
			
			
		}
		void VariantsLoad(object sender, EventArgs e)
		{
			menu men=new menu();
			if(men.ShowDialog()==DialogResult.Cancel)
			{
                clos = true;
				this.Close();
			}else if(men.DialogResult== DialogResult.OK)
			{
				 open_TO_file file = new open_TO_file();
				file.Open_ToGoo_mas("YRAven-Slojnosti.tt");
				file.Resojes(label1.Text);
				mas_ok_pz(file.SL);
			
			}
		}
		void mas_ok_pz(string str)
		{

			string []mas_pazl=new string[13];
			for(int i=0,t=1;i<str.Length;i++)
			{
				if(!str[i].Equals(','))
					mas_pazl[t]+=str[i].ToString();
				else{t++;}
				
			}
			
				for(int b=1;b<=12;b++)
				{
				if(!RB[b].Name.Equals(mas_pazl[b]))
				{RB[b].Enabled=false;}else{RB[b].Enabled=true;}
				}
			
			
		}
		void Label2Click(object sender, EventArgs e)
		{
			flog++;
			
			 open_TO_file file = new open_TO_file();
			file.Open_ToGoo_mas("YRAven-Slojnosti.tt");
			if(flog==3)
				flog=0;
			label1.Text=slognost[flog];
			file.Resojes(label1.Text);
			
				mas_ok_pz(file.SL);
			
		}
		void RB_Click(object sender, EventArgs e)
		{			
			for(int i=1;i<=12;i++)
			{
				if (sender as RadioButton == RB[i])
				{
					index=Convert.ToInt32(RB[i].Text);
					break;
				}
			}
			if(label1.Text=="Средний")
			{
				index=index+11;
			}else if(label1.Text=="Ад...!!")
			{
				index=index+21;
			}
		cl=true;
			
		}
		void Label3Click(object sender, EventArgs e)
		{
			 open_TO_file file = new open_TO_file();
			file.Open_ToGoo_mas("YRAven-Slojnosti.tt");
			
			flog--;
			if(flog<0)
				flog=2;
			label1.Text=slognost[flog];
			file.Resojes(label1.Text);
			
				mas_ok_pz(file.SL);
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public string []SSR
		{
			get{return struck;}
		}		
		void VariantsFormClosed(object sender, FormClosedEventArgs e)
		{
            if (clos == true)
            { this.DialogResult = DialogResult.No; }
            else
            {
                DialogResult dr = MessageBox.Show("вы уверены что хотите завершить игру.!?", "Выход", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                { }
                { this.DialogResult = DialogResult.No; }
            }
		}
	}
}
