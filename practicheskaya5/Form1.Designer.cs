﻿namespace practicheskaya5
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
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.curThird = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.curSecond = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.curFirst = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.incValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.allThird = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.allSecond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьЗначеняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(262, 108);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 26);
            this.button6.TabIndex = 16;
            this.button6.Text = "Увеличить на 1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.curThird);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.curSecond);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.curFirst);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(23, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 84);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Итоговые значения";
            // 
            // curThird
            // 
            this.curThird.Location = new System.Drawing.Point(306, 45);
            this.curThird.Name = "curThird";
            this.curThird.ReadOnly = true;
            this.curThird.Size = new System.Drawing.Size(137, 26);
            this.curThird.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Третье ";
            // 
            // curSecond
            // 
            this.curSecond.Location = new System.Drawing.Point(163, 45);
            this.curSecond.Name = "curSecond";
            this.curSecond.ReadOnly = true;
            this.curSecond.Size = new System.Drawing.Size(137, 26);
            this.curSecond.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Второе";
            // 
            // curFirst
            // 
            this.curFirst.Location = new System.Drawing.Point(20, 45);
            this.curFirst.Name = "curFirst";
            this.curFirst.ReadOnly = true;
            this.curFirst.Size = new System.Drawing.Size(137, 26);
            this.curFirst.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Первое ";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(262, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 26);
            this.button5.TabIndex = 15;
            this.button5.Text = "Увеличить на значение";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(262, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(204, 57);
            this.button8.TabIndex = 17;
            this.button8.Text = "Сгенерировать значения";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // incValue
            // 
            this.incValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incValue.Location = new System.Drawing.Point(295, 180);
            this.incValue.Name = "incValue";
            this.incValue.Size = new System.Drawing.Size(137, 26);
            this.incValue.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(318, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Значение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.allThird);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.allSecond);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.allFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(23, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 321);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задать значения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allThird
            // 
            this.allThird.Location = new System.Drawing.Point(30, 198);
            this.allThird.Name = "allThird";
            this.allThird.Size = new System.Drawing.Size(137, 26);
            this.allThird.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Третье ";
            // 
            // allSecond
            // 
            this.allSecond.Location = new System.Drawing.Point(30, 139);
            this.allSecond.Name = "allSecond";
            this.allSecond.Size = new System.Drawing.Size(137, 26);
            this.allSecond.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Второе";
            // 
            // allFirst
            // 
            this.allFirst.Location = new System.Drawing.Point(30, 80);
            this.allFirst.Name = "allFirst";
            this.allFirst.Size = new System.Drawing.Size(137, 26);
            this.allFirst.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьЗначенияToolStripMenuItem,
            this.сгенерироватьЗначеняToolStripMenuItem,
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem,
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // задатьЗначенияToolStripMenuItem
            // 
            this.задатьЗначенияToolStripMenuItem.Name = "задатьЗначенияToolStripMenuItem";
            this.задатьЗначенияToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.задатьЗначенияToolStripMenuItem.Text = "Задать все значения";
            // 
            // сгенерироватьЗначеняToolStripMenuItem
            // 
            this.сгенерироватьЗначеняToolStripMenuItem.Name = "сгенерироватьЗначеняToolStripMenuItem";
            this.сгенерироватьЗначеняToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.сгенерироватьЗначеняToolStripMenuItem.Text = "Сгенерировать значения";
            // 
            // увеличитьВсеЗнчениеНа1ToolStripMenuItem
            // 
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Name = "увеличитьВсеЗнчениеНа1ToolStripMenuItem";
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.увеличитьВсеЗнчениеНа1ToolStripMenuItem.Text = "Увеличить все знчение на 1";
            // 
            // увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem
            // 
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Name = "увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem";
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem.Text = "Увеличить все значения на введенное значение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 507);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.incValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox curThird;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox curSecond;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox curFirst;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox incValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox allThird;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox allSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox allFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьЗначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьЗначеняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьВсеЗнчениеНа1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьВсеЗначенияНаВведенноеЗначениеToolStripMenuItem;
    }
}

