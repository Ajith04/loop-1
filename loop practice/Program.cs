using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print until given number from 1 using while loop

            /*int x =1;
            Console.WriteLine("Enter a number : ");
            int n1 = int.Parse(Console.ReadLine());
            while (x <= n1)
            {
                Console.WriteLine("Number : " + x);
                x++;
            }
            Console.ReadLine();*/

            // print odd and even numbers seperately from 1 to give number

            /*Console.WriteLine("Enter a number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Odd\t\tEven");
            int y = 1;
            while (y<=n2)
            {
                if (y%2 == 1)
                {
                    Console.WriteLine(y + "\t\t");

                }
                else
                {
                    Console.WriteLine(y);
                }
                y++;
            }*/



            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);

            }
            Console.Write(" = " + sum);
            Console.ReadLine();*/


            /*int sum = 0;
            while (true)
            {
                Console.Write("Enter a number : ");
                int n3 = int.Parse(Console.ReadLine());
                if (n3 < 0)
                {
                    break;
                }
                else
                {
                    sum += n3;
                }
            }
            Console.Write("The total number is : " + sum);
            Console.ReadLine();*/


            //Console.Write("Enter a number : ");
            //int nn = int .Parse(Console.ReadLine());
            //int sum = 0;
            //while (nn >=0)
            //{
            //    sum += nn;
            //    Console.Write("Enter a number : ");
            //    nn = int .Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The total number : " + sum);




            //find the given number is prime number or not

            //Console.Write("Enter a positive number : ");
            //int num = int.Parse(Console.ReadLine());
            //int divider = 2;
            //int maxDivider = (int)Math.Sqrt(num);
            //bool prime = true;
            //while (prime && (divider <= maxDivider))
            //{
            //    if (num % divider ==0)
            //    {
            //        prime = false;
            //    }
            //    divider++;
            //}
            //Console.WriteLine("Prime? " + prime);
            //Console.ReadLine();

            // find the factorial value of the given number

            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //decimal factorial = 1;
            //do
            //{
            //    factorial *= n;
            //    n--;
            //}
            //while (n > 0);
            //Console.WriteLine("n!= " + factorial);


            //find factorial within the given two numbers
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m= ");
            //int m = int.Parse(Console.ReadLine());
            //int num = n;
            //long product = 1;
            //do
            //{
            //    product *= num;
            //    num++;
            //}
            //while (num <= m);
            //Console.WriteLine("product[n.....m]" + product);



        }
    }
}
