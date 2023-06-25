namespace stolyarov_36_1_Dates
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
            this.DateNow = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Formats = new System.Windows.Forms.Button();
            this.CkeckPerf = new System.Windows.Forms.Button();
            this.CheckPerf2 = new System.Windows.Forms.Button();
            this.Plus7Days = new System.Windows.Forms.Button();
            this.DateDiff = new System.Windows.Forms.Button();
            this.DateDiff2 = new System.Windows.Forms.Button();
            this.CheckYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateNow
            // 
            this.DateNow.Location = new System.Drawing.Point(67, 100);
            this.DateNow.Name = "DateNow";
            this.DateNow.Size = new System.Drawing.Size(229, 32);
            this.DateNow.TabIndex = 0;
            this.DateNow.Text = "Текущая дата";
            this.DateNow.UseVisualStyleBackColor = true;
            this.DateNow.Click += new System.EventHandler(this.DateNow_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(375, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 407);
            this.listBox1.TabIndex = 1;
            // 
            // Formats
            // 
            this.Formats.Location = new System.Drawing.Point(514, 0);
            this.Formats.Name = "Formats";
            this.Formats.Size = new System.Drawing.Size(174, 32);
            this.Formats.TabIndex = 2;
            this.Formats.Text = "Форматы даты и времени";
            this.Formats.UseVisualStyleBackColor = true;
            this.Formats.Click += new System.EventHandler(this.Formats_Click);
            // 
            // CkeckPerf
            // 
            this.CkeckPerf.Location = new System.Drawing.Point(67, 138);
            this.CkeckPerf.Name = "CkeckPerf";
            this.CkeckPerf.Size = new System.Drawing.Size(229, 32);
            this.CkeckPerf.TabIndex = 3;
            this.CkeckPerf.Text = " Измерение производительности 1";
            this.CkeckPerf.UseVisualStyleBackColor = true;
            this.CkeckPerf.Click += new System.EventHandler(this.CkeckPerf_Click);
            // 
            // CheckPerf2
            // 
            this.CheckPerf2.Location = new System.Drawing.Point(67, 176);
            this.CheckPerf2.Name = "CheckPerf2";
            this.CheckPerf2.Size = new System.Drawing.Size(229, 32);
            this.CheckPerf2.TabIndex = 4;
            this.CheckPerf2.Text = " Измерение производительности 2";
            this.CheckPerf2.UseVisualStyleBackColor = true;
            this.CheckPerf2.Click += new System.EventHandler(this.CheckPerf2_Click);
            // 
            // Plus7Days
            // 
            this.Plus7Days.Location = new System.Drawing.Point(67, 214);
            this.Plus7Days.Name = "Plus7Days";
            this.Plus7Days.Size = new System.Drawing.Size(229, 32);
            this.Plus7Days.TabIndex = 5;
            this.Plus7Days.Text = " Добавление 7 дней к текущей дате ";
            this.Plus7Days.UseVisualStyleBackColor = true;
            this.Plus7Days.Click += new System.EventHandler(this.Plus7Days_Click);
            // 
            // DateDiff
            // 
            this.DateDiff.Location = new System.Drawing.Point(67, 252);
            this.DateDiff.Name = "DateDiff";
            this.DateDiff.Size = new System.Drawing.Size(229, 32);
            this.DateDiff.TabIndex = 6;
            this.DateDiff.Text = "DateDiff1";
            this.DateDiff.UseVisualStyleBackColor = true;
            this.DateDiff.Click += new System.EventHandler(this.DateDiff_Click);
            // 
            // DateDiff2
            // 
            this.DateDiff2.Location = new System.Drawing.Point(67, 290);
            this.DateDiff2.Name = "DateDiff2";
            this.DateDiff2.Size = new System.Drawing.Size(229, 32);
            this.DateDiff2.TabIndex = 7;
            this.DateDiff2.Text = "DateDiff2";
            this.DateDiff2.UseVisualStyleBackColor = true;
            this.DateDiff2.Click += new System.EventHandler(this.DateDiff2_Click);
            // 
            // CheckYear
            // 
            this.CheckYear.Location = new System.Drawing.Point(67, 328);
            this.CheckYear.Name = "CheckYear";
            this.CheckYear.Size = new System.Drawing.Size(229, 32);
            this.CheckYear.TabIndex = 8;
            this.CheckYear.Text = "Проверка на високосный год";
            this.CheckYear.UseVisualStyleBackColor = true;
            this.CheckYear.Click += new System.EventHandler(this.CheckYear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckYear);
            this.Controls.Add(this.DateDiff2);
            this.Controls.Add(this.DateDiff);
            this.Controls.Add(this.Plus7Days);
            this.Controls.Add(this.CheckPerf2);
            this.Controls.Add(this.CkeckPerf);
            this.Controls.Add(this.Formats);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DateNow);
            this.Name = "Form1";
            this.Text = "STOLYAROV NIKITA 36/1 DATES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DateNow;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Formats;
        private System.Windows.Forms.Button CkeckPerf;
        private System.Windows.Forms.Button CheckPerf2;
        private System.Windows.Forms.Button Plus7Days;
        private System.Windows.Forms.Button DateDiff;
        private System.Windows.Forms.Button DateDiff2;
        private System.Windows.Forms.Button CheckYear;
    }
}

