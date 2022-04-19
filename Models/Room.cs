using System;
namespace Task_5.Models
{
   
        class Room
        {
            private static int _id;
            public int Id { get; }
            public string Name { get; set; }
            private int _price;
            public int Price
            {
                get { return _price; }
                set
                {
                    if (value > 0)
                    {
                        _price = value;
                    }
                }
            }
            private int _personCapacity;
            public int PersonCapacity
            {
                get { return _personCapacity; }
                set
                {
                    if (value > 0 && value <= 8)
                    {
                        _personCapacity = value;
                    }
                }
            }

            public bool IsAvailable { get; set; } = true;


            public Room(string name, int price, int personCapacity)
            {
                _id++;
                Id = _id;
                Name = name;
                Price = price;
                PersonCapacity = personCapacity;

            }
            public void ShowInfo()
            {
                Console.WriteLine($"Id:{Id}\nName:{Name}\nPrice:{Price}\nPersonCapacity:{PersonCapacity}\nIsAvailable:{IsAvailable}");
            }
        }
    }