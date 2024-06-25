using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// string - immutable тип, при операциях со строчкой - происходит создание новой строки
            // string s1 = "test";
            //Console.WriteLine(s1);
            //string s2 = new string('q', 5);
            //Console.WriteLine(s2);
            //string s3 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
            //Console.WriteLine(s3);
            //string s4 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' }, 1, 4);
            //Console.WriteLine(s4);

            //Console.WriteLine(s1[0]);
            //s1[0] = 'q'; // error так как строка read-only

            //Console.WriteLine(s1.Length);

            //// foreach (char c in s1) Console.WriteLine(c);

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    Console.WriteLine(s1[i]);
            //}

            /////////////////
            //
            //string text1 = "hello", text2 = "hello";

            //if (text1 == text2)
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not equals");
            //}

            ///
            //string text = """
            //    qwerqwer
            //    sdfadfsdfb\n\n
            //        sdfgsdfgsdfg
            //            sdfbsgfdbsdfb
            //    """;
            //Console.WriteLine(text);

            ////
            //string someText = "hello from h1";

            //text = $"""
            //    <h1>{someText}</h1>
            //    """;
            //Console.WriteLine(text);

            //text = $$"""
            //    <h1>{{someText}}</h1>
            //    """;
            //Console.WriteLine(text);

            //
            //Compare: сравнивает две строки с учетом текущей культуры(локали) пользователя
            //string s1 = "wello";
            //string s2 = "world";

            //int result = string.Compare(s1, s2);
            //Console.WriteLine(result);
            //result = string.Compare(s2, s1);
            //Console.WriteLine(result);
            //result = string.Compare("hello", "hello");
            //Console.WriteLine(result);

            //Console.WriteLine(string.Compare("d", "b"));
            //Console.WriteLine(string.Compare("b", "d"));

            //
            //string name = string.Empty;
            //// if (name == "") { }
            //// if (name == string.Empty) { }
            //if (!string.IsNullOrEmpty(name)) { } // если строка не пустая и не null - делать что-то

            ////CompareOrdinal: сравнивает две строки без учета локали

            //////Contains: определяет, содержится ли подстрока в строке

            //Console.WriteLine("hello world".Contains("hello"));

            ////Concat: соединяет строки

            //string t1 = "t1", t2 = "t2";
            //string t3 = t1 + " " + t2; // конкатенация - сложение строк
            //Console.WriteLine(t3);
            //var result = t3.Concat(t1);
            //Console.WriteLine(result);
            //Console.WriteLine(t1);
            //Console.WriteLine(t3);
            //foreach (var t in result) Console.Write(t);


            //CopyTo: копирует часть строки, начиная с определенного индекса в массив

            //string text = "text";
            //char[] letters = new char[10];
            //text.CopyTo(0, letters, 0, 3);

            //foreach (char c in letters) { Console.WriteLine(c); }

            //EndsWith: определяет, совпадает ли конец строки с подстрокой

            //Console.WriteLine("hello world".EndsWith("hello"));
            //Console.WriteLine("hello world".StartsWith("hello"));

            //Format: форматирует строку

            //string username = "Test";
            //int age = 33;
            //string info = $"Name {username} age {age}";
            //Console.WriteLine(info);

            //string name = "Tom";
            //int age = 23;

            //Console.WriteLine("Name: {0}  Age: {1}", name, age);
            //Console.WriteLine("Name: {1}  Age: {0}", name, age);

            //int number = 23;
            //string result = string.Format("{0:d}", number);
            //Console.WriteLine(result); // 23
            //string result2 = string.Format("{0:d4}", number);
            //Console.WriteLine(result2); // 0023

            //int number = 23;
            //string result = string.Format("{0:f}", number);
            //Console.WriteLine(result); // 23,00

            //double number2 = 45.08;
            //string result2 = string.Format("{0:f4}", number2);
            //Console.WriteLine(result2); // 45,0800

            //double number3 = 25.07;
            //string result3 = string.Format("{0:f1}", number3);
            //Console.WriteLine(result3); // 25,1

            //decimal number = 0.15345m;
            //Console.WriteLine("{0:P1}", number);// 15,3%

            //IndexOf: находит индекс первого вхождения символа или подстроки в строке

            // string name = "Vasya";
            //Console.WriteLine(name.IndexOf('a', 3));
            //Console.WriteLine(name.IndexOf('a'));

            //LastIndexOf: находит индекс последнего вхождения символа или подстроки в строке

            //Console.WriteLine(name.LastIndexOf('a'));

            //Insert: вставляет в строку подстроку

            //string text = "text";
            //var result = text.Insert(2, "qqqq");
            //Console.WriteLine(result);

            //Join: соединяет элементы массива строк

            //var names = new List<string> { "Vasya", "", "Petya: Petrov", "Kate: Ivanova", "" };
            //var all_names = string.Join(", ", names);
            //Console.WriteLine(all_names);


            //Replace: замещает в строке символ или подстроку другим символом или подстрокой

            //string text = "hello world hello";
            //var result = text.Replace("hello", "goodbye");
            //Console.WriteLine(result);

            //Split: разделяет одну строку на массив строк

            //var separators = new string[] { ", ", ": " };
            //var names = new List<string> { "Vasya", "", "Petya: Petrov", "Kate: Ivanova", "" };
            //var all_names = string.Join(", ", names);
            //Console.WriteLine(all_names);

            //var names_list = all_names.Split(separators, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            //foreach (var item in names_list)
            //{
            //    Console.WriteLine(item);
            //}

            //Substring: извлекает из строки подстроку, начиная с указанной позиции
            //string text = "hello world";
            //var result1 = text.Substring(3);
            //Console.WriteLine(result1);
            //var result2 = text.Substring(0, 7);
            //Console.WriteLine(result2);

            //var array = new int[] { 1, 2, 3, 4, 5 };
            //var slice1 = array[2..^3];    // array[new Range(2, new Index(3, fromEnd: true))]
            //var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
            //var slice3 = array[2..];      // array[Range.StartAt(2)]
            //var slice4 = array[..];       // array[Range.All]

            //string text = "hello world";
            //Console.WriteLine(text[2..^3]);

            //

            //ToLower: переводит все символы строки в нижний регистр

            //string name = "  Vasya     ";
            //Console.WriteLine(name.ToLower());

            ////ToUpper: переводит все символы строки в верхний регистр

            //Console.WriteLine(name.ToUpper());

            ////Trim: удаляет начальные и конечные пробелы из строки

            //Console.WriteLine(name.Trim());

            // https://learn.microsoft.com/en-us/dotnet/api/system.string.clone?view=net-7.0

            ///

            //string name = "  vaSya  ";
            //name = name.Trim().ToLower();
            //const int firstSymbolIndex = 0;
            //string res = name[firstSymbolIndex].ToString().ToUpper() + name.Substring(firstSymbolIndex + 1);
            //Console.WriteLine(res);

            ///

            // v1
            //var sb = new StringBuilder("Hello world");
            //Console.WriteLine(sb);
            // v2
            //var sb = new StringBuilder("hello world hello", 50);
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.Capacity);

            //////
            //////Append: добавляет подстроку в объект StringBuilder

            //sb.Append("test");
            //Console.WriteLine(sb);

            //////Insert: вставляет подстроку в объект StringBuilder, начиная с определенного индекса

            //sb.Insert(2, "qqqq");
            //Console.WriteLine(sb);

            //////Remove: удаляет определенное количество символов, начиная с определенного индекса

            //sb.Remove(2, 3);
            //Console.WriteLine(sb);

            //////Replace: заменяет все вхождения определенного символа или подстроки на другой символ или подстроку

            //sb.Replace('q', 'l');
            //Console.WriteLine(sb);

            //sb.Append("testttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt");
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.Capacity);

            //var sb = new StringBuilder("hello world hello", 50);

            //sb.Replace("hello", "goodbye", 0, 5);
            //Console.WriteLine(sb);

            ////AppendFormat: добавляет подстроку в конец объекта StringBuilder

            //StringBuilder sb1 = new StringBuilder();
            //decimal value = 16.95m;
            //CultureInfo enGB = CultureInfo.CreateSpecificCulture("en-GB");
            //DateTime dateToday = DateTime.Now;
            //sb1.AppendFormat(enGB, "Final Price: {0:C2}", value);
            //sb1.AppendLine();
            //sb1.AppendFormat(enGB, "Date and Time: {0:d} at {0:t}", dateToday);
            //Console.WriteLine(sb1.ToString());

            ///
            // ^: соответствие должно начинаться в начале строки(например, выражение @"^пр\w*" соответствует слову "привет" в строке "привет мир")

            //$: конец строки(например, выражение @"\w*ир$" соответствует слову "мир" в строке "привет мир", так как часть "ир" находится в самом конце)

            //.: знак точки определяет любой одиночный символ(например, выражение "м.р" соответствует слову "мир" или "мор")

            //*: предыдущий символ повторяется 0 и более раз

            //+: предыдущий символ повторяется 1 и более раз

            //?: предыдущий символ повторяется 0 или 1 раз

            //\s: соответствует любому пробельному символу

            //\S: соответствует любому символу, не являющемуся пробелом

            //\w: соответствует любому алфавитно - цифровому символу

            //\W: соответствует любому не алфавитно-цифровому символу

            //\d: соответствует любой десятичной цифре

            //\D: соответствует любому символу, не являющемуся десятичной цифрой

            //string text = "It is a long eStablished fact estest that a reader will be distracted by the readable content of a page when looking at its layout";
            //var regex = new Regex(@"es(\w*)", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            //var matches = regex.Matches(text);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //    {
            //        Console.Write(match.Value + " ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Nothing");
            //}

            // Compiled: при установке этого значения регулярное выражение компилируется в сборку, что обеспечивает более быстрое выполнение

            //CultureInvariant: при установке этого значения будут игнорироваться региональные различия

            //IgnoreCase: при установке этого значения будет игнорироваться регистр

            //IgnorePatternWhitespace: удаляет из строки пробелы и разрешает комментарии, начинающиеся со знака #

            //Multiline: указывает, что текст надо рассматривать в многострочном режиме.При таком режиме символы "^" и "$" совпадают, соответственно, с началом и концом любой строки, а не с началом и концом всего текста

            //RightToLeft: приписывает читать строку справа налево

            //Singleline: при данном режиме символ "." соответствует любому символу, в том числе последовательности "\n", которая осуществляет переход на следующую строку

            //
            var username = "Vasya";
            string usernameValidator = @"^[A-Z][a-z]{2,}$";

            Console.WriteLine(Regex.IsMatch(username, usernameValidator));

            // [0 - 9a - zA - Z] + ->один или более символ из промежутка указанного внутри[]
            // [./+_-]{0,1} -> 0 или 1 символ из промежутка указанного внутри []
            // [0-9a-zA-Z]+
            // [@]
            // [a-zA-Z0-9]+
            // [.]
            // [a-zA-Z]{2,} -> два или более символа из промежутка указанного внутри []
            string email = "test@gmail.com";
            string email_Validator = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,}$";
            Console.WriteLine(Regex.IsMatch(email, email_Validator));
        }
    }
}