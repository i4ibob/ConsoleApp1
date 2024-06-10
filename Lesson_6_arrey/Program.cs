using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // массив - это набор однотипных данных. все значения размещаются последовательно в оперативной памяти
            // crud -> create, read, update, delete

            //// v1
            //int[] nums1 = new int[5] { 1, 2, 3, 4, 5 };
            //// v2
            //int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            //// v3
            //int[] nums3 = new[] { 1, 2, 3, 4, 5 };
            //// v4
            int[] nums4 = { 11, 22, 33, 44, 55 };
            //// v5
            //var nums5 = new int[10];

            //// [] -> индексаторы
            //// индекс -> порядковый номер значения в массиве (начинаются индексы с нуля)

            //Console.WriteLine(nums4);
            //Console.WriteLine(nums4[0]);
            //Console.WriteLine(nums4[2]);
            //Console.WriteLine(nums4[nums4.Length - 1]);

            //nums4[0] = 1111;
            //Console.WriteLine(nums4[0]);

            //// v1
            //for (int i = 0; i < nums4.Length; i++)
            //{
            //    Console.Write($"{nums4[i]} \t");
            //}

            //Console.WriteLine("\n");

            //int j = 0;

            //// v2
            //while (j < nums4.Length)
            //{
            //    Console.Write($"{nums4[j]} \t");
            //    j++;
            //}

            //Console.WriteLine("\n");

            ////// v3
            //foreach (var item in nums4)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            ////
            //// заполнить массив размером 10 рандомными числами
            //const int arrSize = 10;
            //var arr = new int[arrSize];
            //var rnd = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} \t");
            //}
            //Console.WriteLine("\n");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(1, 100);
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            ////Console.WriteLine($"{Guid.NewGuid()}");

            ////// найти среднее арифметическое
            ////var arrSum = 0;

            ////foreach (var item in arr)
            ////{
            ////    arrSum += item;
            ////}

            ////Console.WriteLine($"Sum: {arrSum} avg: {(double)arrSum / arr.Length}\n");

            ////// ввести с клавиатуры число и добавить его в конец массива
            //Console.WriteLine("Enter number: ");
            //var number = Convert.ToInt32(Console.ReadLine());

            //var arr_2 = new int[arr.Length + 1];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr_2[i] = arr[i];
            //}

            //arr_2[arr.Length] = number;

            //foreach (var item in arr_2)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            ////// delete last
            //var arr_3 = new int[arr_2.Length - 1];

            //for (int i = 0; i < arr_2.Length - 1; i++)
            //{
            //    arr_3[i] = arr_2[i];
            //}

            //foreach (var item in arr_3)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            ////// insert by index
            //var arr_4 = new int[arr_3.Length + 1];
            //Console.WriteLine("Enter number to insert: ");
            //var numberToInsert = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter index for insert: ");
            //var indexForInsert = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < arr_3.Length + 1; i++)
            //{
            //    if (indexForInsert < 0 || indexForInsert > arr_3.Length)
            //    {
            //        Console.WriteLine("Incorrect index!");
            //        break;
            //    }

            //    if (i < indexForInsert)
            //    {
            //        arr_4[i] = arr_3[i];
            //    }
            //    else if (i > indexForInsert)
            //    {
            //        arr_4[i] = arr_3[i - 1];
            //    }
            //    else
            //    {
            //        arr_4[indexForInsert] = numberToInsert;
            //    }
            //}

            //foreach (var item in arr_4)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            ////// remove by index
            //var arr_5 = new int[arr_4.Length - 1];
            //Console.WriteLine("Enter index for delete: ");
            //var indexForDelete = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < arr_4.Length - 1; i++)
            //{
            //    if (indexForDelete < 0 || indexForDelete > arr_4.Length)
            //    {
            //        Console.WriteLine("Incorrect index!");
            //        break;
            //    }

            //    if (i < indexForDelete)
            //    {
            //        arr_5[i] = arr_4[i];
            //    }
            //    else if (i >= indexForDelete)
            //    {
            //        arr_5[i] = arr_4[i + 1];
            //    }
            //}

            //foreach (var item in arr_5)
            //{
            //    Console.Write($"{item} \t");
            //}

            //Console.WriteLine("\n");

            //////
            // int[] arr = { 1, 3, 5, 2, 3, 2, 6, 8, 2 };

            // foreach (var item in arr)
            // {
            // Console.Write($"{item} \t");
            // }

            // Console.WriteLine("\n");

            // var numToDelete = 3;

            // var numToDeleteCount = 0;

            // foreach (var item in arr)
            // {
            // if (item == numToDelete)
            // {
            // numToDeleteCount++;
            // }
            // }

            // var newArr = new int[arr.Length - numToDeleteCount];
            // var arrWithIndexesToIgnore = new int[numToDeleteCount];

            // int currentIndexForArrWithIndexesToIgnore = 0;
            // for (int i = 0; i < arr.Length; i++)
            // {
            // if (arr[i] == numToDelete)
            // {
            // arrWithIndexesToIgnore[currentIndexForArrWithIndexesToIgnore] = i;
            // currentIndexForArrWithIndexesToIgnore++;
            // }
            // }

            // foreach (var item in arrWithIndexesToIgnore)
            // {
            // Console.Write($"{item} \t");
            // }

            // Console.WriteLine("\n");

            // var tempNumber = 0;

            // for (int i = 0; i < arr.Length; i++)
            // {
            // bool isCurrentIndexFound = false;

            // foreach (var item in arrWithIndexesToIgnore)
            // {
            // if (i == item)
            // {
            // isCurrentIndexFound = true;
            // tempNumber++;
            // break;
            // }
            // }

            // if (!isCurrentIndexFound)
            // {
            // newArr[i - tempNumber] = arr[i];
            // }
            // }

            // foreach (var item in newArr)
            // {
            // Console.Write($"{item} \t");
            // }

            // Console.WriteLine("\n");
        }
    }
}