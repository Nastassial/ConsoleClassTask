
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;

List<Phone> phones = new List<Phone>() 
{ 
    new Phone("+375291234567","Apple", 11.1), 
    new Phone("+375299876543", "Samsung", 22.2), 
    new Phone("+375295437861", "Xiaomi", 33.3) 
};

foreach (Phone phone in phones)
{
    Console.WriteLine("Информация о телефоне:");
    Console.WriteLine($"Номер телефона - {phone.Number}, модель - {phone.Model}, вес - {phone.Weight}");
    phone.ReceiveCall("Неизвестный абонент");
}

Console.WriteLine($"Номер этого телефона {phones[0].GetNumber()}");
phones[1].ReceiveCall("кто-то", "+375291111111");
phones[2].SendMessage("+375291231212", "+375292342323", "+375293453434");
phones[2].SendMessage();
phones[2].SendMessage(new string[] { "+375291231212", "+375292342323", "+375293453434" });

public class Phone
{
    public string Number { get; }
    public string Model { get; }
    public double Weight { get; }

    public Phone() 
    { 
        Number = "+375290000000";
        Model = "неизвестно";
        Weight = 0.0;
    }

    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }

    public Phone(string number, string model, double weight) : this(number, model)
    {
        Weight = weight;
    }

    public void ReceiveCall(string name) => Console.WriteLine($"Звонит {name}");

    public void ReceiveCall(string name, string number) => Console.WriteLine($"Звонит {name} Номер {number}");

    public string GetNumber() => Number ?? "нет номера"; 

    public void SendMessage(params string[] numbers)
    {
        Console.WriteLine("Список номеров:");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
