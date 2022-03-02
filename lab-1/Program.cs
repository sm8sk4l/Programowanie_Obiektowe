using System;
using lab_1.Classes;
using lab_1.Enums;
namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonProperties Person = PersonProperties.OfName("Aaaaa");
            Console.WriteLine(Person.Name);

            Money money = Money.Of(13, Currency.USD);
        }
    }
}
