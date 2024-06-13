
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson
{




    public class Program
    {

        //Відсортувати алгоритмом бульбашкового сортування.
        //Розібратися як працює, продебажити і написати самостійно, не списуючи.

        //public static int[] createArray()
        //{  //Створити масив на 30 чисел та заповнити випадковими числами від 1 до 100.

        //    int arraySize = 30;  //размер массива
        //    int[] randomArray = new int[arraySize]; // создание пространства массива 

        //    Random random = new Random();// генератор случайных чисел 

        //    int from = 10, to = 99;  // диапазон рандома

        //    for (int i = 0; i < arraySize; i++)
        //    {
        //        randomArray[i] = random.Next(from, to); //от 10 до 99 
        //    }

        //    return randomArray;
        //}

        //public static int[] bubbleSort(int[] randomArray)
        //{
        //    int[] sortedArray = new int[randomArray.Length];
            
           
        //    int counter = 0; // считаем количество проходов  
        //        for (int i = 0; i < randomArray.Length; i++)  // создаем цикл который остановиться когда i будет = длине массива
        //        {
              
        //          bool swaped = false;   // записываем состояние переменной в случае если произошла замена значений 
        //            for (int j = 0; j < randomArray.Length - i - 1; j++)
        //            {
        //            counter++;
        //            if (randomArray[j] > randomArray[j + 1])
        //                {
        //                    int temp = randomArray[j];  // создаем "временную" переменную в которую помещаем значение по индексу j
        //                     sortedArray[j] = randomArray[j] = randomArray[j + 1];  // в значение по индексу  j перемещаем следующее за ним значение  (j+1) , а так же на то же место в новом массиве 
        //                    sortedArray[j + 1] = randomArray[j + 1] = temp; // помещаем в значение по индексу (j+1) значение которое храниться во временной переменной 

        //                swaped = true;
        //                }
        //            }
        //        //else
        //        //{
        //        //    sortedArray[i] = randomArray[i];  // вносим в отсортированный массив значение если j+1>j +
        //        //}
        //        if (!swaped)   // оптимизация чтоб не ходить лишний раз по циклу 
        //        { 
        //            break;
        //        }
                
        //        }
        //    return sortedArray;
        //}



        public static int[] showArray(int[] randomArray)   // функция вывода значений массива
        {
            foreach (var i in randomArray) 
            {
                Console.Write($"|_{i}_|"); 
            };
            Console.WriteLine();
            return randomArray;
        }



        public static void Main()
        {
            
           
                //Створити масив на 30 чисел та заповнити випадковими числами від 1 до 100.

                const int arraySize = 30;  //размер массива установить  30
                int[] randomArray = new int[arraySize]; // создание пространства массива 

                Random random = new Random();// генератор случайных чисел 

                int from = 10, to = 99;  // диапазон рандома

                for (int i = 0; i < arraySize; i++)
                {
                    randomArray[i] = random.Next(from, to); //от 10 до 99 
                }

                showArray(randomArray);

                // пузырёк  вместо функции 
                int[] sortedArray = new int[randomArray.Length];


                int counter = 0; // считаем количество проходов  
                for (int i = 0; i < randomArray.Length; i++)  // создаем цикл который остановиться когда i будет = длине массива
                {

                    bool swaped = false;   // записываем состояние переменной в случае если произошла замена значений 
                    for (int j = 0; j < randomArray.Length - i - 1; j++)
                    {
                        counter++;
                        if (randomArray[j] > randomArray[j + 1])
                        {
                            int temp = randomArray[j];  // создаем "временную" переменную в которую помещаем значение по индексу j
                            sortedArray[j] = randomArray[j] = randomArray[j + 1];  // в значение по индексу  j перемещаем следующее за ним значение  (j+1) , а так же на то же место в новом массиве 
                            sortedArray[j + 1] = randomArray[j + 1] = temp; // помещаем в значение по индексу (j+1) значение которое храниться во временной переменной 

                            swaped = true;
                        }
                    }
                    //else
                    //{
                    //    sortedArray[i] = randomArray[i];  // вносим в отсортированный массив значение если j+1>j +
                    //}
                    if (!swaped)   // оптимизация чтоб не ходить лишний раз по циклу 
                    {
                        break;
                    }

                }

                showArray(randomArray); // Выводим отсортированный массив 
                Console.WriteLine(counter);


                // Вывод: по началу решил сделать модернизацию алгоритма так чтоб он записывал значения в новый массив , но после этого осознал что таким обраом сортировка
                // работать не будет и првильным решением было бы просто сохранить старный масив в новом , и после чего уде произвести сортировку над одним из них







                //Продебажить і розібратися з іншими алгоритмами, розглянутими на уроці.
                //FYI: обов'язково написати сортування бульбашкою, додати коментарі з поясненнями на кожному рядку.
                //Додатково - додати коментарі з поясненнями іншим сортуванням, розглянутим на уроці.

           

                // как мы могли узнать с урока , алгоритм пузырьковой сортировки является одним из простейших алгоритмов сортировки , при этом достаточно ресурсоёмкий что отражается на длительности его работы  ~n^2
            //по сравнению с алгоритмом сортировки Вставкой , выборкой или  рекурсивный вид сортировки или же подобным им
            // так же соуществуют быстрые сортировки , но они оправданы на больших массивах данных  и каждая из них используется в зависимости от ситуации 
           

        }


    }
}