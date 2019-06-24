using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._2019_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            //Console.WriteLine("Hello World!");// + endl

            //for (int i = 1; i < 9; i++)
            //{
            //   Console.Write(i + " ");
            //}
            //Console.WriteLine();


            for(int i=0; i<17; i++)
            {
                for(int j=0; j<18; j++)
                {
                    if ((i == 3 && (j > 3 && j < 18)) || i>3 && ((j == 8) || (j == 14)))
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] a = new int[12];
            for(int i=0; i<12; i++)
            {
                if (a[i] >= 100) break;

                if (i < 2) a[i] = 1;

                else
                    a[i] = a[i - 2] + a[i - 1]; 

                Console.Write(a[i] + " ");
            }
             Console.WriteLine();

            //int c;
            //string b;
            //b = Console.ReadLine();//automatically takes as string
            //c = Convert.ToInt32(b);
            //c = Convert.ToInt32(Console.ReadLine());//to read from console as int

            string choice = "begin";
            Console.WriteLine("Enter Y or N.");
            Console.WriteLine(" Enter \"stop\" to stop");
            while (choice != "stop")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Y":
                        Console.WriteLine("You entered YES");
                        break;
                    case "N":
                        Console.WriteLine("You entered NO");
                        break;
                    default:
                        Console.WriteLine("You entered another letter");
                        break;
                }
            }




            Console.ReadKey();//pause
        }
    }
}
