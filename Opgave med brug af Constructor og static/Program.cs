using System;

public class Program
{
    public static void Main()
    {
        Person person1 = new Person();
        person1.FirstName = "Jan";
        person1.LastName = "Jensen";
        person1.Address = "Telegrafvej 9";
        person1.PostalCode = "0000";
        person1.City = "Ballerup";

        Person person2 = new Person();
        person2.FirstName = "Thomas";
        person2.LastName = "Val";
        person2.Address = "Vangede 1";
        person2.PostalCode = "1203";
        person2.City = "Gentofte";

        Console.WriteLine("Personoplysninger:");
        Console.WriteLine("----------------------");
        Console.WriteLine("Person 1:");
        Person.WritePersonInstance(person1);
        Console.WriteLine();
        Console.WriteLine("Person 2:");
        Person.WritePersonInstance(person2);
        Console.WriteLine();

        Console.WriteLine("Forekomstoplysninger:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Person 1:");
        Person.WriteInstance(person1);
        Console.WriteLine();
        Console.WriteLine("Person 2:");
        Person.WriteInstance(person2);

        Console.ReadLine(); // Dodana linia, aby aplikacja zatrzymała się przed zakończeniem
    }
}
