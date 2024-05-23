using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L9
{
    public class Money
    {
        public int Hryvnia { get; set; }
        public int Kopecks { get; set; }
        public Money(int Hryvnia, int Kopecks)
        {
            this.Hryvnia = Hryvnia;
            this.Kopecks = Kopecks;
            if(Hryvnia < 0 || Kopecks < 0)
            {
                throw new ArgumentException("Деньги не могут быть меньше нуля!!!");
            }
        }
        public static Money operator +(Money m1, Money m2)
        {
            int totalKopecks = m1.Hryvnia * 100 + m1.Kopecks + m2.Hryvnia * 100 + m2.Kopecks;
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static Money operator -(Money m1, Money m2)
        {
            int totalKopecks = m1.Hryvnia * 100 + m1.Kopecks - m2.Hryvnia * 100 - m2.Kopecks;
            if (totalKopecks < 0)
            {
                throw new BankruptExeption("Вы банкрот, у вас деньги меньше 0!!!");
            }
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static Money operator *(Money m1, int multyplier)
        {
            int totalKopecks = (m1.Hryvnia * 100 + m1.Kopecks) * multyplier;
            return new Money(totalKopecks / 100, totalKopecks % 10);
        }
        public static Money operator /(Money m, int divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя!");
            }
            int totalKopecks = m.Hryvnia * 100 + m.Kopecks;
            return new Money(totalKopecks / divisor / 100, totalKopecks % divisor % 100);
        }
        public static bool operator <(Money m1, Money m2)
        {
            return m1.Hryvnia < m2.Hryvnia || (m1.Hryvnia == m2.Hryvnia && m1.Kopecks < m2.Kopecks);
        }
        public static bool operator >(Money m1, Money m2)
        {
            return m1.Hryvnia > m2.Hryvnia || (m1.Hryvnia == m2.Hryvnia && m1.Kopecks > m2.Kopecks);
        }
        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Hryvnia == m2.Hryvnia && m1.Kopecks == m2.Kopecks;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return !(m1 == m2);
        }
        public static Money operator ++(Money m)
        {
            return m + new Money(0, 1);
        }
        public static Money operator --(Money m)
        {
            return m - new Money(0, 1);
        }
        public override string ToString()
        {
            return $"{Hryvnia} грн, {Kopecks} коп";
        }
    }
}
