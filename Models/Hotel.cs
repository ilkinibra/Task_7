using System;
namespace Task_5.Models
{ 
        class Hotel
        {
            public string Name { get; set; }
            private Room[] Rooms = new Room[0];

            public void AddRoom(Room roomId)
            {
                Array.Resize(ref Rooms, Rooms.Length + 1);
                Rooms[Rooms.Length - 1] = roomId;
            }
            public void MakeReservation(int roomId)
            {
                for (int i = 0; i < Rooms.Length; i++)
                {
                    if (Rooms[i].Id == roomId)
                    {
                        if (Rooms[i].IsAvailable == false)
                        {
                            Console.WriteLine("Room is full");
                        }
                        else
                        {
                            Rooms[i].IsAvailable = false;
                        }
                    }
                }
            }
            public Room[] GetAllRooms()
            {
                return Rooms;
            }

            public Hotel(string name)
            {
                Name = name;
            }

        }
    }