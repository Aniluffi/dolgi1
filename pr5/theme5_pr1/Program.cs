using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    class Program

    {

        static void Main(string[] args)

        {

            //Task1

            //Console.WriteLine("Введите год что бы проверить его на высокосность");

            //int years = Convert.ToInt32(Console.ReadLine());



            //if (years % 4 == 0)

            //{

            //    Console.WriteLine($"{years} год высокосный"); 

            //} else

            //{

            //    Console.WriteLine($"{years} год не высокосный");

            //}



            //Task2

            //Console.WriteLine("Напишите цену ноутбука что бы определить входит ли он в диапазон");



            //double coast = Convert.ToDouble(Console.ReadLine());



            //if (20000 <= coast & 30000 >= coast)

            //{

            //    Console.WriteLine($"{coast} Входит в наш диапозон");

            //}

            //else

            //{

            //    Console.WriteLine($"{coast} не Входит в наш диапозон");

            //}

            //Task3

            //Console.WriteLine("Введите балл ученика что бы определить оценку");



            //int grade = Convert.ToInt32(Console.ReadLine());



            //if (60 <= grade & 74 >= grade)

            //{

            //    Console.WriteLine($"{grade} - оценка удовлетворительно");

            //}

            //else if (75 <= grade & 89 >= grade)

            //{

            //    Console.WriteLine($"{grade} - оценка хорошо");

            //}

            //else if (90 <= grade & 100 >= grade)

            //{

            //    Console.WriteLine($"{grade} - оценка отлично");

            //}  else

            //{

            //    Console.WriteLine($"{grade} - оценка 2");

            //}

            //Task4

            //Console.WriteLine("Введите состояниt светофора: 1 – красный, 2 – желтый, 3 – зеленый");



            //int state = Convert.ToInt32(Console.ReadLine());



            //if (state == 1)

            //{

            //    Console.WriteLine("красный");

            //}

            //else if (state == 2)

            //{

            //    Console.WriteLine("желтый");

            //}

            //else if (state == 3)

            //{

            //    Console.WriteLine("зеленый");

            //}

            //else

            //{

            //    Console.WriteLine("нет такого цвета");

            //}

            //TAsk5



            Random rnd = new Random();

            int randomNumber = rnd.Next(-10, 10);





            if (randomNumber > 0)

            {

                if (randomNumber % 2 == 0)

                {

                    Console.WriteLine($"{randomNumber} - положительное число и четное");



                }

                else

                {

                    Console.WriteLine($"{randomNumber} - положительное число и не четное");

                }

            }

            else



             if (randomNumber % 2 == 0)

            {

                Console.WriteLine($"{randomNumber} - отрицательное число и четное");

            }

            else

            {

                Console.WriteLine($"{randomNumber} - отрицательное число и не четное");

            }

        }





    }

}
