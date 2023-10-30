using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_pr_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word1 - ");
            string word1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Word1 - ");
            string word2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Word1 - ");
            string word3 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Word1 - ");
            string word4 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Word1 - ");
            string word5 = Convert.ToString(Console.ReadLine());

            string[] array = new string[] {word1,word2,word3,word4,word5};

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
