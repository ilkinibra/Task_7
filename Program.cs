using System;
using Task_5.Models;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Ilkin Hotel");
            Room room1 = new Room("otaq 1", 200, 3);
            Room room2 = new Room("otaq 2", 100, 2);
            Room room3 = new Room("otaq 3", 80, 1);
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);
            foreach (var item in hotel.GetAllRooms())
            {
                item.ShowInfo();
            }
            hotel.MakeReservation(1);
            hotel.MakeReservation(2);
            Console.WriteLine(hotel.GetAllRooms().Length);
        }
    }
}
          