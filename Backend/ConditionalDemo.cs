using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    internal class ConditionalDemo
    {

        public static readonly int num, target, range;


        static ConditionalDemo() {
            Console.WriteLine("Enter num: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter target: ");
            target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter range: ");
            range = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// /// <summary>
        /// Given a non-negative number, return true if the number is within range of a multiple of the target.
        // Given 12, 10, and  2 return true
        // Given 23, 10, and  3 return true
        // Given 17, 5, and  1 return false)]
        // Given 17, 0, and  1 return false)]
        /// </summary>
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static bool IsWithinRange(int num, int target, int range) {
            if (num < 0)
            {
                return false;
            }
            else if ((num % target) <= range)
            {
                return true;
            }
            else return false;
        }
        public static bool IsWithinRange()
        {
            if (num < 0)
            {
                return false;
            }
            else if (Math.Abs((num % target)) <= range)
            {
                return true;
            }
            else return false;
        }
    }
}
