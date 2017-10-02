namespace Lab2
{
    partial class a
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawPlane = new System.Windows.Forms.Button();
            this.selectColor = new System.Windows.Forms.Button();
            this.drawF = new System.Windows.Forms.Button();
            this.textMSpeed = new System.Windows.Forms.TextBox();
            this.textMFuel = new System.Windows.Forms.TextBox();
            this.textW = new System.Windows.Forms.TextBox();
            this.checkBomb = new System.Windows.Forms.CheckBox();
            this.checkGun = new System.Windows.Forms.CheckBox();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.butMove = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textMaxSpeed = new System.Windows.Forms.Label();
            this.textMaxFuel = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.Label();
            this.selectColor1 = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.textMHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawPlane
            // 
            this.drawPlane.Location = new System.Drawing.Point(108, 280);
            this.drawPlane.Name = "drawPlane";
            this.drawPlane.Size = new System.Drawing.Size(75, 23);
            this.drawPlane.TabIndex = 0;
            this.drawPlane.Text = "Draw Plane";
            this.drawPlane.UseVisualStyleBackColor = true;
            this.drawPlane.Click += new System.EventHandler(this.drawPlane_Click);
            // 
            // selectColor
            // 
            this.selectColor.Location = new System.Drawing.Point(108, 309);
            this.selectColor.Name = "selectColor";
            this.selectColor.Size = new System.Drawing.Size(75, 23);
            this.selectColor.TabIndex = 1;
            this.selectColor.Text = "Select color";
            this.selectColor.UseVisualStyleBackColor = true;
            this.selectColor.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // drawF
            // 
            this.drawF.Location = new System.Drawing.Point(267, 279);
            this.drawF.Name = "drawF";
            this.drawF.Size = new System.Drawing.Size(75, 23);
            this.drawF.TabIndex = 2;
            this.drawF.Text = "Draw Fighter";
            this.drawF.UseVisualStyleBackColor = true;
            this.drawF.Click += new System.EventHandler(this.drawF_Click);
            // 
            // textMSpeed
            // 
            this.textMSpeed.Location = new System.Drawing.Point(79, 210);
            this.textMSpeed.Name = "textMSpeed";
            this.textMSpeed.Size = new System.Drawing.Size(100, 20);
            this.textMSpeed.TabIndex = 3;
            // 
            // textMFuel
            // 
            this.textMFuel.Location = new System.Drawing.Point(79, 242);
            this.textMFuel.Name = "textMFuel";
            this.textMFuel.Size = new System.Drawing.Size(100, 20);
            this.textMFuel.TabIndex = 4;
            // 
            // textW
            // 
            this.textW.Location = new System.Drawing.Point(242, 210);
            this.textW.Name = "textW";
            this.textW.Size = new System.Drawing.Size(100, 20);
            this.textW.TabIndex = 5;
            // 
            // checkBomb
            // 
            this.checkBomb.AutoSize = true;
            this.checkBomb.Location = new System.Drawing.Point(398, 213);
            this.checkBomb.Name = "checkBomb";
            this.checkBomb.Size = new System.Drawing.Size(53, 17);
            this.checkBomb.TabIndex = 6;
            this.checkBomb.Text = "Bomb";
            this.checkBomb.UseVisualStyleBackColor = true;
            // 
            // checkGun
            // 
            this.checkGun.AutoSize = true;
            this.checkGun.Location = new System.Drawing.Point(398, 242);
            this.checkGun.Name = "checkGun";
            this.checkGun.Size = new System.Drawing.Size(46, 17);
            this.checkGun.TabIndex = 7;
            this.checkGun.Text = "Gun";
            this.checkGun.UseVisualStyleBackColor = true;
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(45, 23);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(433, 172);
            this.drawBox.TabIndex = 8;
            this.drawBox.TabStop = false;
            // 
            // butMove
            // 
            this.butMove.Location = new System.Drawing.Point(527, 100);
            this.butMove.Name = "butMove";
            this.butMove.Size = new System.Drawing.Size(75, 23);
            this.butMove.TabIndex = 9;
            this.butMove.Text = "Move";
            this.butMove.UseVisualStyleBackColor = true;
            this.butMove.Click += new System.EventHandler(this.butMove_Click);
            // 
            // textMaxSpeed
            // 
            this.textMaxSpeed.AutoSize = true;
            this.textMaxSpeed.Location = new System.Drawing.Point(12, 214);
            this.textMaxSpeed.Name = "textMaxSpeed";
            this.textMaxSpeed.Size = new System.Drawing.Size(61, 13);
            this.textMaxSpeed.TabIndex = 10;
            this.textMaxSpeed.Text = "Max Speed";
            // 
            // textMaxFuel
            // 
            this.textMaxFuel.AutoSize = true;
            this.textMaxFuel.Location = new System.Drawing.Point(12, 246);
            this.textMaxFuel.Name = "textMaxFuel";
            this.textMaxFuel.Size = new System.Drawing.Size(27, 13);
            this.textMaxFuel.TabIndex = 11;
            this.textMaxFuel.Text = "Fuel";
            // 
            // textWeight
            // 
            this.textWeight.AutoSize = true;
            this.textWeight.Location = new System.Drawing.Point(195, 214);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(41, 13);
            this.textWeight.TabIndex = 12;
            this.textWeight.Text = "Weight";
            // 
            // selectColor1
            // 
            this.selectColor1.Location = new System.Drawing.Point(256, 309);
            this.selectColor1.Name = "selectColor1";
            this.selectColor1.Size = new System.Drawing.Size(104, 23);
            this.selectColor1.TabIndex = 13;
            this.selectColor1.Text = "Select color1";
            this.selectColor1.UseVisualStyleBackColor = true;
            this.selectColor1.Click += new System.EventHandler(this.selectColor1_Click);
            // 
            // textMHeight
            // 
            this.textMHeight.Location = new System.Drawing.Point(511, 240);
            this.textMHeight.Name = "textMHeight";
            this.textMHeight.Size = new System.Drawing.Size(100, 20);
            this.textMHeight.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Max Height ( 0-100 )";
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMHeight);
            this.Controls.Add(this.selectColor1);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textMaxFuel);
            this.Controls.Add(this.textMaxSpeed);
            this.Controls.Add(this.butMove);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.checkGun);
            this.Controls.Add(this.checkBomb);
            this.Controls.Add(this.textW);
            this.Controls.Add(this.textMFuel);
            this.Controls.Add(this.textMSpeed);
            this.Controls.Add(this.drawF);
            this.Controls.Add(this.selectColor);
            this.Controls.Add(this.drawPlane);
            this.Name = "a";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawPlane;
        private System.Windows.Forms.Button selectColor;
        private System.Windows.Forms.Button drawF;
        private System.Windows.Forms.TextBox textMSpeed;
        private System.Windows.Forms.TextBox textMFuel;
        private System.Windows.Forms.TextBox textW;
        private System.Windows.Forms.CheckBox checkBomb;
        private System.Windows.Forms.CheckBox checkGun;
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.Button butMove;
        private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label textMaxSpeed;
		private System.Windows.Forms.Label textMaxFuel;
		private System.Windows.Forms.Label textWeight;
		private System.Windows.Forms.Button selectColor1;
		private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.TextBox textMHeight;
		private System.Windows.Forms.Label label1;
    }
}

