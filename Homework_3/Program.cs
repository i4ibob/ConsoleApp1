
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
            //Тема ДЗ : условия (if)

            Console.WriteLine("Выберите одно из 3-x заданий указав его порядковый номер:" +
                                "\n1.Определить допущен ли студент к экзамену" +
                                "\n2.Поиск, парного / не парного с последующим арифметическим действием." +
                                "\n3.Калькулятор над двум числами");




            int programNum = Convert.ToInt32(Console.ReadLine());


            if (programNum <= 0 || programNum > 3)

            { Console.WriteLine("такой программы не существует"); }

            else { Console.WriteLine($"Запуск программы {programNum} "); }

            switch (programNum)

            {
                //1.Користувач із клавіатури вводить 5 оцінок студента.
                //Визначити, чи допущено студента до іспиту.
                //Студент отримує допуск, якщо його середній бал 4 бали та вище.
                case 1:
                    Console.Clear();
                    int num = 5; // длина массива
                    int[] score = new int[num]; // создание массива
                    Console.WriteLine($"Вычислить среднюю оценку студента и проверить допуск");
                    Console.WriteLine($"диапазон оценки 0-12;"); // объявляем условие заполнения 


                    for (int i = 0; i < num; i++) // запрашиваем 5 оценок 
                    {
                        int a = i + 1; // думаю есть решение умнее.. 
                        Console.WriteLine($"Введите оценку №{a}:");
                        score[i] = Convert.ToInt32(Console.ReadLine());


                        if (score[i] >= 0 && score[i] <= 12) // проверяем правильность введённых данных
                        { }

                        else // повторный запрос
                        {
                            Console.WriteLine($"Некорректная оценка {score[i]} ");
                            i--;
                        }
                    }



                    int sumScore = 0;
                    for (int i = 0; i < score.Length; i++)
                    {

                        sumScore += score[i];
                    }
                    int result = sumScore / num;

                    if (result < 4)
                    {
                        Console.WriteLine($"средняя оценка {result} , У него нет шансов!");
                    }
                    else
                    {
                        Console.WriteLine($"средняя оценка {result} , Допущен к экзамену ! ");
                    }
                    break;

                //2.Користувач вводить із клавіатури число.
                //Якщо воно парне, помножити його на три, інакше поділити на два.
                //Результат вивести на екран.
                case 2:
                    Console.Clear();
                    Console.Write(
                        "Если число будет кратно двум то проиозйдет умножение числа на 3." +
                        "\nЕсли число не четное то оно разделится на два" +
                        "\nВведите вычисляемое число:");



                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        int result2 = number * 3;
                        Console.WriteLine($"Результат вычисления {number}*3={result2}. ");
                    }

                    else
                    {
                        float result2 = number / 2f;
                        Console.WriteLine($"Результат вычисления {number}/2={result2}. ");
                    }

                break;

                //3.  Написати програму - калькулятор.
                //    Користувач вводить два числа та вибирає арифметичну дію.
                //    Вивести на екран результат.
                case 3:
                    Console.Clear();
                    Console.WriteLine("Калькулятор");
                    Console.WriteLine("Введите число 1:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число 2:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите арифметическое действие (+ - * / ):");
                    string? type = Console.ReadLine(); // подчёркивает предупреждение с Null 

                    if (type == "+") { int result3 = num1 + num2; Console.WriteLine($"Результат: {num1} + {num2}= {result3}"); }
                    else if (type == "-") { int result3 = num1 - num2; Console.WriteLine($"Результат: {num1} - {num2} = {result3}"); }
                    else if (type == "*") { int result3 = num1 * num2; Console.WriteLine($"Результат: {num1} * {num2} = {result3}"); }
                    else if (type == "/") { int result3 = num1 / num2; Console.WriteLine($"Результат: {num1} / {num2} = {result3}"); }
                    else { Console.WriteLine("Ошибка ввода."); }
                    break;

            }
        }
    }
}

               





       
