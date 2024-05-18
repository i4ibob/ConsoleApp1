
//HW L1  types and 
// main part


string name;
string surname;
int age;

name = "Goga";
surname = "Zuck";
age = 69;

Console.WriteLine(name);
Console.WriteLine(surname);
Console.WriteLine(age);

Console.WriteLine($"\n\nHello, my name is {name} {surname} 0_0 \n  my age is {age} ");



short answer = -25;

while (true)
{
    Console.WriteLine("\nЧтоб выйти ответье на вопрос: \n Cколько будет 25-50?");
    int userAnswer = Convert.ToInt32(Console.ReadLine());
    if (userAnswer != answer)
    {
        Console.WriteLine("ответ не верный");
        continue;
    }
    else
    {
        Console.WriteLine("Подтвердите выход " +
            "\n Press any key...");
        break;
    }
  
}
Console.ReadKey();

// Примечание.
// Не пойму куда пропала точка входа в программу  метод Main  и class Program