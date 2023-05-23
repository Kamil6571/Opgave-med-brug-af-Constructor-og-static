using System;

public class Person
{
    private static int instanceCount = 0;

    public int ID { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    public Person()
    {
        instanceCount++;
        ID = instanceCount;
    }

    public static void WritePersonInstance(Person person)
    {
        Console.WriteLine($"ID: {person.ID}");
        Console.WriteLine($"Adres: {person.Address}");
    }

    public static void WriteInstance(Person person)
    {
        Console.WriteLine($"ID: {person.ID}");
        Console.WriteLine($"Navn: {person.FirstName} {person.LastName}");
        Console.WriteLine($"Samlet antal forekomster: {instanceCount}");
    }
}
