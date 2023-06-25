namespace stolyarov36_1_Disks
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetListOfDisks = new System.Windows.Forms.Button();
            this.GetTypeOfDisks = new System.Windows.Forms.Button();
            this.GetListOfFolders = new System.Windows.Forms.Button();
            this.GetListOfFolderByMask = new System.Windows.Forms.Button();
            this.CheckFolder = new System.Windows.Forms.Button();
            this.RenameFolder = new System.Windows.Forms.Button();
            this.DelEmptyFolder = new System.Windows.Forms.Button();
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.GetSpecFolders = new System.Windows.Forms.Button();
            this.GetValuesOfFolder = new System.Windows.Forms.Button();
            this.GetSizeOfFolder = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CreateRandomNameOfFile = new System.Windows.Forms.Button();
            this.CreateTempFile = new System.Windows.Forms.Button();
            this.GetInformationByFile = new System.Windows.Forms.Button();
            this.GetAttributesOfFile = new System.Windows.Forms.Button();
            this.SetAttributesOfFile = new System.Windows.Forms.Button();
            this.GetExtensionOfFile = new System.Windows.Forms.Button();
            this.GetFullPathOfFile = new System.Windows.Forms.Button();
            this.CkeskFile = new System.Windows.Forms.Button();
            this.GetLisOfFilesByMask = new System.Windows.Forms.Button();
            this.GetListOfFilesAndFolders = new System.Windows.Forms.Button();
            this.GetListOfFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(251, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 433);
            this.listBox1.TabIndex = 0;
            // 
            // GetListOfDisks
            // 
            this.GetListOfDisks.Location = new System.Drawing.Point(12, 12);
            this.GetListOfDisks.Name = "GetListOfDisks";
            this.GetListOfDisks.Size = new System.Drawing.Size(233, 33);
            this.GetListOfDisks.TabIndex = 1;
            this.GetListOfDisks.Text = "Получение списка логических дисков";
            this.GetListOfDisks.UseVisualStyleBackColor = true;
            this.GetListOfDisks.Click += new System.EventHandler(this.GetListOfDisks_Click);
            // 
            // GetTypeOfDisks
            // 
            this.GetTypeOfDisks.Location = new System.Drawing.Point(12, 51);
            this.GetTypeOfDisks.Name = "GetTypeOfDisks";
            this.GetTypeOfDisks.Size = new System.Drawing.Size(233, 33);
            this.GetTypeOfDisks.TabIndex = 2;
            this.GetTypeOfDisks.Text = "Получение типа диска";
            this.GetTypeOfDisks.UseVisualStyleBackColor = true;
            this.GetTypeOfDisks.Click += new System.EventHandler(this.GetTypeOfDisks_Click);
            // 
            // GetListOfFolders
            // 
            this.GetListOfFolders.Location = new System.Drawing.Point(12, 90);
            this.GetListOfFolders.Name = "GetListOfFolders";
            this.GetListOfFolders.Size = new System.Drawing.Size(233, 33);
            this.GetListOfFolders.TabIndex = 3;
            this.GetListOfFolders.Text = "Список папок";
            this.GetListOfFolders.UseVisualStyleBackColor = true;
            this.GetListOfFolders.Click += new System.EventHandler(this.GetListOfFolders_Click);
            // 
            // GetListOfFolderByMask
            // 
            this.GetListOfFolderByMask.Location = new System.Drawing.Point(12, 129);
            this.GetListOfFolderByMask.Name = "GetListOfFolderByMask";
            this.GetListOfFolderByMask.Size = new System.Drawing.Size(233, 33);
            this.GetListOfFolderByMask.TabIndex = 4;
            this.GetListOfFolderByMask.Text = "Список папок по маске";
            this.GetListOfFolderByMask.UseVisualStyleBackColor = true;
            this.GetListOfFolderByMask.Click += new System.EventHandler(this.GetListOfFolderByMask_Click);
            // 
            // CheckFolder
            // 
            this.CheckFolder.Location = new System.Drawing.Point(12, 168);
            this.CheckFolder.Name = "CheckFolder";
            this.CheckFolder.Size = new System.Drawing.Size(233, 33);
            this.CheckFolder.TabIndex = 5;
            this.CheckFolder.Text = "Проверка существования папки";
            this.CheckFolder.UseVisualStyleBackColor = true;
            this.CheckFolder.Click += new System.EventHandler(this.CheckFolder_Click);
            // 
            // RenameFolder
            // 
            this.RenameFolder.Location = new System.Drawing.Point(12, 207);
            this.RenameFolder.Name = "RenameFolder";
            this.RenameFolder.Size = new System.Drawing.Size(233, 33);
            this.RenameFolder.TabIndex = 6;
            this.RenameFolder.Text = "Переименование папки";
            this.RenameFolder.UseVisualStyleBackColor = true;
            this.RenameFolder.Click += new System.EventHandler(this.RenameFolder_Click);
            // 
            // DelEmptyFolder
            // 
            this.DelEmptyFolder.Location = new System.Drawing.Point(12, 246);
            this.DelEmptyFolder.Name = "DelEmptyFolder";
            this.DelEmptyFolder.Size = new System.Drawing.Size(233, 33);
            this.DelEmptyFolder.TabIndex = 7;
            this.DelEmptyFolder.Text = "Удаление пустой папки";
            this.DelEmptyFolder.UseVisualStyleBackColor = true;
            this.DelEmptyFolder.Click += new System.EventHandler(this.DelEmptyFolder_Click);
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(12, 285);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(233, 33);
            this.ChooseFolder.TabIndex = 8;
            this.ChooseFolder.Text = "Выбор папки";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // GetSpecFolders
            // 
            this.GetSpecFolders.Location = new System.Drawing.Point(12, 324);
            this.GetSpecFolders.Name = "GetSpecFolders";
            this.GetSpecFolders.Size = new System.Drawing.Size(233, 33);
            this.GetSpecFolders.TabIndex = 9;
            this.GetSpecFolders.Text = "Получение путей к специальным папкам";
            this.GetSpecFolders.UseVisualStyleBackColor = true;
            this.GetSpecFolders.Click += new System.EventHandler(this.GetSpecFolders_Click);
            // 
            // GetValuesOfFolder
            // 
            this.GetValuesOfFolder.Location = new System.Drawing.Point(12, 363);
            this.GetValuesOfFolder.Name = "GetValuesOfFolder";
            this.GetValuesOfFolder.Size = new System.Drawing.Size(233, 33);
            this.GetValuesOfFolder.TabIndex = 10;
            this.GetValuesOfFolder.Text = "Получение свойств папки";
            this.GetValuesOfFolder.UseVisualStyleBackColor = true;
            this.GetValuesOfFolder.Click += new System.EventHandler(this.GetValuesOfFolder_Click);
            // 
            // GetSizeOfFolder
            // 
            this.GetSizeOfFolder.Location = new System.Drawing.Point(12, 405);
            this.GetSizeOfFolder.Name = "GetSizeOfFolder";
            this.GetSizeOfFolder.Size = new System.Drawing.Size(233, 33);
            this.GetSizeOfFolder.TabIndex = 11;
            this.GetSizeOfFolder.Text = "Получение размеров папки";
            this.GetSizeOfFolder.UseVisualStyleBackColor = true;
            this.GetSizeOfFolder.Click += new System.EventHandler(this.GetSizeOfFolder_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(555, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(271, 433);
            this.treeView1.TabIndex = 12;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // CreateRandomNameOfFile
            // 
            this.CreateRandomNameOfFile.Location = new System.Drawing.Point(832, 405);
            this.CreateRandomNameOfFile.Name = "CreateRandomNameOfFile";
            this.CreateRandomNameOfFile.Size = new System.Drawing.Size(233, 33);
            this.CreateRandomNameOfFile.TabIndex = 23;
            this.CreateRandomNameOfFile.Text = "Создание уникального имени для файла";
            this.CreateRandomNameOfFile.UseVisualStyleBackColor = true;
            this.CreateRandomNameOfFile.Click += new System.EventHandler(this.CreateRandomNameOfFile_Click);
            // 
            // CreateTempFile
            // 
            this.CreateTempFile.Location = new System.Drawing.Point(832, 363);
            this.CreateTempFile.Name = "CreateTempFile";
            this.CreateTempFile.Size = new System.Drawing.Size(233, 33);
            this.CreateTempFile.TabIndex = 22;
            this.CreateTempFile.Text = "Создание временного файла";
            this.CreateTempFile.UseVisualStyleBackColor = true;
            this.CreateTempFile.Click += new System.EventHandler(this.CreateTempFile_Click);
            // 
            // GetInformationByFile
            // 
            this.GetInformationByFile.Location = new System.Drawing.Point(832, 324);
            this.GetInformationByFile.Name = "GetInformationByFile";
            this.GetInformationByFile.Size = new System.Drawing.Size(233, 33);
            this.GetInformationByFile.TabIndex = 21;
            this.GetInformationByFile.Text = "Извлечение информации о файле";
            this.GetInformationByFile.UseVisualStyleBackColor = true;
            this.GetInformationByFile.Click += new System.EventHandler(this.GetInformationByFile_Click);
            // 
            // GetAttributesOfFile
            // 
            this.GetAttributesOfFile.Location = new System.Drawing.Point(832, 285);
            this.GetAttributesOfFile.Name = "GetAttributesOfFile";
            this.GetAttributesOfFile.Size = new System.Drawing.Size(233, 33);
            this.GetAttributesOfFile.TabIndex = 20;
            this.GetAttributesOfFile.Text = "Получение свойств файла";
            this.GetAttributesOfFile.UseVisualStyleBackColor = true;
            this.GetAttributesOfFile.Click += new System.EventHandler(this.GetAttributesOfFile_Click);
            // 
            // SetAttributesOfFile
            // 
            this.SetAttributesOfFile.Location = new System.Drawing.Point(832, 246);
            this.SetAttributesOfFile.Name = "SetAttributesOfFile";
            this.SetAttributesOfFile.Size = new System.Drawing.Size(233, 33);
            this.SetAttributesOfFile.TabIndex = 19;
            this.SetAttributesOfFile.Text = "Установка атрибутов файла";
            this.SetAttributesOfFile.UseVisualStyleBackColor = true;
            this.SetAttributesOfFile.Click += new System.EventHandler(this.SetAttributesOfFile_Click);
            // 
            // GetExtensionOfFile
            // 
            this.GetExtensionOfFile.Location = new System.Drawing.Point(832, 207);
            this.GetExtensionOfFile.Name = "GetExtensionOfFile";
            this.GetExtensionOfFile.Size = new System.Drawing.Size(233, 33);
            this.GetExtensionOfFile.TabIndex = 18;
            this.GetExtensionOfFile.Text = "Получение расширения файла";
            this.GetExtensionOfFile.UseVisualStyleBackColor = true;
            this.GetExtensionOfFile.Click += new System.EventHandler(this.GetExtensionOfFile_Click);
            // 
            // GetFullPathOfFile
            // 
            this.GetFullPathOfFile.Location = new System.Drawing.Point(832, 168);
            this.GetFullPathOfFile.Name = "GetFullPathOfFile";
            this.GetFullPathOfFile.Size = new System.Drawing.Size(233, 33);
            this.GetFullPathOfFile.TabIndex = 17;
            this.GetFullPathOfFile.Text = "Получение имени файла из полного пути";
            this.GetFullPathOfFile.UseVisualStyleBackColor = true;
            this.GetFullPathOfFile.Click += new System.EventHandler(this.GetFullPathOfFile_Click);
            // 
            // CkeskFile
            // 
            this.CkeskFile.Location = new System.Drawing.Point(832, 129);
            this.CkeskFile.Name = "CkeskFile";
            this.CkeskFile.Size = new System.Drawing.Size(233, 33);
            this.CkeskFile.TabIndex = 16;
            this.CkeskFile.Text = "Проверка существования файла";
            this.CkeskFile.UseVisualStyleBackColor = true;
            this.CkeskFile.Click += new System.EventHandler(this.CkeskFile_Click);
            // 
            // GetLisOfFilesByMask
            // 
            this.GetLisOfFilesByMask.Location = new System.Drawing.Point(832, 90);
            this.GetLisOfFilesByMask.Name = "GetLisOfFilesByMask";
            this.GetLisOfFilesByMask.Size = new System.Drawing.Size(233, 33);
            this.GetLisOfFilesByMask.TabIndex = 15;
            this.GetLisOfFilesByMask.Text = " Получение списка файлов по маске";
            this.GetLisOfFilesByMask.UseVisualStyleBackColor = true;
            this.GetLisOfFilesByMask.Click += new System.EventHandler(this.GetLisOfFilesByMask_Click);
            // 
            // GetListOfFilesAndFolders
            // 
            this.GetListOfFilesAndFolders.Location = new System.Drawing.Point(832, 51);
            this.GetListOfFilesAndFolders.Name = "GetListOfFilesAndFolders";
            this.GetListOfFilesAndFolders.Size = new System.Drawing.Size(233, 33);
            this.GetListOfFilesAndFolders.TabIndex = 14;
            this.GetListOfFilesAndFolders.Text = "Получение списка папок и файлов";
            this.GetListOfFilesAndFolders.UseVisualStyleBackColor = true;
            this.GetListOfFilesAndFolders.Click += new System.EventHandler(this.GetListOfFilesAndFolders_Click);
            // 
            // GetListOfFiles
            // 
            this.GetListOfFiles.Location = new System.Drawing.Point(832, 12);
            this.GetListOfFiles.Name = "GetListOfFiles";
            this.GetListOfFiles.Size = new System.Drawing.Size(233, 33);
            this.GetListOfFiles.TabIndex = 13;
            this.GetListOfFiles.Text = "Получение списка файлов в папке";
            this.GetListOfFiles.UseVisualStyleBackColor = true;
            this.GetListOfFiles.Click += new System.EventHandler(this.GetListOfFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 454);
            this.Controls.Add(this.CreateRandomNameOfFile);
            this.Controls.Add(this.CreateTempFile);
            this.Controls.Add(this.GetInformationByFile);
            this.Controls.Add(this.GetAttributesOfFile);
            this.Controls.Add(this.SetAttributesOfFile);
            this.Controls.Add(this.GetExtensionOfFile);
            this.Controls.Add(this.GetFullPathOfFile);
            this.Controls.Add(this.CkeskFile);
            this.Controls.Add(this.GetLisOfFilesByMask);
            this.Controls.Add(this.GetListOfFilesAndFolders);
            this.Controls.Add(this.GetListOfFiles);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.GetSizeOfFolder);
            this.Controls.Add(this.GetValuesOfFolder);
            this.Controls.Add(this.GetSpecFolders);
            this.Controls.Add(this.ChooseFolder);
            this.Controls.Add(this.DelEmptyFolder);
            this.Controls.Add(this.RenameFolder);
            this.Controls.Add(this.CheckFolder);
            this.Controls.Add(this.GetListOfFolderByMask);
            this.Controls.Add(this.GetListOfFolders);
            this.Controls.Add(this.GetTypeOfDisks);
            this.Controls.Add(this.GetListOfDisks);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "STOLYAROV NIKITA 36 1 DISKS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetListOfDisks;
        private System.Windows.Forms.Button GetTypeOfDisks;
        private System.Windows.Forms.Button GetListOfFolders;
        private System.Windows.Forms.Button GetListOfFolderByMask;
        private System.Windows.Forms.Button CheckFolder;
        private System.Windows.Forms.Button RenameFolder;
        private System.Windows.Forms.Button DelEmptyFolder;
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Button GetSpecFolders;
        private System.Windows.Forms.Button GetValuesOfFolder;
        private System.Windows.Forms.Button GetSizeOfFolder;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button CreateRandomNameOfFile;
        private System.Windows.Forms.Button CreateTempFile;
        private System.Windows.Forms.Button GetInformationByFile;
        private System.Windows.Forms.Button GetAttributesOfFile;
        private System.Windows.Forms.Button SetAttributesOfFile;
        private System.Windows.Forms.Button GetExtensionOfFile;
        private System.Windows.Forms.Button GetFullPathOfFile;
        private System.Windows.Forms.Button CkeskFile;
        private System.Windows.Forms.Button GetLisOfFilesByMask;
        private System.Windows.Forms.Button GetListOfFilesAndFolders;
        private System.Windows.Forms.Button GetListOfFiles;
    }
}

