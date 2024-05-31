
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson
{
    public  enum MathActions
    {
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Divide = '/'
    }

    public enum NumOfPrograms  // номер программы для запуска 
    {
        Calc = 1,
        Asain_Pizza = 2

    }
    public enum NumOfPizza // создаем список имен пиццы  с постоянным номером.
    {
        Asain_Pizza = 1,
        Pizza_Pink_guy = 2,
        Teriyaki_God_pizza = 3,
        DIY_pizza = 4
    }
    public enum SizeOfPizza  // варианты размеров пиццы 
    {
        Small = 'S', // Стандарт
        Med = 'M', // на 44% больше от 25см
        Large = 'L'  // на 36% больше от 30см ,  и на 96% от 25см 
    }

    public enum PriceOfPizza  // варианты размеров пиццы и увеличение стоимости в процентах
    {
        Small = 1,
        Med = 44, // на 44% больше от 25см
        Large = 96, // на 96% больше от 25см 
        discount = 20
    }
    public  enum SoftDrinkPizza
    {
        Hwachae =1,
        Bubble_Tea =2,
        Chilled_Iced_Tea =3
    }






    public class Pizza  // Создаем класс (шаблон) пиццы.
    {
        public int nameOfPizza;
        public byte? sizeOfPizza;
        public float price_of_pizza;
        public string? contain;
    }

    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {


            try
            {


                {
                    Pizza Asain_Pizza = new Pizza //pizza 1
                    {
                        nameOfPizza = (int)NumOfPizza.Asain_Pizza,
                        price_of_pizza = 7.25f,
                        contain = "Тоффу , Рыбный соус , Лосось , Тунец , Филадельфия",
                    };//pizza 1
                    Pizza Pizza_Pink_guy = new Pizza // pizza 2
                    {
                        nameOfPizza = (int)NumOfPizza.Pizza_Pink_guy,
                        price_of_pizza = 5.25f,
                        contain = "Анчоусы , Ананас, Сливочный соус , острый чилли"
                    };//pizza 2
                    Pizza Teriyaki_God_pizza = new Pizza // pizza 3
                    {
                        nameOfPizza = (int)NumOfPizza.Teriyaki_God_pizza,
                        price_of_pizza = 6.7f,
                        contain = "Терияки соус, Анчоус , Творожный сыр , Руккола , Кедр"

                    }; //pizza 3
                    Pizza DIY_pizza = new Pizza //  pizza 4 
                    {
                        nameOfPizza = (int)NumOfPizza.DIY_pizza,
                        price_of_pizza = 8f,
                        contain = "Пицца сделай сам! \n Напишите ингредиенты по которым мы соберём вашу пиццу!"

                    };//pizza 4

                    //Тема ДЗ :  Винятки, switch, enum, Debugger

                    Console.WriteLine("Выберите одно из 2-x заданий указав его порядковый номер:" +
                                        "\n1.Калькулятор" +
                                        "\n2.Пиццерия \"Asian pizza.\"");




                    int programNum = Convert.ToInt32(Console.ReadLine());


                    if (programNum <= 0 || programNum > 2)

                    { Console.WriteLine("такой программы не существует"); }

                    else { Console.WriteLine($"Запуск программы {programNum} "); }

                    switch (programNum)

                    {
                        case 1:   //тело калькулятора
                            Console.WriteLine("Добро пожаловать в Калькулятор !");
                            {
                                Console.WriteLine("Введите первое число : ");
                                var firstNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите второе число : ");
                                var secondNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите мат действие: (+ - * /) ");
                                var mathAction = (MathActions)Convert.ToChar(Console.ReadLine() ?? string.Empty);

                                switch (mathAction)
                                {
                                    case MathActions.Plus:
                                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber + secondNumber}");
                                        break;
                                    case MathActions.Minus:
                                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber - secondNumber}");
                                        break;
                                    case MathActions.Multiply:
                                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber * secondNumber}");
                                        break;
                                    case MathActions.Divide:
                                        Console.WriteLine($"{firstNumber} {(char)mathAction} {secondNumber} = {firstNumber / secondNumber}");
                                        break;
                                    default:
                                        Console.WriteLine("Неверное мат действие!");
                                        break;
                                }
                            }

                            break;

                        case 2:
                            // 2.Написати програму, що реалізує процедури замовлення та розрахунку його суми в міні-піцерії.
                            //У меню піцерії передбачено 4 види піци та три види напоїв.
                            //Користувачеві виводиться меню(спочатку піци, потім напої), що містить код та назву.
                            //Користувач вводить код бажаного продукту, після чого вводить кількість одиниць продукту.
                            //У піцерії передбачено два види знижок:
                            //■ якщо загальна сума замовлення більше 50$, то розмір знижки становить 20 % суми замовлення;
                            //■ кожна п'ята піца – у подарунок;
                            //■ для напоїв із ціною більше 2$, якщо кількість у замовленні більше трьох, то знижка 15 % (тільки на напої, а не на все замовлення).
                            //Вивести користувачеві «чек» для оплати у вигляді: назва — кількість — ціна.
                            //Разом до оплати.

                            Console.Clear();
                            Console.WriteLine("Добро пожаловать в пиццерию - \"Asian pizza.\"");
                            Console.WriteLine("Желаете выбрать пиццу? \ny/n y - Yes  n - No:");
                            char areClient = Convert.ToChar(Console.ReadLine() ?? string.Empty);

                            switch (areClient)
                            {
                                case 'y':
                                case 'Y':
                                    Console.Clear();
                                    Console.WriteLine("Выберите пиццу указав её номер!");
                                    Console.WriteLine($"#{Asain_Pizza.nameOfPizza} - {NumOfPizza.Asain_Pizza} \n- {Asain_Pizza.contain}\n-Price {Asain_Pizza.price_of_pizza}$");
                                    Console.WriteLine($"#{Pizza_Pink_guy.nameOfPizza} - {NumOfPizza.Pizza_Pink_guy} \n- {Pizza_Pink_guy.contain}\n-Price {Pizza_Pink_guy.price_of_pizza}$");
                                    Console.WriteLine($"#{Teriyaki_God_pizza.nameOfPizza} - {NumOfPizza.Teriyaki_God_pizza} \n- {Teriyaki_God_pizza.contain}\n-Price {Teriyaki_God_pizza.price_of_pizza}$");
                                    Console.WriteLine($"#{DIY_pizza.nameOfPizza} - {NumOfPizza.DIY_pizza} \n- {DIY_pizza.contain} \n-Price {DIY_pizza.price_of_pizza}$");
                                    Console.Write("Выберите пиццу:  #");
                                    var ChoseCodePizza = (NumOfPizza)Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();


                                    float priceOfPizza; // полная стоимость 
                                    int pcsOfPizza = 0; //количество заказанных  пицц 
                                    float freePizzaPrice;// каждая 5 бесплатно (цена бесплатных пицц) 
                                    float resultOfPizzaAfterDiscount = 0;// после скидки за каждую бесплатную пиццу
                                    float resultPizzaPrice = 0f;




                                    switch (ChoseCodePizza) //Выбор пиццы

                                    {
                                        case NumOfPizza.Asain_Pizza:   //Выбор пиццы 1
                                            Console.WriteLine($"Ваша пицца {NumOfPizza.Asain_Pizza}.");
                                            Console.WriteLine($"Выберите размер Пиццы (S/M/L)"); //Выбор размера пиццы 1
                                            var sizeOfPizza = (SizeOfPizza)Convert.ToChar(Console.ReadLine() ?? string.Empty);

                                            Console.Write("выберите количество шт.:");
                                            pcsOfPizza = Convert.ToInt32(Console.ReadLine());
                                            if (sizeOfPizza == SizeOfPizza.Small)
                                            {
                                                priceOfPizza = Asain_Pizza.price_of_pizza * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Asain_Pizza.price_of_pizza; // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Asain_Pizza} - {SizeOfPizza.Small} Size - {Asain_Pizza.price_of_pizza} - {pcsOfPizza} шт. \n Стоимость заказа: {priceOfPizza}$"); //работает
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else if (sizeOfPizza == SizeOfPizza.Med)
                                            {
                                                priceOfPizza = Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Asain_Pizza} - {SizeOfPizza.Med} Size -  {Asain_Pizza.price_of_pizza * 1.44} - {pcsOfPizza} шт.\nСтоимость заказа:{priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }

                                            else if (sizeOfPizza == SizeOfPizza.Large)
                                            {
                                                priceOfPizza = Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Asain_Pizza} - {SizeOfPizza.Large} Size - {Asain_Pizza.price_of_pizza * 1.96} - {pcsOfPizza} шт.\nСтоимость заказа: {priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Неверно введены данные");
                                            } //если ошибка ввода
                                            break;
                                        case NumOfPizza.Pizza_Pink_guy: //Выбор пиццы 2
                                            Console.WriteLine($"Ваша пицца {NumOfPizza.Pizza_Pink_guy}.");
                                            Console.WriteLine($"Выберите размер Пиццы (S/M/L)"); //Выбор размера пиццы 2
                                            sizeOfPizza = (SizeOfPizza)Convert.ToChar(Console.ReadLine() ?? string.Empty);
                                            Console.Write("выберите количество шт.:");
                                            pcsOfPizza = Convert.ToInt32(Console.ReadLine());
                                            if (sizeOfPizza == SizeOfPizza.Small)
                                            {
                                                priceOfPizza = Pizza_Pink_guy.price_of_pizza * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Pizza_Pink_guy.price_of_pizza; // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Pizza_Pink_guy} - {SizeOfPizza.Small} Size - {Pizza_Pink_guy.price_of_pizza} - {pcsOfPizza} шт. \n Стоимость заказа: {priceOfPizza}$"); //работает
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else if (sizeOfPizza == SizeOfPizza.Med)
                                            {
                                                priceOfPizza = Pizza_Pink_guy.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Pizza_Pink_guy.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Pizza_Pink_guy} - {SizeOfPizza.Med} Size -  {Pizza_Pink_guy.price_of_pizza * 1.44} - {pcsOfPizza} шт.\nСтоимость заказа:{priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }

                                            else if (sizeOfPizza == SizeOfPizza.Large)
                                            {
                                                priceOfPizza = Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Asain_Pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Asain_Pizza} - {SizeOfPizza.Large} Size - {Asain_Pizza.price_of_pizza * 1.96} - {pcsOfPizza} шт.\nСтоимость заказа: {priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Неверно введены данные");
                                            } //если ошибка ввода
                                            break;
                                        case NumOfPizza.Teriyaki_God_pizza: //Выбор пиццы  3
                                            Console.WriteLine($"Ваша пицца {NumOfPizza.Teriyaki_God_pizza}.");
                                            Console.WriteLine($"Выберите размер Пиццы (S/M/L)"); //Выбор размера пиццы 3
                                            sizeOfPizza = (SizeOfPizza)Convert.ToChar(Console.ReadLine() ?? string.Empty);
                                            Console.Write("выберите количество шт.:");
                                            pcsOfPizza = Convert.ToInt32(Console.ReadLine());
                                            if (sizeOfPizza == SizeOfPizza.Small)
                                            {
                                                priceOfPizza = Teriyaki_God_pizza.price_of_pizza * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Teriyaki_God_pizza.price_of_pizza; // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Teriyaki_God_pizza} - {SizeOfPizza.Small} Size - {Teriyaki_God_pizza.price_of_pizza} - {pcsOfPizza} шт. \n Стоимость заказа: {priceOfPizza}$"); //работает
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else if (sizeOfPizza == SizeOfPizza.Med)
                                            {
                                                priceOfPizza = Teriyaki_God_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Teriyaki_God_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Teriyaki_God_pizza} - {SizeOfPizza.Med} Size -  {Teriyaki_God_pizza.price_of_pizza * 1.44} - {pcsOfPizza} шт.\nСтоимость заказа:{priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }

                                            else if (sizeOfPizza == SizeOfPizza.Large)
                                            {
                                                priceOfPizza = Teriyaki_God_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * Teriyaki_God_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Teriyaki_God_pizza} - {SizeOfPizza.Large} Size - {Teriyaki_God_pizza.price_of_pizza * 1.96} - {pcsOfPizza} шт.\nСтоимость заказа: {priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Неверно введены данные");
                                            } //если ошибка ввода
                                            break;
                                        case NumOfPizza.DIY_pizza: //Выбор пиццы 4
                                            Console.WriteLine($"Ваша пицца {NumOfPizza.DIY_pizza}.");
                                            Console.WriteLine($"Выберите размер Пиццы (S/M/L)"); //Выбор размера пиццы 4
                                            sizeOfPizza = (SizeOfPizza)Convert.ToChar(Console.ReadLine() ?? string.Empty);
                                            Console.Write("выберите количество шт.:");
                                            pcsOfPizza = Convert.ToInt32(Console.ReadLine());
                                            if (sizeOfPizza == SizeOfPizza.Small)
                                            {
                                                priceOfPizza = DIY_pizza.price_of_pizza * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * DIY_pizza.price_of_pizza; // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.DIY_pizza} - {SizeOfPizza.Small} Size - {DIY_pizza.price_of_pizza} - {pcsOfPizza} шт. \n Стоимость заказа: {priceOfPizza}$"); //работает
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else if (sizeOfPizza == SizeOfPizza.Med)
                                            {
                                                priceOfPizza = DIY_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * DIY_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Med / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.Teriyaki_God_pizza} - {SizeOfPizza.Med} Size -  {DIY_pizza.price_of_pizza * 1.44} - {pcsOfPizza} шт.\nСтоимость заказа:{priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else if (sizeOfPizza == SizeOfPizza.Large)
                                            {
                                                priceOfPizza = DIY_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f) * pcsOfPizza; // цена заказа с учётом размера и количества
                                                freePizzaPrice = pcsOfPizza / 5 * DIY_pizza.price_of_pizza * (1 + (int)PriceOfPizza.Large / 100f); // каждая 5 бесплатно (цена бесплатных пицц) 
                                                resultOfPizzaAfterDiscount = (priceOfPizza - freePizzaPrice);  // после скидки за каждую бесплатную пиццу
                                                Console.WriteLine($"Ваша пицца {NumOfPizza.DIY_pizza} - {SizeOfPizza.Large} Size - {DIY_pizza.price_of_pizza * 1.96} - {pcsOfPizza} шт.\nСтоимость заказа: {priceOfPizza}$");
                                                Console.WriteLine($"У нас акция ! каждая 5-я пицца бесплатно ! Стоимость заказа {resultOfPizzaAfterDiscount} ");
                                            }
                                            else { Console.WriteLine("Неверно введены данные"); }
                                            break;
                                    }
                                    if (resultOfPizzaAfterDiscount > 50) // условие если заказ пицц больше чем на 50$ с условием что каждая пятая пицца бесплатно
                                    {
                                        resultPizzaPrice = resultOfPizzaAfterDiscount * (1 - (int)PriceOfPizza.discount / 100f);
                                        Console.WriteLine($"И снова акция ! ваш заказ выше 50$.\nК оплате при учете скидки в 20% : {resultPizzaPrice}$");
                                    }
                                    else if (resultOfPizzaAfterDiscount < 50) { Console.WriteLine($"К оплате:{resultOfPizzaAfterDiscount}$"); }

                                    Console.Write($"нажмите Y чтоб продолжить:");
                                    Console.ReadLine();
                                    Console.Clear();

                                    Console.WriteLine("Выберите напиток указав его номер!");  // выбор типа напитка 
                                    Console.WriteLine(
                                        $"#{(int)SoftDrinkPizza.Hwachae} {SoftDrinkPizza.Hwachae} , Цена:{(int)SoftDrinkPizza.Hwachae}$\n" +
                                        $"#{(int)SoftDrinkPizza.Bubble_Tea} {SoftDrinkPizza.Bubble_Tea} Цена:{(int)SoftDrinkPizza.Bubble_Tea}$\n" +
                                        $"#{(int)SoftDrinkPizza.Chilled_Iced_Tea} {SoftDrinkPizza.Chilled_Iced_Tea} Цена:{(int)SoftDrinkPizza.Chilled_Iced_Tea}$");// выбор типа напитка 
                                    Console.WriteLine("Выберите напиток:#"); // выбор типа напитка 

                                    var ChoseCodeDrinks = (SoftDrinkPizza)Convert.ToInt32(Console.ReadLine());  // выбор типа напитка

                                    Console.Clear();
                                    var pscOfDrinks = 0;
                                    float PriceOfDrinks = 0;
                                    switch (ChoseCodeDrinks)
                                    {
                                        case SoftDrinkPizza.Hwachae:
                                            Console.Write($"Выберите количество напитков:");
                                            pscOfDrinks = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Вы заказали {SoftDrinkPizza.Hwachae} в количестве : {pscOfDrinks}шт.");
                                            PriceOfDrinks = (int)SoftDrinkPizza.Hwachae * pscOfDrinks;
                                            Console.WriteLine($"стоимость напитков {PriceOfDrinks}");
                                            break;

                                        case SoftDrinkPizza.Bubble_Tea:
                                            Console.Write($"Выберите количество напитков:");
                                            pscOfDrinks = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Вы заказали {SoftDrinkPizza.Bubble_Tea} в количестве : {pscOfDrinks}шт.");
                                            PriceOfDrinks = (int)SoftDrinkPizza.Bubble_Tea * pscOfDrinks;
                                            Console.WriteLine($"стоимость напитков {PriceOfDrinks}");
                                            break;


                                        case SoftDrinkPizza.Chilled_Iced_Tea:
                                            Console.Write($"Выберите количество напитков:");
                                            pscOfDrinks = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Вы заказали {SoftDrinkPizza.Chilled_Iced_Tea} в количестве : {pscOfDrinks}шт.");
                                            PriceOfDrinks = (int)SoftDrinkPizza.Chilled_Iced_Tea * pscOfDrinks;
                                            if (pscOfDrinks > 3) // условие - для напоїв із ціною більше 2$, якщо кількість у замовленні більше трьох, то знижка 15% (тільки на напої, а не на все замовлення).
                                            {
                                                PriceOfDrinks = PriceOfDrinks * 0.85f; // отнимаем 15% от стоимости 
                                                Console.WriteLine($"стоимость напитков с учетом скидки в 15%: {PriceOfDrinks}");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"стоимость напитков {PriceOfDrinks}");
                                            }
                                            break;

                                    }
                                    Console.Write($"Это все? нажмите Y чтоб продолжить:\n");
                                    Console.Read(); Console.WriteLine($"\n(у вас нет выбора)");

                                    Console.Clear();
                                    Console.WriteLine($"Ваш заказ:" +
                                        $"\nПицца: {ChoseCodePizza} {pcsOfPizza}шт. {resultOfPizzaAfterDiscount}$" +
                                        $"\nНапитки: {ChoseCodeDrinks} - {pscOfDrinks}шт. - {PriceOfDrinks}$");
                                    Console.ReadLine();
                                    Console.WriteLine($"Чек:\nк оплате: {resultOfPizzaAfterDiscount + PriceOfDrinks}$");

                                    break;




                                case 'N':
                                case 'n':
                                    Console.WriteLine("Будем ждать ваш заказ! ");
                                    break;
                                default:
                                    Console.WriteLine("Вы нам не клиент !");
                                    break;



                            }

                            break;



                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Message from Outer try: {e.Message}");
            }
             

            
            finally  // отрабатывает всегда
            {
                Console.WriteLine("Finally Inner block text: Не поймал)");
            }
        }   }
}