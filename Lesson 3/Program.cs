using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int number = 10;
            //int result = number + 10;

            //// = -> оператор присваивания, отработает последним
            //number = number + 1;
            //Console.WriteLine(number);
            //number += 1; // number = number + 1;
            //number -= 1; // number = number - 1;
            //number *= 1; // number = number * 1;
            //number /= 1; // number = number / 1;
            //number %= 1; // number = number % 1;

            //
            // int num = 10;
            // v1
            //Console.WriteLine(num++); // постфиксный инкремент (увеличение на 1), присваивание нового значения
            // при последующем использовании этой переменной // num = num + 1
            //Console.WriteLine(num);
            // v2
            //Console.WriteLine(++num); // префиксный инкремент (увеличение на 1), присваивание нового значения моментально
            //Console.WriteLine(num);

            // v1
            // Console.WriteLine(num++ + ++num); // 22
            // v2
            // Console.WriteLine(++num + num++);

            //
            //Console.WriteLine(num--); // постфиксный декремент (уменьшение на 1), присваивание нового значения
            //при последующем использовании этой переменной
            //Console.WriteLine(num);
            // v2
            //Console.WriteLine(--num); // префиксный декремент (уменьшение на 1), присваивание нового значения моментально
            //Console.WriteLine(num);

            // v1
            // Console.WriteLine(num-- + --num); // 18
            // v2
            // Console.WriteLine(--num + num--); // 18

            //
            // Console.WriteLine(--num - --num + num++); // 9

            ////
            //
            // операторы: арифметические и логические
            // унарные (только один операнд), бинарные (два операнда), тернарный (три операнда)
            // логические:
            //Console.WriteLine(12 == 12); // (равенство) вернет true если оба операнда равны (одинаковые)
            //Console.WriteLine(12 != 12); // (неравенство) вернет true если оба операнда разные
            //Console.WriteLine(12 > 12); // строго больше
            //Console.WriteLine(12 >= 12);
            //Console.WriteLine(12 <= 12);
            //Console.WriteLine(12 < 12);

            //int n = 10;
            //
            // && -> логическое 'и'. Вернет true если правый и левый операнды вернули true, иначе false
            //Console.WriteLine(10 == 10 && 20 == 20);
            //Console.WriteLine(10 == 10 & 20 == 20); // аналогично && , но & гарантирует что проверка будет 
            //// левого и правого операнда

            //// || -> логическое 'или'. Вернет true если хотя бы один операнд вернул true, иначе false
            //Console.WriteLine(10 == 10 || 10 == ++n);
            //Console.WriteLine(n);
            //Console.WriteLine(10 == 10 | 10 == n++); // аналогично || , но | гарантирует что проверка будет 
            //// левого и правого операнда
            //Console.WriteLine(n);
            //

            //bool isFound = true;
            //Console.WriteLine(isFound);
            //// ! -> унарный оператор, отрицание. Если в переменной true -> будет false и наоборот
            //Console.WriteLine(!isFound); // isFound == false

            // ^ -> исключающее или. вернет true если либо правый, либо левый операнд равен true (но не одновременно)
            // Console.WriteLine(10 == 10 ^ 20 == 20);

            //

            //Console.WriteLine("Enter current hour: ");
            //int hour = Convert.ToInt16(Console.ReadLine());

            //if (hour >= 12 && hour < 24)
            //{
            //    Console.WriteLine("PM");
            //}
            //else if (hour >= 0 && hour < 12)
            //{
            //    Console.WriteLine("AM");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect hour!");
            //}

            //
            //Console.WriteLine("Enter film rating: ");
            //int rating = Convert.ToInt16(Console.ReadLine());

            //if (rating == 4 || rating == 5)
            //{
            //    Console.WriteLine("Good rating");
            //}
            //else if (rating > 0 && rating < 4)
            //{
            //    Console.WriteLine("Normal rating");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect rating!");
            //}

            //
            //Console.WriteLine("Enter mark: ");
            //int mark = Convert.ToInt16(Console.ReadLine());
            //string result = string.Empty;

            //if (mark > 0 && mark <= 12)
            //{
            //    if (mark == 12)
            //    {
            //        result = "Perfect";
            //    }
            //    else
            //    {
            //        result = "OK";
            //    }
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect mark!");
            //}

            // v2
            // <первый операнд - является условием> ? <второй операнд (результат оператора если условие вернуло true> : <третий операнд (результат оператора если условие вернуло false>
            // без вложенностей
            //string result_2 = mark == 12 ? "Perfect" : "OK";
            //Console.WriteLine(result_2);

            // с вложенным условием (синтаксически позволено, но на практике так делать не рекомендуется, так как падает читабельность кода)
            //var result_2 = mark > 0 && mark <= 12 ? mark == 12 ? "Perfect" : "OK" : "Incorrect mark!";
            //Console.WriteLine(result_2);

            // stylecop - ставится через nuget менеджер, предназначен для проверки стилей кода.
            //
            //if (mark > 0 && mark <= 12)
            //{
            //    string result_2 = mark == 12 ? "Perfect" : "OK";
            //    Console.WriteLine(result_2);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect mark!");
            //}

            // ввести с клавиатуры три числа,
            // - вывести кол-во одинаковых чисел
            // - вывести наименьшее и наибольшее числа

            Console.WriteLine("Enter first num: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third num: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            //// 1
            if (n1 == n2 && n2 == n3 && n1 == n3)
            {
                Console.WriteLine("Count equals nums: 3");
            }
            else if (n1 == n2 || n2 == n3 || n1 == n3)
            {
                Console.WriteLine("Count equals nums: 2");
            }
            else
            {
                Console.WriteLine("Count equals nums: 0");
            }

            //// 2
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"Min num: {n1}");
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine($"Min num: {n2}");
            }
            else
            {
                Console.WriteLine($"Min num: {n3}");
            }

            ////
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Max num: {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"Max num: {n2}");
            }
            else
            {
                Console.WriteLine($"Max num: {n3}");
            }
        }
    }
}