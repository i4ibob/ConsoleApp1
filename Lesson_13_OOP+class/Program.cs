using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson
{
    // создание класса
    //class название_класса
    //{
    //    // содержимое класса
    //}

    // v1
    //class Person
    //{
    //    public string name = "Undefined";   // имя
    //    public int age;                     // возраст

    //    // так выглядит по капотом конструктор по умолчанию, руками такое писать нет смысла
    //    // public Person() { } 

    //    public void Print()
    //    {
    //        Console.WriteLine($"Name: {name}  Age: {age}");
    //    }
    //}

    // v2
    // Ключевое слово this представляет ссылку на текущий экземпляр/объект класса.
    //class Person
    //{
    //    public string name;
    //    public int age;
    //    public Person()
    //    {
    //        this.name = "Noname"; // this -> указывает что это часть класса
    //        this.age = 18;
    //    }      // 1 конструктор без параметров
    //    public Person(string name)
    //    {
    //        this.name = name; // чтоб понять где параметр конструктора, а где поле класса
    //        age = 18;
    //    }         // 2 конструктор с параметрами
    //    public Person(string n, int a)
    //    {
    //        name = n;
    //        age = a;
    //    }   // 3 конструктор

    //    public void Print()
    //    {
    //        Console.WriteLine($"Name: {name}  Age: {age}");
    //    }
    //}

    // v3 цепочка вызова конструкторов (конструкторы используют друг друга по цепочке)
    //class Person
    //{
    //    public string name;
    //    public int age;
    //    public Person() : this("Noname")    // первый конструктор
    //    { }
    //    public Person(string name) : this(name, 18) // второй конструктор
    //    { }
    //    public Person(string name, int age)     // третий конструктор
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public void Print() => Console.WriteLine($"Name: {name}  Age: {age}");
    //}

    // v4
    //struct Person
    //{
    //    public string name;
    //    public int age;

    //    public Person() : this("Tom")
    //    { }
    //    public Person(string name) : this(name, 1)
    //    { }
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    //}

    // v5
    // статический метод или поле относится к типу, а не к экземпляру.
    // то есть можно получить доступ не создавая эземпляр, просто написал тип класса

    //class Person
    //{
    //    public static int static_value = 123;
    //    public string name;
    //    public int age;
    //    public Person() : this("Noname")    // первый конструктор
    //    { }
    //    public Person(string name) : this(name, 18) // второй конструктор
    //    { }
    //    public Person(string name, int age)     // третий конструктор
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public void Print() => Console.WriteLine($"Name: {name}  Age: {age}");

    //    public static void Hello() => Console.WriteLine("Hello");
    //}

    // Статические конструкторы не должны иметь модификатор доступа и не принимают параметров

    // Как и в статических методах, в статических конструкторах нельзя использовать ключевое слово this для ссылки на текущий объект класса и можно обращаться только к статическим членам класса

    // Статические конструкторы нельзя вызвать в программе вручную.
    // Они выполняются автоматически при самом первом создании объекта данного класса или при первом обращении к его статическим членам (если таковые имеются)

    //static class InvoiceType
    //{
    //    public static string Urgent = "UrgentInvoice";
    //    public static string Normal = "NormalInvoice";
    //}

    // v6
    // разница между const и readonly: const нигде нельзя изменить, а readonly можно изменить только один раз в конструкторе
    //class MyClass
    //{
    //    public const int number = 0;
    //    public readonly int id = 1;

    //    public MyClass(int num, int id)
    //    {
    //        // this.number = num; // ошибка так как number - const
    //        this.id = id; // нет ошибки так как readonly
    //    }

    //    public void Print()
    //    {
    //        // this.id = 2; // ошибка так как readonly можно изменить ТОЛЬКО в конструкторе один раз
    //        Console.WriteLine(number);
    //        Console.WriteLine(id);
    //    }
    //}


    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// v7
            //var greenPencil = new Pencil(name: "Green-pencil", material: "Metal", cost: 12.5m, color: "Green", manufacturer: "manufacturer-1");
            ////greenPencil.ShowPencilInfo();
            ////greenPencil.Draw();

            //var bluePencil = new Pencil("Blue-pencil", 12.3m, "wood", "blue", "manufacturer-2");
            ////bluePencil.ShowPencilInfo();
            ////bluePencil.Draw();

            //var pencils = new List<Pencil> { greenPencil, bluePencil };

            //var myPenal = new Penal(pencils);
            //myPenal.ShowPensils();

            //Console.WriteLine("\n-------------------------------------\n");

            //myPenal.AddPencil(new Pencil("Black-pencil", 11.3m, "wood", "black", "manufacturer-2"));
            //myPenal.ShowPensils();

            //Console.WriteLine("\n-------------------------------------\n");

            //myPenal.RemovePencil(bluePencil);
            //myPenal.ShowPensils();

            // доп задание:
            // создать класс Группа и класс Студент
            // реализовать аналогичные функции для Группы

            // v6
            //var test = new MyClass(33, 44);
            //test.Print();

            // v5
            //var vasya = new Person();
            //vasya.Print();
            //Console.WriteLine(Person.static_value);
            //Person.Hello();

            //Console.WriteLine(InvoiceType.Urgent);

            // v4
            //var vasya = new Person();
            //vasya.Print();

            //var petya = new Person("Petya");
            //petya.Print();

            //var anton = new Person("Anton", 33);
            //anton.Print();

            // v2 and v3
            //var vasya = new Person();
            //vasya.Print();

            //var petya = new Person("Petya");
            //petya.Print();

            //var anton = new Person("Anton", 33);
            //anton.Print();

            //var www = new Person("Anton", 33, "qqq"); // ошибка так как нет такого конструктора
            //www.Print();

            // v1
            //var vasya = new Person(); // так как в классе мы не определили конструктор, будет вызван конструктор 
            //// по умолчанию. Конструктор - создает экзмепляр класса.
            //vasya.Print();

            //var petya = new Person();
            //petya.Print();

            //Console.WriteLine(petya.name);

            //petya.name = "Petya";
            //Console.WriteLine(petya.name);
            //petya.Print();

            ////
            // мобильный номер телефона (только цифры, возможное наличие плюса, длина номера)
            //var phone = "+380123456578";
            //var phone_regex = @"^[+]?\d{12}$";
            //// домашний номер телефона (только цифры и длина номера)
            //phone_regex = @"^\d{12}$";

            //if (Regex.Match(phone, phone_regex).Success)
            //{
            //    Console.WriteLine("Correct phone!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect phone!");
            //}

            // email (наличие @, домена: gmail.com например, минимальная длина и максимальная на ваш выбор)
            //var email_regex = @"^[a-z]+\d*[@][a-z]+[.][a-zа-я]{2,5}$";
            //var email = "test123qqq111@gmail.com";

            //if (Regex.Match(email, email_regex).Success)
            //{
            //    Console.WriteLine("Correct email!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect email!");
            //}

            // ФИО клиента (3 слова, минимальная длина 2 символа, максимальная длина 20)
            //var fio_regex = @"^[A-Z]{1}[a-z]{1,19}\s[A-Z]{1}[a-z]{1,19}\s[A-Z]{1}[a-z]{1,19}$";
            //// var fio_regex = @"^(\w{2,20}\s){2}$"; // если нужно искать паттерн несколько раз в строке
            //var fio = "vasya vasya vasya";

            //if (Regex.Match(fio, fio_regex).Success)
            //{
            //    Console.WriteLine("Correct fio!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect fio!");
            //}

            // Пароль (минимально: одна большая буква, одна маленькая буква, одна цифра, один символ, длина пароля - от 8 до 16 символов)
            //var password_regex = @"^(?=.{8,16}$)([A-Z]+[a-z]+\d+[.!@#$%^&*]+)$";
            //var password = "Admin123!";

            //if (Regex.Match(password, password_regex).Success)
            //{
            //    Console.WriteLine("Correct password!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect password!");
            //}

            //
            //
            // 
            // упаковка данных (boxing) - приведение значимого типа в ссылочный тип
            // распаковка данных (unboxing) - приведение ссылочного типа в значимый тип
            // Важно! распаковать мы можем только в тот тип который был изначально в процессе упаковки
            // int -> object - упаковка
            // object -> int - распаковка
            // object -> short - будет ошибка распаковки так как внутри есть таблица которая хранит инфу
            // о первоначальном типе который был упакован
            // нужно избегать упаковки и распаковки так как это негативно сказывается на производительности
            // и чревато ошибками

            //var number = 10;
            //Console.WriteLine(number);
            //var num_obj = (object)number;
            //Console.WriteLine(num_obj);
            //var result_int = (int)num_obj;
            //Console.WriteLine(result_int);
            //var result_float = (float)num_obj; // System.InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.Single'.
            //Console.WriteLine(result_float);
        }
    }
}

//# ООП - объектно ориентированное программирование
//# Класс - это кастомный тип данных, который описывает некоторый объект.
//# Класс - чертеж будущего экземпляра объекта.

//# Инкапсуляция - сокрытие внутренней реализации и предоставление санкционированного доступа
//# к интерфейсу класса. Как черный ящик.
//# Абстрагируемся от внутренней реализации.

//# Наследование - создание нового класса на основе уже существующего.
//# Расширение базового класса - дочерним классом.
//# Абстрагируемся от базового класса, используя дочерний класс.
// В C# НЕТ множественного наследования
// множественное наследование можно реализовать с помощью интерфейсов
// класс может наследоваться от одного класса и любого кол-ва интерфейсов

// интерфейс - это контракт, то есть описание полей и методов которые класс обязуется реализовать
// в случае наследования класса от интерфейса

//# Полиморфизм - один интерфейс и много реализаций.
//# Абстрагируемся от конкретной реализации

// Типы данных делятся на значимые и ссылочные

//Типы значений (хранятся в стеке (в windows 1 мегабайт) или куче (heap - вся нераспределенная ОЗУ)):
// значимый тип будет храниться в куче если он является частью ссылочного типа
// например если мы создали поле типа данных int в классе

//Целочисленные типы(byte, sbyte, short, ushort, int, uint, long, ulong)

//Типы с плавающей запятой (float, double)

//Тип decimal

//Тип bool

//Тип char

//Перечисления enum

//Структуры (struct)

// record struct

//Ссылочные типы (хранятся только в куче (heap)):

//Тип object

//Тип string

//Классы (class)

//Интерфейсы(interface)

//Делегаты(delegate)

// record class == record