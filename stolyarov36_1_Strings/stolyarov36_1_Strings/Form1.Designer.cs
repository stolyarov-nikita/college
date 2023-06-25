namespace stolyarov36_1
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
            this.components = new System.ComponentModel.Container();
            this.buttonIns = new System.Windows.Forms.Button();
            this.Second_Word = new System.Windows.Forms.TextBox();
            this.Firsr_Word = new System.Windows.Forms.TextBox();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonSubs = new System.Windows.Forms.Button();
            this.ButtonIndexOf = new System.Windows.Forms.Button();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.ButtonChar = new System.Windows.Forms.Button();
            this.ButtonSpecChar = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.TextToColor = new System.Windows.Forms.Button();
            this.EmptyStringCheck = new System.Windows.Forms.Button();
            this.ReverseString = new System.Windows.Forms.Button();
            this.PathFile = new System.Windows.Forms.Button();
            this.AutoText = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RunningText = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonIns
            // 
            this.buttonIns.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIns.Location = new System.Drawing.Point(149, 43);
            this.buttonIns.Margin = new System.Windows.Forms.Padding(5);
            this.buttonIns.Name = "buttonIns";
            this.buttonIns.Size = new System.Drawing.Size(624, 29);
            this.buttonIns.TabIndex = 0;
            this.buttonIns.Text = "Вставка одной строки в другую строку";
            this.buttonIns.UseVisualStyleBackColor = true;
            this.buttonIns.Click += new System.EventHandler(this.buttonIns_Click);
            // 
            // Second_Word
            // 
            this.Second_Word.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_Word.Location = new System.Drawing.Point(550, 4);
            this.Second_Word.Margin = new System.Windows.Forms.Padding(5);
            this.Second_Word.Name = "Second_Word";
            this.Second_Word.Size = new System.Drawing.Size(223, 29);
            this.Second_Word.TabIndex = 1;
            // 
            // Firsr_Word
            // 
            this.Firsr_Word.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Firsr_Word.Location = new System.Drawing.Point(149, 4);
            this.Firsr_Word.Margin = new System.Windows.Forms.Padding(5);
            this.Firsr_Word.Name = "Firsr_Word";
            this.Firsr_Word.Size = new System.Drawing.Size(223, 29);
            this.Firsr_Word.TabIndex = 2;
            // 
            // ButtonDel
            // 
            this.ButtonDel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDel.Location = new System.Drawing.Point(149, 82);
            this.ButtonDel.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(624, 30);
            this.ButtonDel.TabIndex = 3;
            this.ButtonDel.Text = "Удаление подстроки из заданной строки";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonSubs
            // 
            this.ButtonSubs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSubs.Location = new System.Drawing.Point(149, 122);
            this.ButtonSubs.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSubs.Name = "ButtonSubs";
            this.ButtonSubs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSubs.Size = new System.Drawing.Size(624, 29);
            this.ButtonSubs.TabIndex = 4;
            this.ButtonSubs.Text = "Извлечение подстроки из заданной строки";
            this.ButtonSubs.UseVisualStyleBackColor = true;
            this.ButtonSubs.Click += new System.EventHandler(this.ButtonSubs_Click);
            // 
            // ButtonIndexOf
            // 
            this.ButtonIndexOf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonIndexOf.Location = new System.Drawing.Point(149, 161);
            this.ButtonIndexOf.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonIndexOf.Name = "ButtonIndexOf";
            this.ButtonIndexOf.Size = new System.Drawing.Size(624, 29);
            this.ButtonIndexOf.TabIndex = 5;
            this.ButtonIndexOf.Text = "Определение вхождения подстроки в заданной строке";
            this.ButtonIndexOf.UseVisualStyleBackColor = true;
            this.ButtonIndexOf.Click += new System.EventHandler(this.ButtonIndexOf_Click);
            // 
            // ButtonParse
            // 
            this.ButtonParse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonParse.Location = new System.Drawing.Point(149, 200);
            this.ButtonParse.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(624, 27);
            this.ButtonParse.TabIndex = 6;
            this.ButtonParse.Text = "Преобразование строки в число";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // ButtonChar
            // 
            this.ButtonChar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChar.Location = new System.Drawing.Point(149, 237);
            this.ButtonChar.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonChar.Name = "ButtonChar";
            this.ButtonChar.Size = new System.Drawing.Size(624, 28);
            this.ButtonChar.TabIndex = 7;
            this.ButtonChar.Text = "Вставка специального символа";
            this.ButtonChar.UseVisualStyleBackColor = true;
            this.ButtonChar.Click += new System.EventHandler(this.ButtonChar_Click);
            // 
            // ButtonSpecChar
            // 
            this.ButtonSpecChar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSpecChar.Location = new System.Drawing.Point(149, 275);
            this.ButtonSpecChar.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSpecChar.Name = "ButtonSpecChar";
            this.ButtonSpecChar.Size = new System.Drawing.Size(624, 28);
            this.ButtonSpecChar.TabIndex = 8;
            this.ButtonSpecChar.Text = "Вставка символа торговой марки";
            this.ButtonSpecChar.UseVisualStyleBackColor = true;
            this.ButtonSpecChar.Click += new System.EventHandler(this.ButtonSpecChar_Click);
            // 
            // buttonString
            // 
            this.buttonString.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonString.Location = new System.Drawing.Point(149, 313);
            this.buttonString.Margin = new System.Windows.Forms.Padding(5);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(624, 28);
            this.buttonString.TabIndex = 9;
            this.buttonString.Text = "Создание строки из повторяющихся символов";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // TextToColor
            // 
            this.TextToColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextToColor.Location = new System.Drawing.Point(149, 351);
            this.TextToColor.Margin = new System.Windows.Forms.Padding(5);
            this.TextToColor.Name = "TextToColor";
            this.TextToColor.Size = new System.Drawing.Size(624, 28);
            this.TextToColor.TabIndex = 10;
            this.TextToColor.Text = "Преобразование строки в объект Color";
            this.TextToColor.UseVisualStyleBackColor = true;
            this.TextToColor.Click += new System.EventHandler(this.TextToColor_Click);
            // 
            // EmptyStringCheck
            // 
            this.EmptyStringCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyStringCheck.Location = new System.Drawing.Point(149, 389);
            this.EmptyStringCheck.Margin = new System.Windows.Forms.Padding(5);
            this.EmptyStringCheck.Name = "EmptyStringCheck";
            this.EmptyStringCheck.Size = new System.Drawing.Size(624, 28);
            this.EmptyStringCheck.TabIndex = 11;
            this.EmptyStringCheck.Text = "Проверка строки на пустоту";
            this.EmptyStringCheck.UseVisualStyleBackColor = true;
            this.EmptyStringCheck.Click += new System.EventHandler(this.EmptyStringCheck_Click);
            // 
            // ReverseString
            // 
            this.ReverseString.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReverseString.Location = new System.Drawing.Point(149, 427);
            this.ReverseString.Margin = new System.Windows.Forms.Padding(5);
            this.ReverseString.Name = "ReverseString";
            this.ReverseString.Size = new System.Drawing.Size(624, 28);
            this.ReverseString.TabIndex = 12;
            this.ReverseString.Text = "Переворачиваем строку";
            this.ReverseString.UseVisualStyleBackColor = true;
            this.ReverseString.Click += new System.EventHandler(this.ReverseString_Click);
            // 
            // PathFile
            // 
            this.PathFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathFile.Location = new System.Drawing.Point(149, 465);
            this.PathFile.Margin = new System.Windows.Forms.Padding(5);
            this.PathFile.Name = "PathFile";
            this.PathFile.Size = new System.Drawing.Size(624, 28);
            this.PathFile.TabIndex = 13;
            this.PathFile.Text = "Путь к файлу";
            this.PathFile.UseVisualStyleBackColor = true;
            this.PathFile.Click += new System.EventHandler(this.PathFile_Click);
            // 
            // AutoText
            // 
            this.AutoText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoText.Location = new System.Drawing.Point(149, 503);
            this.AutoText.Margin = new System.Windows.Forms.Padding(5);
            this.AutoText.Name = "AutoText";
            this.AutoText.Size = new System.Drawing.Size(624, 28);
            this.AutoText.TabIndex = 14;
            this.AutoText.Text = "Печатающийся текст";
            this.AutoText.UseVisualStyleBackColor = true;
            this.AutoText.Click += new System.EventHandler(this.AutoText_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RunningText
            // 
            this.RunningText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunningText.Location = new System.Drawing.Point(149, 541);
            this.RunningText.Margin = new System.Windows.Forms.Padding(5);
            this.RunningText.Name = "RunningText";
            this.RunningText.Size = new System.Drawing.Size(624, 28);
            this.RunningText.TabIndex = 15;
            this.RunningText.Text = "Бегущая строка";
            this.RunningText.UseVisualStyleBackColor = true;
            this.RunningText.Click += new System.EventHandler(this.RunningText_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 659);
            this.Controls.Add(this.RunningText);
            this.Controls.Add(this.AutoText);
            this.Controls.Add(this.PathFile);
            this.Controls.Add(this.ReverseString);
            this.Controls.Add(this.EmptyStringCheck);
            this.Controls.Add(this.TextToColor);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.ButtonSpecChar);
            this.Controls.Add(this.ButtonChar);
            this.Controls.Add(this.ButtonParse);
            this.Controls.Add(this.ButtonIndexOf);
            this.Controls.Add(this.ButtonSubs);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.Firsr_Word);
            this.Controls.Add(this.Second_Word);
            this.Controls.Add(this.buttonIns);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "СТРОКИ СТОЛЯРОВ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIns;
        private System.Windows.Forms.TextBox Second_Word;
        private System.Windows.Forms.TextBox Firsr_Word;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonSubs;
        private System.Windows.Forms.Button ButtonIndexOf;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.Button ButtonChar;
        private System.Windows.Forms.Button ButtonSpecChar;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button TextToColor;
        private System.Windows.Forms.Button EmptyStringCheck;
        private System.Windows.Forms.Button ReverseString;
        private System.Windows.Forms.Button PathFile;
        private System.Windows.Forms.Button AutoText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RunningText;
        private System.Windows.Forms.Timer timer2;
    }
}

