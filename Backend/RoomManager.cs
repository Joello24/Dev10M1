using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    internal class RoomManager
    {
        public static void Run() {
            string input;
            do
            {
                instructions();
                input = Console.ReadLine();

            } while (input != "q");
        }

        public static void instructions() {
            Console.WriteLine("INSTRUCTIONS");
            Console.WriteLine("-------------------");
            Console.WriteLine("touch Add Guest");
            Console.WriteLine("cd id || name - Manage Guest");
            Console.WriteLine("ls - List Guests");
            Console.WriteLine("q - Exit Hotel Manager");
            Console.WriteLine("-------------------");
        }
            
        
    }
}
