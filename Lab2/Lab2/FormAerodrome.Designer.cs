namespace Lab2
{
	partial class FormAerodrome
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
			this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.butTake = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.pictureBoxTakePlane = new System.Windows.Forms.PictureBox();
			this.butSetPlane = new System.Windows.Forms.Button();
			this.butSetFigther = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAerodrome
			// 
			this.pictureBoxAerodrome.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxAerodrome.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
			this.pictureBoxAerodrome.Size = new System.Drawing.Size(862, 453);
			this.pictureBoxAerodrome.TabIndex = 0;
			this.pictureBoxAerodrome.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.butTake);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.pictureBoxTakePlane);
			this.groupBox1.Location = new System.Drawing.Point(868, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(187, 198);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Take Plane";
			// 
			// butTake
			// 
			this.butTake.Location = new System.Drawing.Point(68, 162);
			this.butTake.Name = "butTake";
			this.butTake.Size = new System.Drawing.Size(104, 30);
			this.butTake.TabIndex = 3;
			this.butTake.Text = "Take";
			this.butTake.UseVisualStyleBackColor = true;
			this.butTake.Click += new System.EventHandler(this.butTake_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "place";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(68, 31);
			this.maskedTextBox1.Mask = "00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
			this.maskedTextBox1.TabIndex = 1;
			// 
			// pictureBoxTakePlane
			// 
			this.pictureBoxTakePlane.Location = new System.Drawing.Point(6, 67);
			this.pictureBoxTakePlane.Name = "pictureBoxTakePlane";
			this.pictureBoxTakePlane.Size = new System.Drawing.Size(175, 89);
			this.pictureBoxTakePlane.TabIndex = 0;
			this.pictureBoxTakePlane.TabStop = false;
			// 
			// butSetPlane
			// 
			this.butSetPlane.Location = new System.Drawing.Point(868, 373);
			this.butSetPlane.Name = "butSetPlane";
			this.butSetPlane.Size = new System.Drawing.Size(110, 29);
			this.butSetPlane.TabIndex = 2;
			this.butSetPlane.Text = "Set Plane";
			this.butSetPlane.UseVisualStyleBackColor = true;
			this.butSetPlane.Click += new System.EventHandler(this.butSetPlane_Click);
			// 
			// butSetFigther
			// 
			this.butSetFigther.Location = new System.Drawing.Point(868, 412);
			this.butSetFigther.Name = "butSetFigther";
			this.butSetFigther.Size = new System.Drawing.Size(110, 29);
			this.butSetFigther.TabIndex = 3;
			this.butSetFigther.Text = "Set Figther";
			this.butSetFigther.UseVisualStyleBackColor = true;
			this.butSetFigther.Click += new System.EventHandler(this.butSetFigther_Click);
			// 
			// FormAerodrome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 453);
			this.Controls.Add(this.butSetFigther);
			this.Controls.Add(this.butSetPlane);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxAerodrome);
			this.Name = "FormAerodrome";
			this.Text = "FormAerodrome";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAerodrome;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button butTake;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.PictureBox pictureBoxTakePlane;
		private System.Windows.Forms.Button butSetPlane;
		private System.Windows.Forms.Button butSetFigther;
	}
}