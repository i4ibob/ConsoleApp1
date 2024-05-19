
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    public class Program
    {

        static int Concat(int first, int second, int third, int fourth)
        {

            int result = first * 1000 + second * 100 + third * 10 + fourth * 1;
            return result;
        }

    

        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            // Задание 1.
            Console.WriteLine("Задвние 1. \n Введите 4 однозначных числа для их конкатенации:");
            int first, second, third, fourth;
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            fourth = Convert.ToInt32(Console.ReadLine());
            Concat(first, second, third, fourth);
            Console.WriteLine(Concat(first, second, third, fourth));


            // Задание 2.
            // допустим "654321"


            int User_num, num1 , num2 , num3 , num4 , num5 ,num6;
            Console.WriteLine("Задание 2. \n Введите 6-тизначное  число для того чтоб развернуть его :");

            User_num = Convert.ToInt32(Console.ReadLine());

            num1 = User_num / 100000  / 1;
            num2 = User_num % 100000 / 10000;
            num3 = User_num % 10000 / 1000;
            num4 = User_num % 1000 / 100;
            num5 = User_num % 100 / 10;
            num6 = User_num % 10 / 1;
            Console.WriteLine(num6*100000+num5*10000+num4*1000+num3*100+num2*10+num1);
            Console.WriteLine("через циклы не осилил попробую потом");

            //       // Задание два (через циклы) 
            // User_num = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i < 1000000; i=i*10) 
            //{
            //     int q = i * 10;
            //     int a = User_num % q / i;
            //     //Console.Write(a);

            //     int n = 100000;
            //         int result = a*n;
            //         int mainResult = +result;
            //         Console.WriteLine(mainResult);
            // } //сложно...

        }
    }
}