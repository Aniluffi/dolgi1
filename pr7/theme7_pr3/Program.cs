using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theme7_pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2

            //string word = "eNNEEE e EEEEE";



            //for (int i = word.Length; i >= 0;i--)

            //{

            //    word = word.Replace('e',' ');

            //    word = word.Replace('E',' ');

            //}

            //Console.WriteLine(word);



            //Task3

            //            string word = "aaaAAAkdl";



            //            int shet = 0;

            //            int shet2 = 0;

            //            for (int i = word.Length - 1; i >= 0; i--)

            //            {   string a = word.Substring(i, 1);

            //                string d = word.Substring(i, 1);



            //                if (a == "a"  )

            //                {

            //                    shet += 1;



            //                } else if (d == "A") {

            //shet2 += 1;

            //            }



            //            }



            //            Console.WriteLine($"Букв а - {shet} Букв А - {shet2}");



            //task4

            string word = "dushg sjlkdf fjs";

            string[] words = word.Split(' ');

            int i = words[0].Length;

            Console.WriteLine(i);
        }
    }
}
