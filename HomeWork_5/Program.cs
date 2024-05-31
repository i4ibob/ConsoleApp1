
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson
{
    public class Program
    {




        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)

        {
            try
            {



                Console.WriteLine("Дано две задачи, выберите номер:");

                int typeOfProgram = Convert.ToInt32(Console.ReadLine());  // var typeOfProgram = Convert.ToChar(Console.Read()); почему когда использовал данный код у меня ломалась программа в -> firstNum = Convert.ToInt32(Console.ReadLine());   !!!!

                switch (typeOfProgram)
                {

                    case 1:

                        //  1.Користувач вводить з клавіатури два числа(початок та кінець діапазону).

                        Console.Write("Введите два числа для задания диапазона.\nNum 1: ");

                        int firstNum = 0;
                        firstNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Num 2: ");
                        int lastNum = 1;
                        lastNum = Convert.ToInt32(Console.ReadLine());


                        if (firstNum == lastNum) {
                            throw new Exception("Не хватает диапазона для вычислений");    
                        }
                        //Потрібно вивести на екран:
                        //Усі числа діапазону;
                        Console.WriteLine("Усі числа діапазону");
                        for (int i = firstNum; i <= lastNum; i++)
                        {
                            Console.Write($"{i} ");

                        }

                        //Усі числа діапазону у спадному порядку;

                        Console.WriteLine();
                        Console.WriteLine("Усі числа діапазону у спадному порядку;");
                        for (int i = lastNum; i >= firstNum; i--)
                        {
                            Console.Write($"{i} ");

                        }
                        //Усі числа, кратні 7;

                        Console.WriteLine();
                        Console.WriteLine("Усі числа, кратні 7;");

                        for (int i = firstNum; i <= lastNum; i++)
                        {
                            if (i % 7 == 0) { Console.Write($"{i} "); }
                        }
                        //Кількість чисел, кратних 5.

                        Console.WriteLine();
                        Console.WriteLine("Кількість чисел, кратних 5.");
                        int eq5 = 0;

                        for (int i = firstNum; i <= lastNum; i++)
                        {
                            if (i % 5 == 0)
                            {
                                eq5++;

                            }

                        }
                        Console.Write($"{eq5} ");

                        Console.ReadKey();

                        break;







                    case 2:

                        Console.Write("Введите два числа для задания диапазона.\nNum 1: ");
                        //2.Користувач вводить із клавіатури два числа.
                        firstNum = 0;
                        firstNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Num 2: ");
                        lastNum = 1;
                        lastNum = Convert.ToInt32(Console.ReadLine());
                        int parn = 0;
                        int neparn = 0;
                        int eq9 = 0;
                        int counterForParn = 0;
                        int counterForNeParn = 0;
                        int counterForeq9 = 0;


                        if (firstNum == lastNum)
                        {
                            throw new Exception("Не хватает диапазона для вычислений");
                        }

                            //Потрібно порахувати окремо суму парних, непарних та чисел,
                            for (int i = firstNum; i <= lastNum; i++)
                        {
                            if (i % 2 == 0)
                            {
                                counterForParn++;
                                parn += i;
                            }
                            else
                            {
                                counterForNeParn++;
                                neparn += i;
                            }

                        }
                        Console.WriteLine($"Сумма парных чисел {parn}\nСумма непарных чисел {neparn}");

                        //кратних 9 у вказаному діапазоні, а також середньоарифметичне кожної групи.

                        for (int i = firstNum; i <= lastNum; i++)
                        {
                            if (i % 9 == 0)
                            {
                                counterForeq9++;
                                eq9 += i;
                            }
                        }
                        Console.WriteLine($"Сумма  чисел кратных 9: {eq9}");

                        Console.WriteLine($"Средняя арифметическая каждой группы \nПарной: {parn / counterForParn}\nНепарной: {neparn / counterForNeParn}\nКратной 9-ти: {eq9 / counterForeq9}");


                        break;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);  }

        }
    }
}