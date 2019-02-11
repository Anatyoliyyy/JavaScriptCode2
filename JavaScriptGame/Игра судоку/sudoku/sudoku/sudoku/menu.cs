/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 11.07.2012
 * Time: 7:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of menu.
	/// </summary>
	public partial class menu : Form
	{
		private settings sertt=new settings();
		
		private bool cen=true;
		public menu()
		{
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			this.DialogResult= DialogResult.OK;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			author aut=new author();
			this.Hide();
			if(aut.ShowDialog()== DialogResult.OK)
			{
				this.Visible=true;
				
			}else this.Visible=true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
            DialogResult dr = MessageBox.Show("вы уверены что хотите завершить игру.!?", "Выход", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            { this.DialogResult= DialogResult.Cancel;}
		
			
		}
	}
}
