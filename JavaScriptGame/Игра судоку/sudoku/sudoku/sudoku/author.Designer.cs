/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 13.07.2012
 * Time: 1:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sudoku
{
	partial class author
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(author));
			this.OK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OK
			// 
			this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
			this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OK.Location = new System.Drawing.Point(361, 440);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(122, 23);
			this.OK.TabIndex = 0;
			this.OK.Text = "Закрыть ";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OKClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(2, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(543, 405);
			this.label1.TabIndex = 1;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// author
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(550, 475);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OK);
			this.Name = "author";
			this.Text = "author";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OK;
	}
}
