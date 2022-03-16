using System;
using lab_1.Classes;
using lab_1.Enums;
using static lab_1.lab_1_homework;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonProperties person = PersonProperties.OfName("Sebastian");
            person.Equals(1);
            Console.WriteLine(person.ToString());

            Money money = Money.Of(13, Currency.USD);
            Money result = money * 5;
            Console.WriteLine(result.Value);
            Console.WriteLine(money < Money.Of(5, Currency.USD));
            if (money == Money.Of(13, Currency.USD))
            {
                Console.WriteLine("Równe");
            }
            else
            {
                Console.WriteLine("Różne");
            }
            int c = 5;
            long b = 111111111111115L;
            b = c; // niejawne
            c = (int) b; //jawne
            decimal cost = money;
            double price = (double) money;
            string str = (string) money;
            Console.WriteLine((string) money);
            Console.WriteLine("SORT");
            Money[] pricies =
            {
                Money.Of(11, Currency.PLN),
                Money.Of(16, Currency.USD),
                Money.Of(13, Currency.PLN),
                Money.Of(10, Currency.EUR),
                Money.Of(3, Currency.USD),
                Money.Of(15, Currency.PLN),
            };
            Array.Sort(pricies);
            foreach (var p in pricies)
            {
                Console.WriteLine((string)p);
            }

            var money1 = Money.OfWithException(10, Currency.USD);
            var money2 = Money.OfWithException(15, Currency.USD);
            Console.WriteLine(money1);
            Console.WriteLine(money1 > money2);
            Console.WriteLine(money1 == money2);
            Console.WriteLine(money1 != money2);
            var money3 = money1.Percent(50);
            Console.WriteLine(money3);
            var money4 = money1.ToCurrency(4, Currency.PLN);
            Console.WriteLine(money4);

            var u1 = new Ułamek(10, 15);
            var u2 = new Ułamek(3, 7);
            Console.WriteLine(u1 * u2);
            Console.WriteLine(u1 * u2 + u2);

        }
    }
}
