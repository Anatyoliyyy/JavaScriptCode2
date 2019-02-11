/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 11.07.2012
 * Time: 7:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sudoku
{
	partial class variants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(variants));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(176, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Легкий";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(282, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = ">>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(70, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "<<";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Label3Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(133, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(271, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // radioButton1
            // 
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.Location = new System.Drawing.Point(29, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 64);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton2.BackgroundImage")));
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.Location = new System.Drawing.Point(116, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 64);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton3.BackgroundImage")));
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton3.Image = ((System.Drawing.Image)(resources.GetObject("radioButton3.Image")));
            this.radioButton3.Location = new System.Drawing.Point(198, 122);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 64);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton4.BackgroundImage")));
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton4.Image = ((System.Drawing.Image)(resources.GetObject("radioButton4.Image")));
            this.radioButton4.Location = new System.Drawing.Point(285, 122);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 64);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton5.BackgroundImage")));
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton5.Image = ((System.Drawing.Image)(resources.GetObject("radioButton5.Image")));
            this.radioButton5.Location = new System.Drawing.Point(24, 206);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(86, 64);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton6.BackgroundImage")));
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton6.Image = ((System.Drawing.Image)(resources.GetObject("radioButton6.Image")));
            this.radioButton6.Location = new System.Drawing.Point(116, 206);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(86, 64);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton7.BackgroundImage")));
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton7.Image = ((System.Drawing.Image)(resources.GetObject("radioButton7.Image")));
            this.radioButton7.Location = new System.Drawing.Point(198, 201);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(86, 64);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton8.BackgroundImage")));
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton8.Image = ((System.Drawing.Image)(resources.GetObject("radioButton8.Image")));
            this.radioButton8.Location = new System.Drawing.Point(285, 201);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(86, 64);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton9.BackgroundImage")));
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton9.Image = ((System.Drawing.Image)(resources.GetObject("radioButton9.Image")));
            this.radioButton9.Location = new System.Drawing.Point(24, 291);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(86, 64);
            this.radioButton9.TabIndex = 16;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton10.BackgroundImage")));
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton10.Image = ((System.Drawing.Image)(resources.GetObject("radioButton10.Image")));
            this.radioButton10.Location = new System.Drawing.Point(116, 291);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(86, 64);
            this.radioButton10.TabIndex = 17;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton11
            // 
            this.radioButton11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton11.BackgroundImage")));
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton11.Image = ((System.Drawing.Image)(resources.GetObject("radioButton11.Image")));
            this.radioButton11.Location = new System.Drawing.Point(198, 291);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(86, 64);
            this.radioButton11.TabIndex = 18;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.Click += new System.EventHandler(this.RB_Click);
            // 
            // radioButton12
            // 
            this.radioButton12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton12.BackgroundImage")));
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.radioButton12.Image = ((System.Drawing.Image)(resources.GetObject("radioButton12.Image")));
            this.radioButton12.Location = new System.Drawing.Point(285, 291);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(86, 64);
            this.radioButton12.TabIndex = 19;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.Click += new System.EventHandler(this.RB_Click);
            //
            //struck
            //
            this.struck[1] = "[00]";
            this.struck[2] = "[01]";
            this.struck[3] = "[02]";
            this.struck[4] = "[03]";
            this.struck[5] = "[04]";
            this.struck[6] = "[05]";
            this.struck[7] = "[06]";
            this.struck[8] = "[07]";
            this.struck[9] = "[08]";
            this.struck[10] = "[09]";
            this.struck[11] = "[10]";
            this.struck[12] = "[11]";


            this.struck[13] = "[20]";
            this.struck[14] = "[21]";
            this.struck[15] = "[22]";
            this.struck[16] = "[23]";
            this.struck[17] = "[24]";
            this.struck[18] = "[25]";
            this.struck[19] = "[26]";
            this.struck[20] = "[27]";
            this.struck[21] = "[28]";
            this.struck[22] = "[29]";
            this.struck[23] = "[30]";
            this.struck[24] = "[31]";


            this.struck[25] = "[40]";
            this.struck[26] = "[41]";
            this.struck[27] = "[42]";
            this.struck[28] = "[43]";
            this.struck[29] = "[44]";
            this.struck[30] = "[45]";
            this.struck[31] = "[46]";
            this.struck[32] = "[47]";
            this.struck[33] = "[48]";
            this.struck[34] = "[49]";
            this.struck[35] = "[40]";
            this.struck[36] = "[41]";
            //
            //RB
            //
            RB[1] = radioButton1;
            RB[2] = radioButton2;
            RB[3] = radioButton3;
            RB[4] = radioButton4;
            RB[5] = radioButton5;
            RB[6] = radioButton6;
            RB[7] = radioButton7;
            RB[8] = radioButton8;
            RB[9] = radioButton9;
            RB[10] = radioButton10;
            RB[11] = radioButton11;
            RB[12] = radioButton12;
            // 
            // variants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 444);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Location = new System.Drawing.Point(800, 600);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 482);
            this.Name = "variants";
            this.ShowIcon = false;
            this.Text = "variants";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VariantsFormClosed);
            this.Load += new System.EventHandler(this.VariantsLoad);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.String []struck=new string[37];
		private System.Windows.Forms.RadioButton []RB=new System.Windows.Forms.RadioButton[13];
	}
}
