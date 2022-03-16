using System;
using lab_1.Enums;

namespace lab_1.Classes
{
    public static class MoneyExtension
    {
        public static Money Percent(this Money money, decimal percent)
        {
            return Money.OfWithException((money.Value * percent) / 100m, money.Currency);
        }
        public static Money ToCurrency(this Money money, decimal factor, Currency curr)
        {
            return Money.OfWithException(money.Value * factor, curr);
        }
    }
}
