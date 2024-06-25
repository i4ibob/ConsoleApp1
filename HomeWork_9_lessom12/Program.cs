






using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson
{

    // Написати валідації за допомогою регулярних виразів

    public class Program
    {

        enum ProgramFunc
        {
            homePhone = 1,
            CellPhone = 2,
            email = 3,
            fullName = 4
        }

        //﻿- домашній номер телефону(тільки цифри та довжина номера)
        static string homePhoneReq()
        {
            Console.WriteLine("Введите номер домашнего телефона (7 цифр)");
            string? userInput = Console.ReadLine();
            string homePhone_Validator = "^[0-9]{7}$";


            if (Regex.IsMatch(userInput , homePhone_Validator))

            {
                string phoneNumber = userInput;
                return userInput;

            }
            else
            {
                return "incorrect input";
            }
        }
        //- Мобільний номер телефону(тільки цифри, можлива наявність плюса, довжина номера)
        static string CellPhoneReq()
        {
            Console.WriteLine("Введите Свой мобильный номер телефона (начинается с + Содержит 12 цифр )");
            string? userInput = Console.ReadLine();
            string CellPhone_Validator = "^[+][0-9]{12}$";
            if (Regex.IsMatch(userInput, CellPhone_Validator))

            {
                string cellPhoneNumber = userInput;
                return userInput;

            }
            else
            {
                return "incorrect input";
            }
        }


        //- email(наявність @, домену: gmail.com наприклад, мінімальна довжина та максимальна на ваш вибір)
        static string emailReq()
        {
            Console.WriteLine("Введите существующий Мейл");
            string? userInput = Console.ReadLine();

            string email_Validator = "^[0-9a-zA-Z]+[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,}$";

            if (Regex.IsMatch(userInput, email_Validator))

            {
                string email = userInput;
                return userInput; 

            }
            else
            {
                return "incorrect input";
            }


        }
        //- ПІБ клієнта(3 слова, мінімальна довжина 2 символи, максимальна довжина 20)
        static string fullNameReq()
        {
            Console.WriteLine("Введите полное имя на английском");
            string? userInput = Console.ReadLine(); /*? string.Empty;*/
            string name_Validator = @"^[A-Za-z]{2,20}\s[A-Za-z]{2,20}\s[A-Za-z]{2,20}$";
            if (Regex.IsMatch(userInput , name_Validator))
            {
                string fullName = userInput;
                return userInput;

            }
            else
            {
                return "incorrect input";
            }

        }
        // вход в программу 
        public static void Main()
        {
            string phoneNumber = string.Empty, cellPhoneNumber = string.Empty, email = string.Empty, fullName = string.Empty;
            while (true)
            {
                Console.Clear();
                

                Console.WriteLine($"Заполните пользовательские данные:\n1.Домашний номер телефона\t{phoneNumber}\n2.Мобильный номер телефона\t{cellPhoneNumber}\n3.Мейл\t{email}\n4.Полное Имя\t{fullName}"); //текст программы


                Console.Write("Введите номер Пункта который хотите изменить:#");
                var programReq = (ProgramFunc)Convert.ToInt32(Console.ReadLine());

                switch (programReq)
                {
                    case ProgramFunc.homePhone:
                        phoneNumber = homePhoneReq();
                        break;

                    case ProgramFunc.CellPhone:
                        cellPhoneNumber = CellPhoneReq();
                        break;
                    case ProgramFunc.email:
                        email = emailReq();
                        break;
                    case ProgramFunc.fullName:
                        fullName = fullNameReq();
                        break;

                    

                }
            }
        }
    }

    
}



