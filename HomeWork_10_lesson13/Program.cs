
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Lesson.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson
{

    //Створіть клас "Місто". 

    //Необхідно зберігати в полях класу:




    
    public class City
    {
        //назву міста
        // назву регіону
        //назву країни
        //кількість жителів міста
        //поштовий індекс міста
        //телефонний код міста
        public string _cityName { get; set; } = "unnamed";
        public string _regionName { get; set; } = "unnamed";
        public string _countryName { get; set; } = "unnamed";
        public int _population { get; set; } = 0;
        public int _postIndex { get; set; } = 00000;
        public int _phoneCodeNumber { get; set; } = 000;
        //Реалізуйте методи для отримання інформації про місто i протестуйте на різних екземплярах.
        public City( string cityName, string regionName, string countryName, int population, int postIndex, int phoneCodeNumber)
        {
      
            _cityName = cityName;
            _regionName = regionName;
            _countryName = countryName;
            _population = population;
            _postIndex = postIndex;
            _phoneCodeNumber = phoneCodeNumber;

        }
        public  void showCityProps() // метод вывода без передачи параметров 
        {
            Console.WriteLine(
            $"Город: {_cityName} ," +
                $" Область: {_regionName} ," +
                $"страна {_countryName} ," +
                $" Население {_population} ," +
                $" Почтовый индекс: {_postIndex} ," +
                $" телефонный код города {_phoneCodeNumber}");
        }
      

     

    }

    //Створіть клас "Країна". 

    public class Country
    {//Необхідно зберігати в полях класу: 
        //назву країни
        //назви міст країни
        //назву континенту
        //кількість жителів країни
        //телефонний код країни
        //назву столиці
        public string _countryName { get; set; }

        //public List<Pencil> pencils = new List<Pencil>();
        public List <City> _Cities  { get; set; } = new List<City>();
        public string? _continentName { get; set; } 
        public int _populationCountry { get; set; }  = 0;
        public int _phoneCodeNumber { get; set; }
        string? _capitalName { get; set; }
        //Реалізуйте методи отримання інформації про країну і протестуйте на різних екземплярах.

        public Country( List<City> countryCites) 
        {
           
            _Cities = countryCites;
        }

        public void showCities()
        { 
            foreach (City City in _Cities) 
            {
                City.showCityProps();
                Console.WriteLine(City);
            }
        }

        public void AddCity(City city ) 
        {
            _Cities.Add( city );
        }

        public void RemoveCity(City city) 
        {
            if (_Cities == null) { return; }
            _Cities.Remove(city);
        }


        public void CountryInfo()
        { int TotalPopulation = 0;
            Console.Clear();
            Console.WriteLine("Информация о стране");
            Console.WriteLine("В стране существуют такие города:");
            foreach (City _Cities in _Cities)
            {

                Console.WriteLine($"Город:  {_Cities._cityName}\nНаселение города  {_Cities._cityName} - {_Cities._population}");
            }
           
            foreach (City _Cities in _Cities)
            {
                TotalPopulation += _Cities._population;
            }
            Console.Write($"\nПолное население страны :");
            Console.WriteLine(TotalPopulation);
            Console.WriteLine();
        }
       
    }


    public class Program
    {



        enum ProgramFunc
        {
            addCity = 1,
            showCities = 2,
            RemoveCity = 3 ,
            CountryInfo = 4

        }



        // вход в программу 
        public static void Main()
        {
            var Odessa = new City( "Odessa", "Odesskiy", "", 12, 65000, 048);
            var Kyiv = new City( "Kyiv", "Kyivska", "Ukraine", 5, 24000, 044);
             var _Cities = new List <City> { Odessa , Kyiv };
            Country ukraine = new Country(_Cities);


            while (true)
            {
                Console.WriteLine($"Заполните пользовательские данные:\n1.Создать Город\t\n2.Показать города\t\n3.Удалить город\t\n4.Информация о стране\t"); //текст программы

                Console.Write("Введите номер задачи:#");
                var programReq = (ProgramFunc)Convert.ToInt32(Console.ReadLine());
                bool Boollen = true;
                switch (programReq)
                {
                    case ProgramFunc.addCity: // Добавить город 

                        Console.WriteLine("Введите название города");
                        string CityName = Console.ReadLine() ?? "none";

                        Console.WriteLine("Введите название страны");
                        string CountryName = Console.ReadLine() ?? "none";

                        Console.WriteLine("Введите название региона");
                        string regionName = Console.ReadLine() ?? "none";
                        string population;
                        int InputPopulation;
                        while (true) { 
 
                       Console.WriteLine("Введите популяцию");
                        population = Console.ReadLine()!;
                           
                            if (int.TryParse(population, out InputPopulation))
                            {
                                break;
                            }
                            else { Console.WriteLine("ожидается численный ввод"); }
                        }

                        Console.WriteLine("Введите почтовый код");
                       int postcode = Convert.ToInt32(Console.ReadLine());

                       
                        Console.WriteLine("Введите код телефона города");
                        int phoneCodNumber = Convert.ToInt32(Console.ReadLine());

                        City myObject = new City(CityName, CountryName, regionName, InputPopulation, postcode, phoneCodNumber);
                        Console.Clear();
                        myObject.showCityProps();
                        ukraine.AddCity(myObject);
                        break;

                    case ProgramFunc.showCities:
                        ukraine.showCities();
                        break;
              
                    case ProgramFunc.RemoveCity:
                        Console.WriteLine( "Ведите точное название города к удалению" );
                        string RemovedCity = Console.ReadLine() ?? string.Empty;
                        var CityToDelete = ukraine._Cities.FirstOrDefault (x => x._cityName == RemovedCity)!;
                        ukraine.RemoveCity(CityToDelete);
                    break;
                        case ProgramFunc.CountryInfo:
                        ukraine.CountryInfo();
                        break;


                }
            }
             
        }
    }
}



