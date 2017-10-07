namespace Plov
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waterTapOff = new System.Windows.Forms.RadioButton();
            this.waterTapOn = new System.Windows.Forms.RadioButton();
            this.washVeg = new System.Windows.Forms.Button();
            this.washRice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countVeg = new System.Windows.Forms.NumericUpDown();
            this.countMeat = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stoveIsOff = new System.Windows.Forms.RadioButton();
            this.stoveIsOn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addMeat = new System.Windows.Forms.Button();
            this.addVeg = new System.Windows.Forms.Button();
            this.fry = new System.Windows.Forms.Button();
            this.addSpice = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addRice = new System.Windows.Forms.Button();
            this.cutMeat = new System.Windows.Forms.Button();
            this.cutVeg = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.eat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countVeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMeat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waterTapOff);
            this.groupBox1.Controls.Add(this.waterTapOn);
            this.groupBox1.Controls.Add(this.washVeg);
            this.groupBox1.Controls.Add(this.washRice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water Tap";
            // 
            // waterTapOff
            // 
            this.waterTapOff.AutoSize = true;
            this.waterTapOff.Location = new System.Drawing.Point(7, 60);
            this.waterTapOff.Name = "waterTapOff";
            this.waterTapOff.Size = new System.Drawing.Size(39, 17);
            this.waterTapOff.TabIndex = 8;
            this.waterTapOff.TabStop = true;
            this.waterTapOff.Text = "Off";
            this.waterTapOff.UseVisualStyleBackColor = true;
            this.waterTapOff.CheckedChanged += new System.EventHandler(this.waterTapOff_CheckedChanged);
            // 
            // waterTapOn
            // 
            this.waterTapOn.AutoSize = true;
            this.waterTapOn.Location = new System.Drawing.Point(7, 24);
            this.waterTapOn.Name = "waterTapOn";
            this.waterTapOn.Size = new System.Drawing.Size(39, 17);
            this.waterTapOn.TabIndex = 7;
            this.waterTapOn.TabStop = true;
            this.waterTapOn.Text = "On";
            this.waterTapOn.UseVisualStyleBackColor = true;
            this.waterTapOn.CheckedChanged += new System.EventHandler(this.waterTapOn_CheckedChanged);
            // 
            // washVeg
            // 
            this.washVeg.Location = new System.Drawing.Point(49, 19);
            this.washVeg.Name = "washVeg";
            this.washVeg.Size = new System.Drawing.Size(75, 23);
            this.washVeg.TabIndex = 5;
            this.washVeg.Text = "Wash Veg";
            this.washVeg.UseVisualStyleBackColor = true;
            this.washVeg.Click += new System.EventHandler(this.washVeg_Click);
            // 
            // washRice
            // 
            this.washRice.Location = new System.Drawing.Point(49, 60);
            this.washRice.Name = "washRice";
            this.washRice.Size = new System.Drawing.Size(75, 23);
            this.washRice.TabIndex = 6;
            this.washRice.Text = "Wash Rice";
            this.washRice.UseVisualStyleBackColor = true;
            this.washRice.Click += new System.EventHandler(this.washRice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countVeg);
            this.groupBox2.Controls.Add(this.countMeat);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Location = new System.Drawing.Point(207, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count";
            // 
            // countVeg
            // 
            this.countVeg.Location = new System.Drawing.Point(17, 45);
            this.countVeg.Name = "countVeg";
            this.countVeg.Size = new System.Drawing.Size(97, 20);
            this.countVeg.TabIndex = 9;
            // 
            // countMeat
            // 
            this.countMeat.Location = new System.Drawing.Point(17, 19);
            this.countMeat.Name = "countMeat";
            this.countMeat.Size = new System.Drawing.Size(97, 20);
            this.countMeat.TabIndex = 8;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(17, 71);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 7;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stoveIsOff);
            this.groupBox3.Controls.Add(this.stoveIsOn);
            this.groupBox3.Location = new System.Drawing.Point(207, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stove";
            // 
            // stoveIsOff
            // 
            this.stoveIsOff.AutoSize = true;
            this.stoveIsOff.Location = new System.Drawing.Point(7, 53);
            this.stoveIsOff.Name = "stoveIsOff";
            this.stoveIsOff.Size = new System.Drawing.Size(39, 17);
            this.stoveIsOff.TabIndex = 1;
            this.stoveIsOff.TabStop = true;
            this.stoveIsOff.Text = "Off";
            this.stoveIsOff.UseVisualStyleBackColor = true;
            this.stoveIsOff.CheckedChanged += new System.EventHandler(this.stoveIsOff_CheckedChanged);
            // 
            // stoveIsOn
            // 
            this.stoveIsOn.AutoSize = true;
            this.stoveIsOn.Location = new System.Drawing.Point(7, 24);
            this.stoveIsOn.Name = "stoveIsOn";
            this.stoveIsOn.Size = new System.Drawing.Size(39, 17);
            this.stoveIsOn.TabIndex = 0;
            this.stoveIsOn.TabStop = true;
            this.stoveIsOn.Text = "On";
            this.stoveIsOn.UseVisualStyleBackColor = true;
            this.stoveIsOn.CheckedChanged += new System.EventHandler(this.stoveIsOn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addMeat);
            this.groupBox4.Controls.Add(this.addVeg);
            this.groupBox4.Controls.Add(this.fry);
            this.groupBox4.Controls.Add(this.addSpice);
            this.groupBox4.Location = new System.Drawing.Point(12, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 107);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pan";
            // 
            // addMeat
            // 
            this.addMeat.Location = new System.Drawing.Point(6, 19);
            this.addMeat.Name = "addMeat";
            this.addMeat.Size = new System.Drawing.Size(75, 23);
            this.addMeat.TabIndex = 10;
            this.addMeat.Text = "Add Meat";
            this.addMeat.UseVisualStyleBackColor = true;
            this.addMeat.Click += new System.EventHandler(this.addMeat_Click);
            // 
            // addVeg
            // 
            this.addVeg.Location = new System.Drawing.Point(6, 48);
            this.addVeg.Name = "addVeg";
            this.addVeg.Size = new System.Drawing.Size(75, 23);
            this.addVeg.TabIndex = 11;
            this.addVeg.Text = "Add Veg";
            this.addVeg.UseVisualStyleBackColor = true;
            this.addVeg.Click += new System.EventHandler(this.addVeg_Click);
            // 
            // fry
            // 
            this.fry.Location = new System.Drawing.Point(88, 47);
            this.fry.Name = "fry";
            this.fry.Size = new System.Drawing.Size(75, 23);
            this.fry.TabIndex = 12;
            this.fry.Text = "Fry";
            this.fry.Click += new System.EventHandler(this.fry_Click);
            // 
            // addSpice
            // 
            this.addSpice.Location = new System.Drawing.Point(6, 77);
            this.addSpice.Name = "addSpice";
            this.addSpice.Size = new System.Drawing.Size(75, 23);
            this.addSpice.TabIndex = 12;
            this.addSpice.Text = "Add Spice";
            this.addSpice.UseVisualStyleBackColor = true;
            this.addSpice.Click += new System.EventHandler(this.addSpice_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addRice);
            this.groupBox5.Location = new System.Drawing.Point(12, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rice";
            // 
            // addRice
            // 
            this.addRice.Location = new System.Drawing.Point(6, 19);
            this.addRice.Name = "addRice";
            this.addRice.Size = new System.Drawing.Size(75, 23);
            this.addRice.TabIndex = 0;
            this.addRice.Text = "Add Rice";
            this.addRice.UseVisualStyleBackColor = true;
            this.addRice.Click += new System.EventHandler(this.addRice_Click);
            // 
            // cutMeat
            // 
            this.cutMeat.Location = new System.Drawing.Point(344, 31);
            this.cutMeat.Name = "cutMeat";
            this.cutMeat.Size = new System.Drawing.Size(75, 23);
            this.cutMeat.TabIndex = 8;
            this.cutMeat.Text = "Cut Meat";
            this.cutMeat.UseVisualStyleBackColor = true;
            this.cutMeat.Click += new System.EventHandler(this.cutMeat_Click);
            // 
            // cutVeg
            // 
            this.cutVeg.Location = new System.Drawing.Point(344, 72);
            this.cutVeg.Name = "cutVeg";
            this.cutVeg.Size = new System.Drawing.Size(75, 23);
            this.cutVeg.TabIndex = 9;
            this.cutVeg.Text = "Cut Veg";
            this.cutVeg.UseVisualStyleBackColor = true;
            this.cutVeg.Click += new System.EventHandler(this.cutVeg_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(389, 179);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 14;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // eat
            // 
            this.eat.Location = new System.Drawing.Point(344, 225);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(151, 85);
            this.eat.TabIndex = 15;
            this.eat.Text = "Eat!";
            this.eat.UseVisualStyleBackColor = true;
            this.eat.Click += new System.EventHandler(this.eat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 342);
            this.Controls.Add(this.eat);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.cutVeg);
            this.Controls.Add(this.cutMeat);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countVeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMeat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button washVeg;
        private System.Windows.Forms.Button washRice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addRice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addMeat;
        private System.Windows.Forms.Button addVeg;
        private System.Windows.Forms.Button addSpice;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cutMeat;
        private System.Windows.Forms.Button cutVeg;
        private System.Windows.Forms.Button fry;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button eat;
        private System.Windows.Forms.RadioButton waterTapOff;
        private System.Windows.Forms.RadioButton waterTapOn;
        private System.Windows.Forms.RadioButton stoveIsOff;
        private System.Windows.Forms.RadioButton stoveIsOn;
        private System.Windows.Forms.NumericUpDown countVeg;
        private System.Windows.Forms.NumericUpDown countMeat;
    }
}

