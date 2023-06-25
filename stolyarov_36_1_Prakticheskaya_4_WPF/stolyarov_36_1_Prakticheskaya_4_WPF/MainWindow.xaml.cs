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
using stolyarov_36_1_Prakticheskaya_4;

namespace stolyarov_36_1_Prakticheskaya_4_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> listRooms = new List<Room>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Text = "";
            foreach (Room r in listRooms)
                ListRooms.Text += r.Info() + "\n" + "\n";
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumbOfSockets = Convert.ToInt32(TBNumS.Text);
            listRooms.Add(office);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumbOfWindows = Convert.ToInt32(TBNumW.Text);
            listRooms.Add(livingRoom);
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            listRooms.Add(room);
        }
    }
}
