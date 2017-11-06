namespace Lab2
{
	partial class FormSelectPlane
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelFighter = new System.Windows.Forms.Label();
			this.labelPlane = new System.Windows.Forms.Label();
			this.panelPlane = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.pictureBoxSelectPlane = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panelPlane.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectPlane)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelFighter);
			this.groupBox1.Controls.Add(this.labelPlane);
			this.groupBox1.Location = new System.Drawing.Point(23, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(133, 148);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Plane";
			// 
			// labelFighter
			// 
			this.labelFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFighter.Location = new System.Drawing.Point(12, 94);
			this.labelFighter.Name = "labelFighter";
			this.labelFighter.Size = new System.Drawing.Size(115, 34);
			this.labelFighter.TabIndex = 1;
			this.labelFighter.Text = "Fighter";
			this.labelFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighter_MouseDown);
			// 
			// labelPlane
			// 
			this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelPlane.Location = new System.Drawing.Point(12, 34);
			this.labelPlane.Name = "labelPlane";
			this.labelPlane.Size = new System.Drawing.Size(115, 36);
			this.labelPlane.TabIndex = 0;
			this.labelPlane.Text = "Plane";
			this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
			// 
			// panelPlane
			// 
			this.panelPlane.AllowDrop = true;
			this.panelPlane.Controls.Add(this.labelDopColor);
			this.panelPlane.Controls.Add(this.labelMainColor);
			this.panelPlane.Controls.Add(this.pictureBoxSelectPlane);
			this.panelPlane.Location = new System.Drawing.Point(230, 36);
			this.panelPlane.Name = "panelPlane";
			this.panelPlane.Size = new System.Drawing.Size(235, 256);
			this.panelPlane.TabIndex = 2;
			this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
			this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(68, 193);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(114, 44);
			this.labelDopColor.TabIndex = 2;
			this.labelDopColor.Text = "Dop Color";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(65, 125);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(117, 38);
			this.labelMainColor.TabIndex = 1;
			this.labelMainColor.Text = "Main Color";
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// pictureBoxSelectPlane
			// 
			this.pictureBoxSelectPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxSelectPlane.Location = new System.Drawing.Point(25, 20);
			this.pictureBoxSelectPlane.Name = "pictureBoxSelectPlane";
			this.pictureBoxSelectPlane.Size = new System.Drawing.Size(189, 92);
			this.pictureBoxSelectPlane.TabIndex = 0;
			this.pictureBoxSelectPlane.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel8);
			this.groupBox2.Controls.Add(this.panel7);
			this.groupBox2.Controls.Add(this.panel4);
			this.groupBox2.Controls.Add(this.panel5);
			this.groupBox2.Controls.Add(this.panel6);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(501, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(179, 277);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Colors";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Location = new System.Drawing.Point(96, 210);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(55, 50);
			this.panel8.TabIndex = 1;
			this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Location = new System.Drawing.Point(13, 210);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(55, 50);
			this.panel7.TabIndex = 3;
			this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Yellow;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(96, 154);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(55, 50);
			this.panel4.TabIndex = 1;
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Lime;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Location = new System.Drawing.Point(13, 95);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(55, 50);
			this.panel5.TabIndex = 1;
			this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Location = new System.Drawing.Point(96, 95);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(55, 50);
			this.panel6.TabIndex = 1;
			this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Red;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(13, 151);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(55, 50);
			this.panel3.TabIndex = 2;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new System.Drawing.Point(96, 35);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(55, 50);
			this.panel2.TabIndex = 1;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(13, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(55, 50);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(34, 199);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(121, 33);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnNo
			// 
			this.btnNo.Location = new System.Drawing.Point(35, 260);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(120, 31);
			this.btnNo.TabIndex = 5;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = true;
			// 
			// FormSelectPlane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 321);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panelPlane);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormSelectPlane";
			this.Text = "FormSelectPlane";
			this.groupBox1.ResumeLayout(false);
			this.panelPlane.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectPlane)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelFighter;
		private System.Windows.Forms.Label labelPlane;
		private System.Windows.Forms.Panel panelPlane;
		private System.Windows.Forms.PictureBox pictureBoxSelectPlane;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnNo;
	}
}