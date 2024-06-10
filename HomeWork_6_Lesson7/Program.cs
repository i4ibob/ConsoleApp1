
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lesson
{
    public class Program
    {


        //Функції:

        //Завдання 1.Написати функцію, яка приймає два параметри: основу ступеня та показник ступеня, та обчислює ступінь числа на основі отриманих даних.


        public static int Square(int firstNum, int secondNum)
        {
            int result = firstNum;

            for (int i = 1; i < secondNum; i++)
            {
                result *= firstNum;
            }
            return result;
        } //готово

        //Завдання 2. Написати функцію, яка отримує як параметри 2 цілих числа і повертає суму чисел з діапазону між ними.

        public static int Range(int firstNum, int secondNum)
        {
            int result = 0;
            if (firstNum < secondNum) {
                for (int i = firstNum; i < secondNum; i++)
                {
                    if (i != firstNum && i != secondNum)
                    {  result += i;
                    }
                }
            }
            else if (firstNum > secondNum) 
            {
                for (int i = secondNum ; i < firstNum; i++)
                {
                    if (i != firstNum && i != secondNum)
                    {
                        result += i;
                    }
                }


            }


            return result;
        } // готово


        //Завдання 3. Число називається досконалим, якщо сума всіх його дільників дорівнює йому самому. Напишіть функцію пошуку таких чисел у введеному інтервалі.

        public static int[] Perfect(int firstNum, int secondNum)
        {
            firstNum =Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            int indexLength;


            if (firstNum > secondNum)  // проверяем чтоб диаппазон был задан верно 
            {
                int transfer = firstNum;
                firstNum = secondNum;
                secondNum = transfer;
            }


          indexLength = secondNum - firstNum;
            int[] TempArrayNum = new int[indexLength+1]; // создаем массив

            // ищем идеальные числа
            int count = 1;
            int sum = 1;
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = 2; j <= i % j;j++)
                {
                    if (i % j == 0)
                    {
                        sum+=j;
                    }
                }
                if (sum == i) 
                {
                    TempArrayNum[count] = i;
                    count++;
                }
            }
            int[] pefectnum = new int[count];

            for (int i = 0; i < count; i++)
            {
                pefectnum[i] = TempArrayNum[i];
            }

            foreach (int i in pefectnum) 
            {
                Console.WriteLine(i); 
            }

            return pefectnum;
        }  //очень сложно для меня.. нужно больше времени из за отключений электричества не успеваю 

        //Завдання 4. Написати функцію, яка приймає як параметр масив карт і порядковий номер картки, вивести на екран передану їй гральну картку.
        public static void cart(int[,]ReqArray)
        {
            int firstNum = Convert.ToInt32(Console.ReadLine());  // 52 масимум как в колоде карт не считая джокера 
            int secondNum = Convert.ToInt32(Console.ReadLine()); // порядковый номер карты включаеи в себя 13 номиналов
            string[] ArrTypeOfCard =  { "туз","2","3","4","5","6","7","8","9","10","Валет","Дама","Король"}  ;


        } //  из за отключений электричества не успеваю 


        //Завдання 5. Написати функцію, яка визначає, чи є «щасливим» шестизначне число.
        public static void Lucky()
        {

            
           
            int[] reqArr = new int[6];
            int index = 0;
            while (true)
            {
                Console.Write("Введите номер вашего билетика:");
                string? req = Console.ReadLine();
                if (req.Length == 6)
                {
                    int reqInt = Convert.ToInt32(req);

                    for (int i = 5; i >= 0; i--)
                    {
                        reqArr[i] = reqInt % 10;
                        reqInt /= 10;
                    }
                    Console.Write("Номер билета:");

                    foreach (int reqArray in reqArr)
                    { 
                        Console.Write($"{reqArray}");
                        index++;
                        if (index == 3) { Console.Write("|"); }
                        
                    }
                    int firstNum = reqArr[0] + reqArr[1] + reqArr[2];
                    int secondNum = reqArr[3] + reqArr[4] + reqArr[5];

                    Console.WriteLine($"\nПервая половина  чисел= {firstNum}\nВторая половина чисел = {secondNum}");
                    if (firstNum == secondNum) Console.WriteLine("Счастливый билетик!");
                    else Console.WriteLine("Неудачный билетик");



                    break;
                }
                else
                {
                    Console.WriteLine("Поддельный билетик");
                    continue;
                }
            }
              

        } //готово

            public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)

            {
            Console.WriteLine($"#1 Возведение в степень\n" +
                $"#2 Сумма диапазона чисел\n" +
                $"#3 Идеальное числа в массиве \n" +
                $"#4 Массив карт\n" +
                $"#5 Счастливый билет\n" +
                $"Выберите тип программы:");

            int numProgram;
            while (true)
            {
                 numProgram = Convert.ToInt32(Console.ReadLine());
                if (numProgram < 1 || numProgram > 5) 
                {
                    Console.WriteLine("Неверный код программы.\nВыберите тип программы:");
                    continue;
                }
                else { break; }

            }
            int firstNum;
            int secondNum;

            switch (numProgram){
                case 1: // Возведение в степень
                    //запрос данных
                    Console.Write($"Введите первое число (возводимое): ");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Введите второе  число (степень): ");
                   secondNum = Convert.ToInt32(Console.ReadLine());
                    //вызов функции
                    Console.WriteLine(Square(firstNum , secondNum));
                    //отчёт
                    Console.Write($"Программа выполнена успешно.");
                    break;


                case 2: //Сумма диапазона чисел
                    Console.Write($"Введите первое число диапазона: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Введите второе  число диапазона: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    //вызов функции
                    Console.WriteLine(Range(firstNum, secondNum));
                    break;
                case 3: //Идеальное числа в массиве
                    Console.Write($"Введите первое число диапазона: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Введите второе  число диапазона: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                  
                    Console.WriteLine($"Идекальные числа в диапазоне от {firstNum} до {secondNum}");
                    Perfect(firstNum, secondNum);
                    //вызов функции
                    Console.WriteLine();
                    break;
                case 4: //Массив карт

                    break;
                case 5: //Счастливый билет

                    Lucky();
                    break;

            }
            }
    }
}

