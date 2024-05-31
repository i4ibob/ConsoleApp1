using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //
            // Циклы

            // while -> сначала проверяет, потом делает

            // v1
            //int i = 0;

            //while (i < 5)
            //{
            //    Console.Write($"{i}\t");
            //    i++;
            //}

            // v2
            //int num = 123;

            //while (true)
            //{
            //    num += 12;
            //    Console.WriteLine($"{num}\t");
            //}

            // v3
            //int i = 0;

            //while (true)
            //{              
            //    if (i == 5)
            //    {
            //        Console.WriteLine("Continue...");
            //        i++;
            //        continue; // пропуск дальнейших действий цикла при условии. Но не цикл не останавливается.
            //    }

            //    if (i >= 10)
            //    {
            //        Console.WriteLine("Break...");
            //        break; // полная остановка цикла.
            //    }

            //    Console.WriteLine(i);
            //    i++;
            //}

            // Юзер вводит с клавиатуры числа, если ввел 0 - прекратить ввод чисел с клавиатуры.
            // после - вывести среднее арифметическое числовой последовательности

            //int counter = 0;
            //int numsSum = 0;

            //try
            //{
            //    while (true)
            //    {
            //        int number = 0;

            //        while (true)
            //        {
            //            try
            //            {
            //                Console.WriteLine("Enter any number: (0 - for stop): ");
            //                number = Convert.ToInt32(Console.ReadLine());

            //                if (number == 0 && counter == 0)
            //                {
            //                    Console.WriteLine("Enter at least one non zero number!");
            //                    continue;
            //                }

            //                break;
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Enter valid number!");
            //            }
            //        }

            //        if (number == 0)
            //        {
            //            Console.WriteLine("Stop...");
            //            break;
            //        }

            //        numsSum += number; //numsSum = numsSum + number;
            //        counter++;
            //    }

            //    var average = (double)numsSum / counter;

            //    Console.WriteLine($"Average: {average}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message );
            //}

            //////

            // do ... while -> сначала делает, а потом проверяет

            //while (false)
            //{
            //    Console.WriteLine("test1");
            //}

            //do
            //{
            //    Console.WriteLine("test2");
            //} while (false);

            // for

            // v1
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // v2
            //for (; ; )
            //{
            //    Console.WriteLine("hello");
            //}

            // v3
            //int i = 0;
            //for (; ; )
            //{
            //    if (i < 10)
            //    {
            //        i++;
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(i);
            //Console.WriteLine(i);
            //Console.WriteLine(i);

            // перебирает коллекции (встретим позже)
            //foreach (var letter in "hello")
            //{
            //    Console.WriteLine(letter);
            //}

            /// вложенные циклы
            // v1
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}

            // v2
            //int i = 1;

            //while (i < 10)
            //{
            //    int j = 1;
            //    while (j < 10)
            //    {
            //        Console.Write($"{i * j} \t");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            ////
            // 1.
            //Пользователь вводит с клавиатуры ширину и высоту прямоугольника. Требуется отобразить на экран
            //заполненный прямоугольник с указанными высотой и
            //шириной.Например, если пользователь ввёл высоту 3,
            //а ширину 5 на экране будет выведено:
            //*****
            //*****
            //*****

            //try
            //{
            //    const string symbol = "* ";
            //    Console.WriteLine("Enter width: ");
            //    int width = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter height: ");
            //    int height = Convert.ToInt32(Console.ReadLine());

            //    if (width <= 0 || height <= 0)
            //    {
            //        throw new Exception("Incorrect width or height");
            //    }

            //    for (int i = 0; i < height; i++)
            //    {
            //        for (int j = 0; j < width; j++)
            //        {
            //            Console.Write(symbol);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine (ex.Message);
            //}


            //2.
            //Пользователь вводит с клавиатуры длину и ширину прямоугольника. 
            //Требуется отобразить на экран незаполненный прямоугольник(отображаются только границы прямоугольника). 
            //Размер длины и ширины равен введенным данным.

            //try
            //{
            //    const string symbol = "* ";
            //    const string whitespaces = "  ";
            //    Console.WriteLine("Enter width: ");
            //    int width = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter height: ");
            //    int height = Convert.ToInt32(Console.ReadLine());

            //    if (width <= 0 || height <= 0)
            //    {
            //        throw new Exception("Incorrect width or height");
            //    }

            //    for (int x = 1; x <= height; x++)
            //    {
            //        if (x == 1 || x == height)
            //        {
            //            for (int i = 0; i < width; i++)
            //            {
            //                Console.Write(symbol);
            //            }
            //        }
            //        else
            //        {
            //            Console.Write(symbol);

            //            for (int i = 0; i < height - 2; i++)
            //            {
            //                Console.Write(whitespaces);
            //            }

            //            Console.Write(symbol);
            //        }

            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //3.
            //Показать на экран таблицу умножения в диапазоне,
            //указанном пользователем. Например, если пользователь
            //указал 3 и 5, таблица может выглядеть так
            //3 * 1 = 3 3 * 2 = 6 3 * 3 = 9... 3 * 10 = 30.....................................................................................
            //5 * 1 = 5 5 * 2 = 10 5 * 3 = 15... 5 * 10 = 50

            //try
            //{
            //    Console.WriteLine("Enter start: ");
            //    int start = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter end: ");
            //    int end = Convert.ToInt32(Console.ReadLine());

            //    if (start <= 0 || end <= 0)
            //    {
            //        throw new Exception("Incorrect start or end");
            //    }

            //    if (start > end)
            //    {
            //        int temp = start;
            //        start = end;
            //        end = temp;
            //    }

            //    for (int i = start; i <= end; i++)
            //    {
            //        for (int j = 1; j <= 9; j++)
            //        {
            //            Console.Write($"{i} * {j} = {i * j}\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //4.
            //Написать программу, которая выводит на экран
            //шахматную доску с заданным размером клеточки.Например, три,
            //***---***---***---***---
            //***---***---***---***---
            //***---***---***---***---
            //---***---***---***---***
            //---***---***---***---***
            //---***---***---***---***

            //5.
            //Пользователь вводит любое целое число А. Необходимо
            //вывести все целые числа В, для которых А делиться без остатка
            //на В* В и не делиться без остатка на В* В*В.

            //for (int a = 10; a < 100;  a++)
            //{
            //    Console.Write($"{a}: ");
            //    for (int b = 1; b < a; b++)
            //    {
            //        if (a % (b * b) == 0 && a % (b * b * b) != 0)
            //        {
            //            Console.Write($"{b}\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}


// Основные поля (встроенные переменные) которые хранят инфу об сиключении
// InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения

// Message: хранит сообщение об исключении, текст ошибки

// Source: хранит имя объекта или сборки, которое вызвало исключение

// StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения

// TargetSite: возвращает метод, в котором и было вызвано исключение

// основные типы исключений (вообще их больше, читайте в документации)
// DivideByZeroException: представляет исключение, которое генерируется при делении на ноль

// ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений

// ArgumentException: генерируется, если в метод для параметра передается некорректное значение

// IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений

// InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов

// NullReferenceException: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен)