using System.Text;

namespace Lesson
{
    public class Program
    {
        public static int[] GenerateRandomNumberArr(int size)
        {
            const int start = 0, end = 100;
            var arr = new int[size];
            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(start, end);
            }

            return arr;
        }

        public static void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //arr[0] = 1111;
        }

        public static void BubbleSortSimple(int[] arr, out int counter)
        {
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                counter++;
            }
        }

        public static void BubbleSortOptimized(int[] arr, out int counter)
        {
            counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool swaped = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaped = true;
                    }
                }

                counter++;

                if (!swaped)
                {
                    return;
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var flag = false;

                for (int j = i - 1; j >= 0 && flag != true;)
                {
                    if (key < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = key;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
        }

        public static void InsertionSortRecursive(int[] arr, int length)
        {
            if (length <= 1)
                return;

            InsertionSortRecursive(arr, length - 1);

            var key = arr[length - 1];
            var i = length - 2;

            while (i >= 0 && arr[i] > key)
            {
                arr[i + 1] = arr[i];
                i--;
            }

            arr[i + 1] = key;
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var smallestValueIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestValueIndex])
                    {
                        smallestValueIndex = j;
                    }
                }

                // swap
                var temp = arr[smallestValueIndex];
                arr[smallestValueIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                const int myArrSize = 3;
                var myArr = GenerateRandomNumberArr(myArrSize);
                // var newMyArr = new int[myArrSize] { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
                //Console.WriteLine(myArr[0]);
                ShowArr(myArr);

                //
                //BubbleSortSimple(myArr);
                //BubbleSortOptimized(myArr);

                //
                //BubbleSortSimple(newMyArr, out int counter);
                //// BubbleSortOptimized(newMyArr, out int counter);
                //Console.WriteLine(counter);

                //
                // InsertionSort(myArr);
                // InsertionSortRecursive(myArr, myArrSize);
                SelectionSort(myArr);
                ShowArr(myArr);
                //Console.WriteLine(myArr[0]);   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}