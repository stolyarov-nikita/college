using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace stolyarov36_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIns_Click(object sender, EventArgs e)
        {
            if((Firsr_Word.Text != "") && (Second_Word.Text != ""))
                MessageBox.Show(Firsr_Word.Text.Insert(3, Second_Word.Text + " "));
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if(Firsr_Word.Text != "")
                MessageBox.Show(Firsr_Word.Text.Remove(2));
            else if (Second_Word.Text != "")
                MessageBox.Show(Second_Word.Text.Remove(2));
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonSubs_Click(object sender, EventArgs e)
        {
            if (Firsr_Word.Text != "")
                MessageBox.Show(Firsr_Word.Text.Substring(3, 2));
            else if (Second_Word.Text != "")
                MessageBox.Show(Second_Word.Text.Substring(3, 2));
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonIndexOf_Click(object sender, EventArgs e)
        {
            if ((Firsr_Word.Text != "") && (Second_Word.Text != ""))
            {
                if (Second_Word.Text.IndexOf(Firsr_Word.Text) >= 0) 
                    MessageBox.Show(Firsr_Word.Text + " входит в строку " + Second_Word.Text);
                else
                    MessageBox.Show(Firsr_Word.Text + " не входит в строку " + Second_Word.Text);
            }
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if ((Firsr_Word.Text != "") && (Second_Word.Text != ""))
                MessageBox.Show((int.Parse(Firsr_Word.Text) + int.Parse(Second_Word.Text)).ToString());
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonChar_Click(object sender, EventArgs e)
        {
            if (Firsr_Word.Text != "")
                MessageBox.Show(Convert.ToChar(int.Parse(Firsr_Word.Text)).ToString());
            else if (Second_Word.Text != "")
                MessageBox.Show(Convert.ToChar(int.Parse(Second_Word.Text)).ToString());
            else
                MessageBox.Show("Строка пуста(");
        }

        private void ButtonSpecChar_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            MessageBox.Show(specialChar.ToString());
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            System.String string_ = new System.String((char)rand.Next(0x0410, 0x44F), rand.Next(3, 10));
            MessageBox.Show(string_);
        }

        Color color1;
        Color color2;

        private void TextToColor_Click(object sender, EventArgs e)
        {
            if (Second_Word.Text == "")
            {
                color1 = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(Firsr_Word.Text);
                this.BackColor = color1;
                return;
            }
            color1 = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(Firsr_Word.Text);
            color2 = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(Second_Word.Text);
            Paint += Form1_Paint;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics graphics = e.Graphics;
                Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);

                Rectangle area = new Rectangle(0, 0, this.Width-1, this.Height-1);
                LinearGradientBrush brush = new LinearGradientBrush(area, color1, color2, LinearGradientMode.Horizontal);
                graphics.FillRectangle(brush, area);
                graphics.DrawRectangle(pen, area);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmptyStringCheck_Click(object sender, EventArgs e)
        {
            if(Firsr_Word.Text == "" && Second_Word.Text == "")
                MessageBox.Show("Две строки пусты");
            else if (Firsr_Word.Text == "")
                MessageBox.Show("Только первая строка пуста");
            else if (Second_Word.Text == "")
                MessageBox.Show("Только вторая строка пуста");
            else
                MessageBox.Show("Ни одна строка не пуста");
        }

        private void ReverseString_Click(object sender, EventArgs e)
        {
            Firsr_Word.Text = Strings.StrReverse(Firsr_Word.Text);
            Second_Word.Text = Strings.StrReverse(Second_Word.Text);
        }

        private void PathFile_Click(object sender, EventArgs e)
        {
            string strPathFile = Application.ExecutablePath;
            StringBuilder sb = new StringBuilder(260);
            bool b = PathCompactPathEx(sb, strPathFile, 30 + 1, 0);
            MessageBox.Show(sb.ToString());
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(System.Text.StringBuilder pszOut,string pszSrc,Int32 cchMax,Int32 dwFlags);

        private void AutoText_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
        public static int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            Firsr_Word.Text = typingText.Substring(0, counter);
            Second_Word.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void RunningText_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
        }
        private string scrollText = "C#.Народные советы ";

        private void timer2_Tick(object sender, EventArgs e)
        {
            scrollText = scrollText.Substring(1, (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            Firsr_Word.Text = scrollText;
            Second_Word.Text = scrollText;
        }
    }
}
