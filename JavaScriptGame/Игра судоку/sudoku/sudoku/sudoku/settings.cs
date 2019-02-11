/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 13.07.2012
 * Time: 1:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
	/// <summary>
	/// Description of settings.
	/// </summary>
	public partial class settings : Form
	{
		private bool sa=false;
		public settings()
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
		
		void CencelClick(object sender, EventArgs e)
		{
			this.Close();
			

		}
		
		void SettingsFormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
		public bool TUC
		{
			get {
				return sa;
			}
		}
	}
}
