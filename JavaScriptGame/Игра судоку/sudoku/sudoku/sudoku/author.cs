/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 13.07.2012
 * Time: 1:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of author.
	/// </summary>
	public partial class author : Form
	{
		public author()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OKClick(object sender, EventArgs e)
		{
				
			this.DialogResult= DialogResult.OK;
		}
	}
}
