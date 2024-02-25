using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count =0;
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            while (count <= n)
            {
                Console.WriteLine("Number : " + count);
                count++;
            }
            Console.ReadLine();
        }
    }
}
