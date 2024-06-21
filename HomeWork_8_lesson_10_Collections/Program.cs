using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson
{
   

    public class Program
    {
        enum functions 
        {
            add = 1 ,
            del = 2,
            change = 3,
            swap = 4
        }



        //Реалізувати(окремими функцiями):
        //додавання завдання до списку завдань
        public static void addTask(List<string> IncomeArray)
        {
            Console.Write("Введите новое задание на сегодня: ");
            string? addTask = Console.ReadLine();
            IncomeArray.Add(addTask);
            Console.Clear();
            Console.WriteLine("Ваш список дел на сегодня:");
                        for (int i = 0; i < IncomeArray.Count; i++)
                        {
                            Console.WriteLine($"#{i+1} {IncomeArray[i]}");
                        }
        }


        //видалення завдання(знайти за індексом)
        public static void delTask(List<string> IncomeArray)
        {
            if (IncomeArray.Count == 0)
            { Console.WriteLine("Пока нечего удалять\n"); }
           else
            { 
               
            Console.Write("Какое задание хотите удалить ? (Введите номер):");
            int delTask = Convert.ToInt32(Console.ReadLine());
                if (delTask > IncomeArray.Count)
                { 
                    Console.WriteLine("Задание не было удалено так как указанное значение за пределами списка\n"); 
                    return;  
                }

            IncomeArray.RemoveAt(delTask-1);
            Console.Clear();
           
            Console.WriteLine("Ваш список дел на сегодня:");
            for (int i = 0; i < IncomeArray.Count; i++)
            {
                Console.WriteLine($"#{i+1} {IncomeArray[i]}");
            }
           }
        }

        //зміна завдання(знайти за індексом)
        public static void changeTask(List<string> IncomeArray)
        {
            Console.Write ("Какое задание хотите изменить ? (Введите номер): ");
            int fixTaskIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("На какое задание хотите изменить ?");
            string? fixTask = Console.ReadLine();
            IncomeArray[fixTaskIndex] = fixTask;
            Console.Clear();

            Console.WriteLine("ваш список дел на сегодня:");
            for (int i = 0; i < IncomeArray.Count; i++)
            {
                Console.WriteLine($"#{i + 1} {IncomeArray[i]}");
            }
        }


        // поменять местами 

        public static void swapTask(List<string> IncomeArray)
        {
            Console.Write("Какое задание хотите поменять местами ? (Введите номер): ");
            int swapTaskIndex1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("На какое задание хотите поменять ?");
            int swapTaskIndex2 = Convert.ToInt32(Console.ReadLine()) - 1;

            if (swapTaskIndex1  > IncomeArray.Count || swapTaskIndex2 > IncomeArray.Count || swapTaskIndex2 == swapTaskIndex1)
            {
                Console.WriteLine("Замена не выполнена , так как указанное значение за пределами списка или индексы равны\n");
                return;
            }


            string temp = IncomeArray[swapTaskIndex1];
            IncomeArray[swapTaskIndex1]= IncomeArray[swapTaskIndex2];
            IncomeArray[swapTaskIndex2] = temp;

            Console.Clear();

            Console.WriteLine("ваш список дел на сегодня:");
            for (int i = 0; i < IncomeArray.Count; i++)
            {
                Console.WriteLine($"#{i + 1} {IncomeArray[i]}");
            }
        }

        //Реалізувати(окремими функцiями):
        public static void Main()
        {

            int FunctNum;
            List<string> Task = new List<string>() { };




            while (true)
            {
                //Створити програму "Список справ". (List)
                if (Task.Count == 0) { Console.WriteLine("Похоже ваш список пуст"); }
                


                Console.Write("\n\nКакое действие желаете произвести? (Выберите номер):" +
               "\n#1. Добавить задание.\n#2. Удалить задание.\n#3. Изменить задание.\n#4. Поменять местами задание.\n(Выберите номер):");
                var functions = (functions)Convert.ToInt32(Console.ReadLine());



                switch (functions)
                {
                    case functions.add:

                        addTask(Task);

                        break;


                    case functions.del:
                        delTask(Task);
                        break;


                    case functions.change:

                        changeTask(Task);

                        break;


                    case functions.swap:
                        swapTask(Task);
                    break;
                    default: Console.WriteLine("Неверный код программы");
                        break;

                }

            }



        }

  

        }
}
