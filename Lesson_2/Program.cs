using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // number - переменная - это именованная область в оперативной памяти значение которой можно изменять если это не константа 
            // синтаксис создания переменной: <тип данных> <название переменной> = <оператор присваивания> <значение>;
            // оператор присваивания (=) - занимается сохранением значения в переменную 
            // ; -> конец конструкции (выражения)
            //int number = 10; // создание переменной
            //Console.WriteLine(number); // вывод переменной в консоль
            //number = 20; // меняем значение переменной
            //Console.WriteLine(number); // вывод переменной в консоль

            //int age = 30;
            //string name = "Vasya";

            //Console.WriteLine(name);
            //Console.WriteLine(age);

            // Ctrl + S -> сохранить
            // Ctrl + F5 -> скомпилировать и запустить программу
            // Ctrl + K + C -> comment
            // Ctrl + K + U -> uncomment

            //

            //int userAge = 30;
            //int user_a1ge1 = 30;

            //// тип данных будет определен автоматически (неявная типизация)
            //var name = "Vasya";
            //var age = 30;
            //age = 40;
            //// name = 1;
            ///

            /*
             * многострочный комментарий
             *sdfgs
             *fdg
             *sdfg
             *sdfg
             */

            // float numbers = 12.4f;
            //
            //// bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
            //bool alive = true;
            //bool isDead = false;
            //Console.WriteLine(alive);
            //Console.WriteLine(isDead);

            //// byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
            //byte bit1 = 1;
            //byte bit2 = 102;

            //// sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte
            //sbyte bit_1 = -101;
            //sbyte bit_2 = 127;

            //// short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16
            //short n1 = 1;
            //short n2 = 102;

            //// ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
            //ushort n_1 = 1;
            //ushort n_2 = 102;

            //// int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32.
            //// Все целочисленные литералы по умолчанию представляют значения типа int:
            //int a = 10;
            //int b = 0b101;  // бинарная форма b =5
            //int c = 0xFF;   // шестнадцатеричная форма c = 255
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //// uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
            //uint a_1 = 10;
            //uint b_1 = 0b101;
            //uint c_1 = 0xFF;

            //// long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            //// Представлен системным типом System.Int64
            //long a_2 = -10;
            //long b_2 = 0b101;
            //long c_2 = 0xFF;

            //// ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64
            //ulong a_3 = 10;
            //ulong b_3 = 0b101;
            //ulong c_3 = 0xFF;

            //// float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single
            //float number = 10.5f;  // 10.5F или 10.5f

            //// double: хранит число с плавающей точкой от ±5.0 * 10 - 324 до ±1.7 * 10308 и занимает 8 байта.Представлен системным типом System.Double
            //double number_1 = 10.32;

            ////decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0 * 10 - 28 до ±7.9228 * 1028, может хранить 28 знаков после запятой и занимает 16 байт.Представлен системным типом System.Decimal
            //decimal number_2 = 123.456M;  // 123.456M или 123.456m

            //// Подобным образом все целочисленные литералы рассматриваются как значения типа int.
            //// Чтобы явным образом указать, что целочисленный литерал представляет значение типа uint,
            //// надо использовать суффикс U / u, для типа long -суффикс L / l, а для типа ulong -суффикс UL / ul:

            ////
            //// этот код работает
            //int num1;
            //num1 = 20;

            //// этот код не работает
            //var num2 = num1;
            //num2 = 20;

            //
            // опасное (сужающее) преобразование типов
            // безопасное (расширяющее) преобразование типов

            //int number1 = 100;
            //float number2 = Convert.ToSingle(number1);  // v1 расширяющее, явное так как мы явно указали какой тип будет
            //float number3 = (float)(number1);  // v2
            //float number4 = number1; // расширяющее, неявное так как мы не указываем какой тип данных будет

            //var number5 = 10.5f; // сужающее, явное
            //double number6 = Convert.ToDouble(number5); // расширяющее, явное

            // Доп задание: потестировать приведение к типам с другими типами данных

            // checked - проверит, возможно ли преобразовать к типу, подходит ли значение для типа к которому мы приводим
            // если значение неверное - будет исключение (ошибка)
            //int a = 3;
            //int b = 255;
            //// v1
            //// byte c = (byte)(a + b);

            //// v2
            //byte c = checked((byte)(a + b));
            //Console.WriteLine(c);

            //
            //Console.Write("Enter you name: ");
            ////// string? -> ? означает что тип может хранить null, то есть быть без значения
            //string? name = Console.ReadLine(); // null - отсутствие значения

            //Console.Write("Enter you age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter you hobby: ");
            //string hobby = Console.ReadLine() ?? "No hobby"; // если после ввода с клавиатуры придет null - будет присвоено

            //// в переменную значение которое после ??
            //Console.Write("Enter you salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            ////// \n -> перенос на новую строчку
            ////// \t -> табуляция (4 пробела)
            //Console.WriteLine($"\nName: {name} age: {age} hobby: {hobby} salary: {salary}");

            //
            //char symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.WriteLine((int)symbol);
            //int number = 98;
            //Console.WriteLine((char)number);

            //
            // + - * /
            //Console.WriteLine(2 + 2);
            //Console.WriteLine(2 - 2);
            //Console.WriteLine(2 * 2);
            //Console.WriteLine(2 / 2);
            //// % ->остаток от деления
            //Console.WriteLine(9 % 6);
            //Console.WriteLine(11 % 6);

            //
            // ввести с клавиатуры трехзначное число и вывести сумму цифр этого числа

            Console.WriteLine("Enter 3-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number);
            // 174
            int num1 = number / 100;
            // v1
            // int num2 = number / 10 % 10;
            // v2
            int num2 = number % 100 / 10;
            int num3 = number % 10;
            Console.WriteLine($"n1 {num1} n2 {num2} n3 {num3}");

            int result = num1 + num2 + num3;
            Console.WriteLine($"Sum: {result}");
        }
    }
}