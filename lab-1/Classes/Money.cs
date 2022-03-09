using lab_1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Classes
{
    public class Money : IComparable<Money>
    {
        private readonly decimal _value;
        private readonly Currency _currency;
        private Money(decimal value, Currency currency)
        {
            _value = value;
            _currency = currency;
        }

        public decimal Value
        {
            get
            {
                return _value;
            }
        }

        public Currency Currency 
        {
            get
            {
                {
                    return _currency;
                }
            }
        }

        public static Money? Of(decimal value, Currency currency)
        {
            return value < 0 ? null : new Money(value, currency);
        }
        public static Money OfWithException(decimal value, Currency currency)
        {
            if (value != null && value > 0)
            {
                return new Money(value, currency);

            }
            else
            {
                throw new ArgumentOutOfRangeException("Nie mozna stworzyc obiektu");
            }
        }
        public static Money operator *(Money money, decimal factor)
        {
            return Money.OfWithException(money.Value * factor, money.Currency);
        }
        public static Money operator *(decimal factor, Money money)
        {
            return Money.OfWithException(money.Value * factor, money.Currency);
        }
        public static bool operator >(Money a, Money b)
        {
            IsSameCurriencies(a, b);
            return a.Value > b.Value;
        }


        public static bool operator <(Money a, Money b)
        {
            IsSameCurriencies(a, b);
            return a.Value < b.Value;
        }
        private static void IsSameCurriencies(Money a, Money b)
        {
            if (a.Currency != b.Currency)
            {
                throw new ArgumentException("Different curriencies!");
            }
        }

        public static implicit operator decimal(Money money)
        {
            return money.Value;
        }
        public static explicit operator double(Money money)
        {
            return (double)money.Value;
        }
        public static explicit operator string(Money money)
        {
            return $"{money.Value} {money.Currency}";
        }
        

        public override string ToString()
        {
            return $"Value: {_value}, Currency: {_currency}";
        }

        public int CompareTo(Money other)
        {
            int currencyCon = Currency.CompareTo(other.Currency);
            if (currencyCon == 0)
            {
                return Value.CompareTo(other.Value);

            }
            else
            {
                return currencyCon;
            }
        }
    }
}
