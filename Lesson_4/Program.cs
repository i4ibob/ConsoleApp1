using System.Text;

namespace Lesson
{
    enum Rating
    {
        NoRating = 0,
        Bad = 1,
        Normal = 2,
        Good = 3
    }

    enum MathActions
    {
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Divide = '/'
    }

    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine(Rating.Good);
            //Console.WriteLine((int)Rating.Good);

            //Console.WriteLine("Enter film rating: ");
            //var filmRating = Convert.ToInt32(Console.ReadLine());

            //if (filmRating == 3)
            //{
            //    Console.WriteLine(Rating.Good);
            //}
            //else if (filmRating == (int)Rating.Normal)
            //{
            //    Console.WriteLine(Rating.Normal);
            //}
            //else if (filmRating == (int)Rating.Bad)
            //{
            //    Console.WriteLine(Rating.Bad);
            //}
            //else
            //{
            //    Console.WriteLine(Rating.NoRating);
            //}

            ////
            //switch (filmRating)
            //{
            //    case (int)Rating.Good:
            //        Console.WriteLine(Rating.Good);
            //        break;
            //    case (int)Rating.Normal:
            //        Console.WriteLine(Rating.Normal);
            //        break;
            //    case (int)Rating.Bad:
            //        Console.WriteLine(Rating.Bad);
            //        break;
            //    default:
            //        Console.WriteLine(Rating.NoRating);
            //        break;
            //}

            ////
            //Console.WriteLine(MathActions.Multiply);
            //Console.WriteLine((int)MathActions.Multiply);
            //Console.WriteLine((char)MathActions.Multiply);
            ////

            //try
            {
                Console.WriteLine("Enter first number: ");
                var firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                var secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter math action: (+ - * /) ");
                var mathAction = (MathActions)Convert.ToChar(Console.ReadLine() ?? string.Empty);

                switch (mathAction)
                {
                    case MathActions.Plus:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case MathActions.Minus:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case MathActions.Multiply:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case MathActions.Divide:
                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber / secondNumber}");
                        break;
                    default:
                        Console.WriteLine("Incorrect math action!");
                        break;
                }
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Не дели на ноль!");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Не правильный тип данных!");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Какая-то ошибка!");
            //    Console.WriteLine(ex.Message);
            //    // Console.WriteLine(ex.StackTrace);
            //}

            ////
            //try
            //{
            //    Console.WriteLine("Enter first num: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter second num: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    try
            //    {
            //        int result = num1 / num2;
            //        Console.WriteLine(result);
            //    }
            //    catch (DivideByZeroException) when (num1 == 0)
            //    {
            //        Console.WriteLine("Не дели ноль на ноль!");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Не дели на ноль!");
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Enter numbers only please");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //    Console.WriteLine(ex.ToString());
            //}

            ////
            //try
            //{
            //    Console.WriteLine("Enter your name: ");
            //    string? userName = Console.ReadLine();

            //    if (userName == null || userName.Length < 2)
            //        throw new Exception("Incorrect name length! Should be more than 1 letter");

            //    Console.WriteLine($"Hello, {userName}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////
            try
            {
                try
                {
                    Console.WriteLine("Enter your name: ");
                    string? name = Console.ReadLine();

                    if (name == null || name.Length < 2)
                    {
                        throw new Exception("Incorrect name length! Should be more than 1 letter");
                    }

                    Console.WriteLine($"Hello, {name}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Message from Inner try: {e.Message}");
                    throw; // то исключение которое возникнет в этом try - продублировать во внешний try
                    // throw new Exception(); // если необходимо отправить какое-то исключение наружу
                }
                finally  // отрабатывает всегда
                {
                    Console.WriteLine("Finally Inner block text...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Message from Outer try: {e.Message}");
            }
            finally  // отрабатывает всегда
            {
                Console.WriteLine("Finally Inner block text...");
            }
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