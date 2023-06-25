using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stolyarov36_1_Disks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetListOfDisks_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrLogicalDrives = System.Environment.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void GetTypeOfDisks_Click(object sender, EventArgs e)
        {
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"c:\");
            listBox1.Items.Clear();
            listBox1.Items.Add("Диск: " + drv.Name);

            if (drv.IsReady)
            {
                listBox1.Items.Add("Тип диска: " + drv.DriveType.ToString());
                listBox1.Items.Add("Файловая система: " +
                drv.DriveFormat.ToString());
                listBox1.Items.Add("Свободное место на диске: " +
                drv.AvailableFreeSpace.ToString());
            }
        }

        private void GetListOfFolders_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"c:\");
            foreach (string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void GetListOfFolderByMask_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"c:\");
            System.IO.DirectoryInfo[] folders = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folders)
                listBox1.Items.Add(maskdirs);
        }

        private void CheckFolder_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                MessageBox.Show("Папка " + @"C:\Windows" + " существует");
            else
                MessageBox.Show("Папка не существует");
        }

        private void RenameFolder_Click(object sender, EventArgs e)
        {
            string oldPathString = @"C:\MyFolder";
            string newPathString = @"C:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void DelEmptyFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.Delete(@"c:\wutemp");
                MessageBox.Show("Папка удалена.");
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить непустую папку.");
            }
            finally { }
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Выберите папку";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show(fbd.SelectedPath);
        }

        private void GetSpecFolders_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        private void GetValuesOfFolder_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\Windows");
            listBox1.Items.Clear();
            listBox1.Items.Add("Проверка папки: " + dir.Name);
            listBox1.Items.Add("Родительская папка: " + dir.Parent.Name);
            listBox1.Items.Add("Папка существует: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("Папка создана: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("Папка изменена: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("Время последнего доступа: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("Атрибуты папки: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("Папка содержит: " +
                dir.GetFiles().Length.ToString() + " файла");
            }
        }

        private void GetSizeOfFolder_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.IO.DirectoryInfo dir = new
            System.IO.DirectoryInfo(@"c:\Temp");
            MessageBox.Show("Общий размер: " + GetDirectorySize(dir, true).ToString() + " байт.");
            this.Cursor = Cursors.Default;
        }

        static long GetDirectorySize(System.IO.DirectoryInfo directory, bool includeSubdir)
        {
            long totalSize = 0;
            System.IO.FileInfo[] files = directory.GetFiles();
            foreach (System.IO.FileInfo file in files)
            {
                totalSize += file.Length;
            }
            if (includeSubdir)
            {
                System.IO.DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (System.IO.DirectoryInfo dir in dirs)
                {
                    totalSize += GetDirectorySize(dir, true);
                }
            }
            return totalSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode(@"C:\");
            treeView1.Nodes.Add(rootNode);
            FillNodes(rootNode);
            treeView1.Nodes[0].Expand();
        }
        private void FillNodes(TreeNode dirNode)
        {
            DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
            foreach (DirectoryInfo dirItem in dir.GetDirectories())
            {
                TreeNode newNode = new TreeNode(dirItem.Name);
                dirNode.Nodes.Add(newNode);
                newNode.Nodes.Add("*");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillNodes(e.Node);
            }
        }

        private void GetListOfFiles_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void GetListOfFilesAndFolders_Click(object sender, EventArgs e)
        {
            string[] directoryEntries = Directory.GetFileSystemEntries(@"c:\windows");
            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }
        }

        private void GetLisOfFilesByMask_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\", "*.in?");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void CkeskFile_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\test.txt"))
                MessageBox.Show("Файл test.txt существует");
            else
                MessageBox.Show("Файл test.txt не существует");
        }

        private void GetFullPathOfFile_Click(object sender, EventArgs e)
        {
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            listBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void GetExtensionOfFile_Click(object sender, EventArgs e)
        {
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void SetAttributesOfFile_Click(object sender, EventArgs e)
        {
            string path = @"c:\WUTEMP\test.txt";

            if ((System.IO.File.GetAttributes(path) &
            System.IO.FileAttributes.Hidden)
            == System.IO.FileAttributes.Hidden)
            {
                System.IO.File.SetAttributes(path,
                System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);
            }
            else
            {
                System.IO.File.SetAttributes(path,
                System.IO.File.GetAttributes(path) |
                System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);
            }
        }

        private void GetAttributesOfFile_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(@"c:\wutemp\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }

        private void GetInformationByFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.FileVersionInfo info = System.Diagnostics.FileVersionInfo.GetVersionInfo(@"c:\windows\system32\notepad.exe");
            listBox1.Items.Add("Выбранный файл: " + info.FileName);
            listBox1.Items.Add("Product Name: " + info.ProductName);
            listBox1.Items.Add("Product Version: " + info.ProductVersion);
            listBox1.Items.Add("Company Name: " + info.CompanyName);
            listBox1.Items.Add("File Version: " + info.FileVersion);
            listBox1.Items.Add("File Description: " + info.FileDescription);
            listBox1.Items.Add("Original Filename: " + info.OriginalFilename);
            listBox1.Items.Add("Legal Copyright: " + info.LegalCopyright);
            listBox1.Items.Add("InternalName: " + info.InternalName);
            listBox1.Items.Add("IsDebug: " + info.IsDebug);
            listBox1.Items.Add("IsPatched: " + info.IsPatched);
            listBox1.Items.Add("IsPreRelease: " + info.IsPreRelease);
            listBox1.Items.Add("IsPrivateBuild: " + info.IsPrivateBuild);
            listBox1.Items.Add("IsSpecialBuild: " + info.IsSpecialBuild);
        }

        private void CreateTempFile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        private void CreateRandomNameOfFile_Click(object sender, EventArgs e)
        {
            string randomFile = System.IO.Path.GetRandomFileName();
            MessageBox.Show(randomFile);
        }
    }
}
