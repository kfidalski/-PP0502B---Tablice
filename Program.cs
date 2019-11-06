using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // liczba iteracji


             int n = Convert.ToInt32(Console.ReadLine());
          
            int elements;
            string input = "";
            int[] newElements = new int[100];
            int[] countElements = new int[n];
            int[,] tab = new int[n,100];
            if (n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    input = Console.ReadLine();
                    string[] data = input.Split(' ');
                    elements = Convert.ToInt32(data[0]);
                    countElements[i] = elements;



                    for (int j = 1; j <= countElements[i]; j++)
                    {

                        tab[i, j] = Convert.ToInt32(data[j]);
                    }



                }

                int[,] tmp = new int[n, 100];

                int x;
                int a;
                for (int i = 0; i < n; i++)
                {

                    for (a = 1, x = countElements[i]; x > 0; x--, a++)
                    {
                        tmp[i, a] = tab[i, x];

                    }
                }


                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= countElements[i]; j++)
                    {

                        Console.Write($"{tmp[i, j]} ");
                    }
                    Console.WriteLine("");
                }



            }


            Console.ReadKey();
        }
    }
}
