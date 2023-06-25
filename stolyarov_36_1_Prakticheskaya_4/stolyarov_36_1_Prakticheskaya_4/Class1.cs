using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stolyarov_36_1_Prakticheskaya_4
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        public double PersonArea(int numbOfPerson)
        {
            return RoomArea() / numbOfPerson;
        }
        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + " кв.м";
        }
    }
    public class LivingRoom : Room
    {
        int numbOfWindows;

        public int NumbOfWindows
        {
            get { return numbOfWindows; }
            set { numbOfWindows = value; }
        }
        public override string Info()
        {
            return "Жилая комната площадью " + RoomArea() + "кв.м, с "
                + numbOfWindows + " окнами.";
        }
    }
    public class Office : Room
    {
        int numbOfSockets;

        public int NumbOfSockets
        {
            get { return numbOfSockets; }
            set { numbOfSockets = value; }
        }
        public int NumbOfWorkplaces()
        {
            int numb = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numbOfSockets, numb);
        }
        public override string Info()
        {
            return "Офис на " + NumbOfWorkplaces() + " рабочих мест.";
        }
    }
}
