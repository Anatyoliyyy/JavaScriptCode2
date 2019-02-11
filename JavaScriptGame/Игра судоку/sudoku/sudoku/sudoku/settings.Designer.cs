/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 13.07.2012
 * Time: 1:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sudoku
{
	partial class settings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.OK = new System.Windows.Forms.Button();
			this.Cencel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OK
			// 
			this.OK.Location = new System.Drawing.Point(12, 222);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 0;
			this.OK.Text = "ДА";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OKClick);
			// 
			// Cencel
			// 
			this.Cencel.Location = new System.Drawing.Point(119, 222);
			this.Cencel.Name = "Cencel";
			this.Cencel.Size = new System.Drawing.Size(75, 23);
			this.Cencel.TabIndex = 1;
			this.Cencel.Text = "НЕТ";
			this.Cencel.UseVisualStyleBackColor = true;
			this.Cencel.Click += new System.EventHandler(this.CencelClick);
			// 
			// settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 272);
			this.Controls.Add(this.Cencel);
			this.Controls.Add(this.OK);
			this.Name = "settings";
			this.Text = "settings";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFormClosed);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Cencel;
		private System.Windows.Forms.Button OK;
	}
}
