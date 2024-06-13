using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson
{
    public class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        // перегрузка функции Hello
        public static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public static void Hello(string name, int age)
        {
            Console.WriteLine($"Hello, {name}! Your age: {age}");
        }

        public static void Hello(int age, string name)
        {
            Console.WriteLine($"Hello, {name}! Your age: {age}");
        }

        // только по типу возвращаемого значения перегрузить функцию нельзя
        //public static int Hello(string name)
        //{
        //    return 1;
        //}

        public static void Greeting() => Console.WriteLine("Hello");

        public static void ShowInfo(string username, int userAge, string hobby = "No hobby")
        {
            Console.WriteLine($"Username: {username}, age: {userAge}, hobby: {hobby}");
        }

        //
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int DivisionV2(int num1, int num2) => num1 / num2;

        public static void ShowMathResult(
            int firstNumber,
            int secondNumber,
            char mathAction,
            int result)
        {
            Console.WriteLine($"{firstNumber} {mathAction} {secondNumber} = {result}");
        }

        public static void Calculate()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter math action + - * / ");
            char mathAction = Convert.ToChar(Console.ReadLine());
            int result;

            switch (mathAction)
            {
                case '+':
                    result = Add(number1, number2);
                    ShowMathResult(number1, number2, mathAction, result);
                    break;
                case '-':
                    result = Sub(number1, number2);
                    ShowMathResult(number1, number2, mathAction, result);
                    break;
                case '*':
                    result = Mult(number1, number2);
                    ShowMathResult(number1, number2, mathAction, result);
                    break;
                case '/':
                    result = Division(number1, number2);
                    ShowMathResult(number1, number2, mathAction, result);
                    break;
                default:
                    Console.WriteLine("Incorrect math action!");
                    break;
            }
        }

        //
        public static bool IsSimple(int number)
        {
            const int startValue = 2;

            if (number < 2)
                return false;

            for (int i = startValue; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static int ShowSimpleNumbers(int[] numbers)
        {
            int counter = 0;

            foreach (var number in numbers)
            {
                if (IsSimple(number))
                {
                    Console.Write($"{number}\t");
                    counter++;
                }
            }

            if (counter > 0) Console.WriteLine();

            return counter;
        }

        public static void InitArr(int[] numbers, int start = 1, int end = 100)
        {
            var random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(start, end);
            }
        }

        public static void ShowArr(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
        }

        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                //Hello(); // вызов функции
                //Hello();
                //Hello("Vasya");
                //string username = "Petya";
                //Hello(username);
                //Hello("Vasya", 33);
                // Hello("Vasya", 33, 123); // No overload for method 'Hello' takes 3 arguments
                // Greeting();

                ////
                //string name = "Petya";
                //int age = 33;
                //ShowInfo(name, age);
                //string hobby = "Walking";
                //// передача параметров по позиции
                //ShowInfo(name, age, hobby);
                //// передача параметров по имени
                //ShowInfo(username: name, userAge: age, hobby: hobby);
                //ShowInfo(userAge: age, username: name, hobby: hobby);

                //
                // Calculate();

                //
                //const int arrSize = 10;
                //var numbersArr = new int[arrSize];
                //InitArr(numbersArr, 1, 10);
                //ShowArr(numbersArr);
                //Console.WriteLine("Simple numbers: ");
                //var simpleNumbersCount = ShowSimpleNumbers(numbersArr);
                //Console.WriteLine($"Simple numbers count: {simpleNumbersCount}");

                //
                //// многомерные массивы
                //// v1
                //int[,] matrix1;
                //// v2
                //int[,] matrin2 = new int[2, 3];
                //// v3
                //int[,] matrin3 = new int[2, 3]
                //{
                //    {1, 3, 5 },
                //    {15, 32, 53 }
                //};
                //// v4
                //int[,] matrin4 = new int[,]
                //{
                //    {1, 3, 5 },
                //    {15, 32, 53 }
                //};
                //// v5
                //int[,] matrin5 = new[,]
                //{
                //    {1, 3, 5 },
                //    {15, 32, 53 }
                //};
                //// v6
                //int[,] matrin6 =
                //{
                //    {1, 3, 5 },
                //    {15, 32, 53 }
                //};

                ////
                //Console.WriteLine(matrin6[1, 1]);

                //int rows = matrin6.GetUpperBound(0) + 1; // кол-во строк (индекс последнего одномерного массива + 1)
                //int columns = matrin6.Length / rows;

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < columns; j++)
                //    {
                //        Console.Write($"{matrin6[i, j]} \t");
                //    }
                //    Console.WriteLine();
                //}

                //Console.WriteLine();

                //int[,,] arr = new int[2, 3, 4];
                //var random = new Random();

                //// init
                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        for (int k = 0; k < 4; k++)
                //        {
                //            arr[i, j, k] = random.Next(10, 99);
                //        }
                //    }
                //}

                //// output
                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        for (int k = 0; k < 4; k++)
                //        {
                //            Console.Write($"{arr[i, j, k]} \t");
                //        }
                //        Console.WriteLine();
                //    }
                //    Console.WriteLine();
                //}

                //
                //int[,,,,,] arr_test = new int[2, 3, 4, 5, 6, 4];

                // зубчастый массив (массив массивов)
                //var random = new Random();

                //const int matrix_rows = 10;
                //int[][] matrix = new int[matrix_rows][];

                //for (int i = 0; i < matrix_rows; i++)
                //{

                //    matrix[i] = new int[random.Next(1, 10)];

                //    for (int j = 0; j < matrix[i].Length; j++)
                //    {
                //        matrix[i][j] = random.Next(1, 10);
                //    }
                //}

                //// v1
                //foreach (var row in matrix)
                //{
                //    foreach (var item in row)
                //    {
                //        Console.Write($"{item}\t");
                //    }
                //    Console.WriteLine();
                //}

                //Console.WriteLine("\n");
                //// v2
                //for (int i = 0; i < matrix.Length; i++)
                //{
                //    for (int j = 0; j < matrix[i].Length; j++)
                //    {
                //        Console.Write($"{matrix[i][j]}\t");
                //    }
                //    Console.WriteLine();
                //}

                //
                //int min = int.MaxValue;
                //int max = int.MinValue;

                // Доп задания по матрицам:
                // создать матрицу 10 на 10, заполнить рандомными значениями от 10 до 99
                // вывести на экран
                // - вывести сумму чисел главной диагонали матрицы 
                // - вывести минимальное и максимальное значения побочной диагонали матрицы
                // - ввести с клавиатуры порядковый номер столбца - вывести цифры с этого столбца на экран (аналогично сделать со строчкой)
                // - ввести с клавиатуры порядковый номер одного столбца и потом другого столбца и поменять их местами в матрица (аналогично сделать со строчкой)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//try
//{
//    Hello();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//void Hello()
//{
//    Console.WriteLine("Hello");
//    var arr = new int[] { 1, 2 };
//    Console.WriteLine(arr[10]);
//}

