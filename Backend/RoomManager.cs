using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HelloWorld.Backend.Guest;


namespace HelloWorld.Backend
{
    internal class RoomManager
    {
        public static Dictionary<int, Guest> UserList = new Dictionary<int, Guest>();
        private static Guest value;
        private static bool[] rooms = new bool[10];
        private static int ID_LIST;

        public static void Run() {
            string input;
            do
            {
                instructions();
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else {
                    ParseInput(input);
                }

            } while (input != "q");
        }

        public static void instructions() {
            Console.WriteLine("\nINSTRUCTIONS");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add Guest - touch");
            Console.WriteLine("Manage Guest - cd id | name");
            Console.WriteLine("List Guests - ls");
            Console.WriteLine("Exit Hotel Manager - q");
            Console.WriteLine("--------------------------");
            Console.Write("~ ");
        }

        public static void ParseInput(String input) {
            String[] command = input.Split(" ");
            switch (command[0]) {
                case "q":
                    break;
                case "cd":
                    UserList.TryGetValue(int.Parse(command[1]), out Guest value);
                    ManageGuest(value);
                    break;
                case "touch":
                    CreateGuest();
                    break;
                case "ls":
                    ListGuests();
                    break;
            }
        }

        private static void ListGuests()
        {
            foreach (KeyValuePair<int, Guest> user in UserList) 
            {
                if (user.Value != null) {
                    user.Value.WriteGuest();
                }
                    
            }
        }

        private static void CreateGuest()
        {
            int roomNumber;
            DateTime checkInTime, checkOutTime;
            String name, input;
            Console.WriteLine("Enter Guest Information");
            Console.Write("Guest Name: ");
            name = Console.ReadLine();
            Console.Write("Would you like to add guest room information? (y/n): ");
            input = Console.ReadLine();
            if (input == "y" | input == "Y")
            {
                PrintRooms();
                Console.WriteLine("Enter a new room number");
                int temp = int.Parse(Console.ReadLine());
                if (rooms[temp] == true)
                {
                    roomNumber = temp;
                }
                Guest guest = new Guest(ID_LIST, name);
                UserList.Add(ID_LIST, guest);
                PrintGuest(ID_LIST);

            }
            else 
            {
                Guest guest = new Guest(ID_LIST, name);
                UserList.Add(ID_LIST, guest);
                PrintGuest(ID_LIST);
            }
        }
        private static void PrintRooms() 
        {
            int count = 0;
            foreach (bool r in rooms)
            {
                String temp = (r == true ? "Occupied" : "Open");
                Console.WriteLine($"Room {count++}: {temp}");
            }
        }

        private static void ManageGuest(Guest value) {
            string input;
            String[] command;
            do
            {
                ManageGuestInstructions(value);
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            value.checkedIn = true;
                            break;
                        case "2":
                            value.checkedIn = false;
                            break;
                        case "3":
                            PrintRooms();
                            Console.WriteLine("Enter a new room number");
                            int temp = int.Parse(Console.ReadLine());
                            if (rooms[temp] == false) { 
                                value.roomNumber = temp;
                            }
                            break;
                    }
                }
            } while (input != "q");
            value.name = "Jimmy";
        }

        private static void ManageGuestInstructions(Guest guest)
        {
            Console.WriteLine("\nManaging Guest:");
            guest.WriteGuest();
            Console.WriteLine("-------------------");
            Console.WriteLine("1 - Check In");
            Console.WriteLine("2 - Check Out");
            Console.WriteLine("3 - Set Room Number");
            Console.WriteLine("q - Back to Main Menu");
            Console.WriteLine("-------------------");
            Console.Write($"~ {guest.name}: ");
        }

        private static void PrintGuest(int id) 
        {
            UserList.TryGetValue(id, out Guest value);
            value.ToString();
        }
        private static Guest GetGuest(int id) 
        {
            UserList.TryGetValue(id, out Guest value);
            return value;
        }
    }
}
