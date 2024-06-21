using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void TestArrayFuncs()
        {
            // var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            //// находим индекс элемента "Bob"
            //int bobIndex = Array.BinarySearch(people, "Bob");
            //// находим индекс первого элемента "Tom"
            //int tomFirstIndex = Array.IndexOf(people, "Tom");
            //// находим индекс последнего элемента "Tom"
            //int tomLastIndex = Array.LastIndexOf(people, "Tom");
            //// находим индекс первого элемента, у которого длина строки больше 3
            //int lengthFirstIndex = Array.FindIndex(people, person => person.Length > 3);
            //// находим индекс последнего элемента, у которого длина строки больше 3
            //int lengthLastIndex = Array.FindLastIndex(people, person => person.Length > 3);

            //Console.WriteLine($"bobIndex: {bobIndex}");                 // 2
            //Console.WriteLine($"tomFirstIndex: {tomFirstIndex}");       // 0
            //Console.WriteLine($"tomLastIndex: {tomLastIndex}");         // 4
            //Console.WriteLine($"lengthFirstIndex: {lengthFirstIndex}"); // 3
            //Console.WriteLine($"lengthLastIndex: {lengthLastIndex}");   // 5

            ////
            //// находим первый и последний элементы
            //// где длина строки больше 3 символов
            //string? first = Array.Find(people, person => person.Length > 3);
            //Console.WriteLine(first); // Kate
            //string? last = Array.FindLast(people, person => person.Length > 3);
            //Console.WriteLine(last); // Alice

            //// находим элементы, у которых длина строки равна 3
            //string[] group = Array.FindAll(people, person => person.Length == 3);
            //foreach (var person in group) Console.WriteLine(person);
            //// Tom Sam Bob Tom

            ////
            //Array.Reverse(people);

            //foreach (var person in people)
            //    Console.Write($"{person} ");
            //// "Alice", "Tom", "Kate", "Bob", "Sam", "Tom"

            ////
            //// изменяем порядок 3 элементов начиная c индекса 1  
            //Array.Reverse(people, 1, 3);

            //foreach (var person in people)
            //    Console.Write($"{person} ");
            //// "Tom", "Kate", "Bob", "Sam", "Tom", "Alice"

            //
            // var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            // уменьшим массив до 4 элементов
            //Array.Resize(ref people, 4);

            //foreach (var person in people)
            //    Console.Write($"{person} ");
            //// "Tom", "Sam", "Bob", "Kate"

            //
            //var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            //var employees = new string[3];

            ////// копируем 3 элемента из массива people c индекса 1  
            ////// и вставляем их в массив employees начиная с индекса 0
            //Array.Copy(people, 1, employees, 0, 3);

            //foreach (var person in employees)
            //    Console.Write($"{person} ");
            //// Sam Bob Kate

            //
            //var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            //Array.Sort(people);

            //foreach (var person in people)
            //    Console.Write($"{person} ");

            //// Alice Bob Kate Sam Tom Tom
            ///
            //var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

            //// сортируем с 1 индекса 3 элемента
            //Array.Sort(people, 1, 3);

            //foreach (var person in people)
            //    Console.Write($"{person} ");

            //// Tom Bob Kate Sam Tom Alice
        }

        public static void TestList()
        {
            //List<string> people = new List<string>() { "Tom", "Bob", "Sam" };

            //// v1
            //people.ForEach(p => Console.WriteLine(p));

            //// v2
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //
            //var people = new List<string>(3) { "Tom", "Bob", "Sam" };

            //string firstPerson = people[0]; // получаем первый элемент
            //Console.WriteLine(firstPerson); // Tom
            //people[0] = "Mike";     // изменяем первый элемент
            //Console.WriteLine(people[0]); // Mike
            //Console.WriteLine(people.Count);
            //Console.WriteLine(people.Capacity);
            //people.Add("Vasya");
            //Console.WriteLine(people.Count);
            //Console.WriteLine(people.Capacity);
            //people.Add("Vasya");
            //Console.WriteLine(people.Count);
            //Console.WriteLine(people.Capacity);

            // добавление
            //List<string> people = new List<string>() { "Tom" };

            //people.Add("Bob"); // добавление элемента
            //                   // people = { "Tom", "Bob" };

            //people.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
            //                                             // people = { "Tom", "Bob", "Sam", "Alice" };
            //                                             // также можно было бы добавить другой список
            //                                             // people.AddRange(new List<string>(){ "Sam", "Alice" });

            //people.Insert(0, "Eugene"); // вставляем на первое место
            //                            // people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };

            //people.InsertRange(1, new string[] { "Mike", "Kate" }); // вставляем массив с индекса 1
            //                                                        // people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };

            // также можно было бы добавить другой список
            // people.InsertRange(1, new List<string>(){ "Mike", "Kate" });

            //  удаление
            //var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            //people.RemoveAt(1); //  удаляем второй элемент
            //                    // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            //people.Remove("Tom"); //  удаляем элемент "Tom"
            //                      // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };

            //// удаляем из списка все элементы, длина строки которых равна 3
            //people.RemoveAll(person => person.Length == 3);
            //// people = { "Eugene", "Kate", "Alice" };

            //// удаляем из списка 2 элемента начиная с индекса 1
            //people.RemoveRange(1, 2);
            //// people = { "Eugene"};

            //// полностью очищаем список
            //people.Clear();
            //// people = {  };

            //// поиск и проверка значения
            //var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

            //var containsBob = people.Contains("Bob");     //  true
            //var containsBill = people.Contains("Bill");    // false
            //var result = people.Any(); // вернет true если в массиве есть хотя бы один элемент

            //// проверяем, есть ли в списке строки с длиной 3 символа
            //var existsLength3 = people.Exists(p => p.Length == 3);  // true

            //// проверяем, есть ли в списке строки с длиной 7 символов
            //var existsLength7 = people.Exists(p => p.Length == 7);  // false

            //// получаем первый элемент с длиной в 3 символа
            //var firstWithLength3 = people.Find(p => p.Length == 3); // Tom

            //// получаем последний элемент с длиной в 3 символа
            //var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam

            //// получаем все элементы с длиной в 3 символа в виде списка
            //List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);
            //// peopleWithLength3 { "Tom", "Bob", "Sam"}

            //// получение диапазона и копирование данных
            //List<string> people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

            //// получаем диапазон со второго по четвертый элемент
            //var range = people.GetRange(1, 3);
            //// range = { "Tom", "Mike", "Sam"};

            ////// копируем в массив первые три элемента
            //string[] partOfPeople = new string[3];
            //people.CopyTo(0, partOfPeople, 0, 3);
            //// partOfPeople = { "Eugene", "Tom", "Mike"};

            //// реверс значений
            //var people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

            //// переворачиваем весь список
            //people.Reverse();
            //// people = { "Bob","Sam", "Mike", "Tom", "Eugene"};

            //var people2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            //// переворачиваем часть только 3 элемента с индекса 1
            //people2.Reverse(1, 3);
            //// people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };

        }

        // двусвязный список
        // Класс LinkedListNode имеет следующие свойства:

        // Value: возвращает или устанавливает само значение узла, представленное типом T

        // Next: возвращает ссылку на следующий элемент типа LinkedListNode<T> в списке.
        // Если следующий элемент отсутствует, то имеет значение null

        // Previous: возвращает ссылку предыдущий элемент типа LinkedListNode<T> в списке.
        // Если предыдущий элемент отсутствует, то имеет значение null

        //AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode) : вставляет узел newNode в список после узла node.

        //AddAfter(LinkedListNode<T> node, T value): вставляет в список новый узел со значением value после узла node.

        //AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode): вставляет в список узел newNode перед узлом node.

        //AddBefore(LinkedListNode<T> node, T value): вставляет в список новый узел со значением value перед узлом node.

        //AddFirst(LinkedListNode<T> node): вставляет новый узел в начало списка

        //AddFirst(T value) : вставляет новый узел со значением value в начало списка

        //AddLast(LinkedListNode<T> node): вставляет новый узел в конец списка

        //AddLast(T value) : вставляет новый узел со значением value в конец списка

        //RemoveFirst(): удаляет первый узел из списка.После этого новым первым узлом становится узел, следующий за удаленным

        //RemoveLast(): удаляет последний узел из списка
        public static void LinkedListTest()
        {
            //var employees = new List<string> { "Tom", "Sam", "Bob" };

            //LinkedList<string> people = new LinkedList<string>(employees);
            //foreach (string person in people)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine(people.Count);            // 3
            //Console.WriteLine(people.First?.Value);    // Tom
            //Console.WriteLine(people.Last?.Value);    // Bob

            //
            //var people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

            //// от начала до конца списка
            //var currentNode = people.First;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}

            //// с конца до начала списка
            //currentNode = people.Last;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Previous;
            //}

            //var people = new LinkedList<string>();
            //people.AddLast("Tom"); // вставляем узел со значением Tom на последнее место
            //                       //так как в списке нет узлов, то последнее будет также и первым
            //people.AddFirst("Bob"); // вставляем узел со значением Bob на первое место

            //// вставляем после первого узла новый узел со значением Mike
            //if (people.First != null) people.AddAfter(people.First, "Mike");

            //// теперь у нас список имеет следующую последовательность: Bob Mike Tom
            //foreach (var person in people) Console.WriteLine(person);
        }

        //void Clear(): очищает очередь

        //bool Contains(T item): возвращает true, если элемент item имеется в очереди

        //T Dequeue(): извлекает и возвращает первый элемент очереди

        //void Enqueue(T item): добавляет элемент в конец очереди

        //T Peek() : просто возвращает первый элемент из начала очереди без его удаления

        //bool TryDequeue(out T result): передает в переменную result первый элемент очереди с его удалением из очереди, возвращает true, если очередь не пуста и элемент успешно получен.

        //bool TryPeek(out T result): передает в переменную result первый элемент очереди без его извлечения из очереди, возвращает true, если очередь не пуста и элемент успешно получен.
        public static void QueueTest()
        {
            // v1
            //var employees = new List<string> { "Tom", "Sam", "Bob" };
            //Queue<string> people = new Queue<string>(employees);
            //foreach (var person in people) Console.WriteLine(person);

            //Console.WriteLine(people.Count);

            //// v2
            //var people = new Queue<string>();

            ////// добавляем элементы
            //people.Enqueue("Tom");  // people = { Tom }
            //people.Enqueue("Bob");  // people = { Tom, Bob }
            //people.Enqueue("Sam");  // people = { Tom, Bob, Sam }

            //// получаем элемент из самого начала очереди 
            //var firstPerson = people.Peek();
            //Console.WriteLine(firstPerson); // Tom

            ////// удаляем элементы
            //var person1 = people.Dequeue();  // people = { Bob, Sam  }
            //Console.WriteLine(person1); // Tom
            //var person2 = people.Dequeue();  // people = { Sam  }
            //Console.WriteLine(person2); // Bob
            //var person3 = people.Dequeue();  // people = {  }
            //Console.WriteLine(person3); // Sam

            //people.TryDequeue(out var person4);  // people = {  }
            //Console.WriteLine(person4); // Sam

            // v3
            //var people = new Queue<string>();

            //// добавляем элементы
            //people.Enqueue("Tom");  // people = { Tom }

            //// удаляем элементы
            //var success1 = people.TryDequeue(out var person1);  // success1 = true
            //if (success1) Console.WriteLine(person1); // Tom

            //var success2 = people.TryPeek(out var person2);  // success2 = false
            //if (success2) Console.WriteLine(person2);
        }

        //
        //Clear: очищает стек

        //Contains: проверяет наличие в стеке элемента и возвращает true при его наличии

        //Push: добавляет элемент в стек в верхушку стека

        //Pop: извлекает и возвращает первый элемент из стека

        //Peek: просто возвращает первый элемент из стека без его удаления

        //bool TryPop(out T result): удаляет из стека первый элемент и передает его в переменную result, возвращает true, если очередь не пуста и элемент успешно получен.

        //bool TryPeek(out T result): передает в переменную result первый элемент стека без его извлечения, возвращает true, если элемент успешно получен.
        public static void StackTest()
        {
            //var employees = new List<string> { "Tom", "Sam", "Bob" };
            //Stack<string> people = new Stack<string>(employees);
            //foreach (var person in people) Console.WriteLine(person);

            //Console.WriteLine(people.Count);

            //var people = new Stack<string>();
            //people.Push("Tom");
            //// people = { Tom }
            //people.Push("Sam");
            //// people = { Sam, Tom }
            //people.Push("Bob");
            //// people = { Bob, Sam, Tom }

            //// получаем первый элемент стека без его удаления 
            //string headPerson = people.Peek();
            //Console.WriteLine(headPerson);  // Bob

            //string person1 = people.Pop();
            //// people = { Sam, Tom }
            //Console.WriteLine(person1);  // Bob

            //string person2 = people.Pop();
            //// people = { Tom }
            //Console.WriteLine(person2);  // Sam

            //string person3 = people.Pop();
            //// people = { }
            //Console.WriteLine(person3);  // Tom


            //var people = new Stack<string>();
            //people.Push("Tom");
            //// people = { Tom }

            //// удаляем элементы
            //var success1 = people.TryPop(out var person1);  // success1 = true
            //if (success1) Console.WriteLine(person1); // Tom

            //var success2 = people.TryPeek(out var person2);  // success2 = false
            //if (success2) Console.WriteLine(person2);
        }

        //void Add(K key, V value): добавляет новый элемент в словарь

        //void Clear(): очищает словарь

        //bool ContainsKey(K key): проверяет наличие элемента с определенным ключом и возвращает true при его наличии в словаре

        //bool ContainsValue(V value): проверяет наличие элемента с определенным значением и возвращает true при его наличии в словаре

        //bool Remove(K key): удаляет по ключу элемент из словаря

        //Другая версия этого метода позволяет получить удленный элемент в выходной параметр: bool Remove(K key, out V value)

        //bool TryGetValue(K key, out V value): получает из словаря элемент по ключу key.При успешном получении передает значение элемента в выходной параметр value и возвращает true

        //bool TryAdd(K key, V value): добавляет в словарь элемент с ключом key и значением value.При успешном добавлении возвращает tr
        public static void DictionaryTest()
        {
            // v1
            //var people = new Dictionary<int, string>()
            //{
            //    { 5, "Tom"},
            //    { 3, "Sam"},
            //    { 11, "Bob"}
            //};

            // v2
            var people = new Dictionary<int, string>()
            {
                [5] = "Tom",
                [6] = "Sam",
                [7] = "Bob"
            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
                Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            }

            //// получаем элемент по ключу 6
            string sam = people[6];  // Sam
            Console.WriteLine(sam);  // Sam
                                     // переустанавливаем значение по ключу 6
            people[6] = "Mike";
            Console.WriteLine(people[6]);  // Mike

            // добавляем новый элемент по ключу 22
            people[22] = "Eugene";
            Console.WriteLine(people[22]);  // Eugene

            // v3
            // условная телефонная книга
            var phoneBook = new Dictionary<string, string>();

            // добавляем элемент: ключ - номер телефона, значение - имя абонента
            phoneBook.Add("+123456", "Tom");
            // альтернативное добавление
            // phoneBook["+123456"] = "Tom";

            // Проверка наличия
            var phoneExists1 = phoneBook.ContainsKey("+123456");    // true
            Console.WriteLine($"+123456: {phoneExists1}");
            var phoneExists2 = phoneBook.ContainsKey("+567456");    // false
            Console.WriteLine($"+567456: {phoneExists2}");
            var abonentExists1 = phoneBook.ContainsValue("Tom");      // true
            Console.WriteLine($"Tom: {abonentExists1}");
            var abonentExists2 = phoneBook.ContainsValue("Bob");      // false
            Console.WriteLine($"Bob: {abonentExists2}");

            phoneBook.TryGetValue("+123456", out var username);

            // удаление элемента
            phoneBook.Remove("+123456");

            // проверяем количество элементов после удаления
            Console.WriteLine($"Count: {phoneBook.Count}"); // Count: 0
        }

        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // TestArrayFuncs();
            // TestList();
            // LinkedListTest();
            // QueueTest();
            // StackTest();
            // DictionaryTest();
            //string number = "hello";
            //Console.WriteLine(number.GetHashCode());
            //var test = new object();

            // Дополнительно почитать BigO notation
            //Получение элемента коллекции это O(1).
            //Будь то получение по индексу в массиве, или по ключу в словаре в нотации Big O это будет O(1).
            //Перебор коллекции это O(n).
            //Вложенные циклы по той же коллекции это O(n2).
            //Разделяй и властвуй(Divide and Conquer) всегда O(log n).
            //Итерации которые используют “Разделяй и властвуй” (Divide and Conquer) это O(n log n).

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
            // int[,,,,,] arr_test = new int[2, 3, 4, 5, 6, 4];

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

            ////// v1
            //foreach (var row in matrix)
            //{
            //    foreach (var item in row)
            //    {
            //        Console.Write($"{item}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n");
            ////// v2
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write($"{matrix[i][j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            // Доп задания по матрицам:
            // создать матрицу 10 на 10, заполнить рандомными значениями от 10 до 99
            // вывести на экран
            // - вывести сумму чисел главной диагонали матрицы 
            // - вывести минимальное и максимальное значения побочной диагонали матрицы
            // - ввести с клавиатуры порядковый номер столбца - вывести цифры с этого столбца на экран (аналогично сделать со строчкой)
            // - ввести с клавиатуры порядковый номер одного столбца и потом другого столбца и поменять их местами в матрица (аналогично сделать со строчкой)
        }
    }
}