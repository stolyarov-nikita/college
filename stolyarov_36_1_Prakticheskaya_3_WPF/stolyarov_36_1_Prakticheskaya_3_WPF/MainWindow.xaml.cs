using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using stolyarov_36_1_Prakticheskaya_3;

namespace stolyarov_36_1_Prakticheskaya_3_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;
            room1.RoomLength = random.Next(2, 11);
            room1.RoomWidth = random.Next(2, 11);
            int numbOdPerson = random.Next(1, 9);

            LabelLength1.Content = room1.RoomLength;
            LabelWidth1.Content = room1.RoomWidth;
            LabelNumb1.Content = numbOdPerson;

            LabelPer1.Content = room1.RoomPerimeter();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonArea1.Content = Math.Round(room1.PersonArea(numbOdPerson),3);
        }
        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            ButtonAll.IsEnabled = true;

            room2.RoomLength = Convert.ToDouble(TBLength2.Text);
            room2.RoomWidth = Convert.ToDouble(TBWidth2.Text);
            int numbOfPerson = Convert.ToInt32(TBNumb2.Text);

            LabelPer2.Content = room2.RoomPerimeter();
            LabelArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room2.PersonArea(numbOfPerson),3);
        }
        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            LabelAllArea.Content = room1.RoomArea() + room2.RoomArea();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
