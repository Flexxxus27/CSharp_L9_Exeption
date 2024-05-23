namespace CSharp_L9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 25);
            Console.WriteLine("Денюжка1: " + money1.ToString());
            Console.WriteLine("Денюжка2: " + money2.ToString());
            try
            {
                Money m = money1 - new Money(100, 0);
                Money sum = money1 + money2;
                Console.WriteLine(sum.ToString());

                Money diff = money1 - money2;
                Console.WriteLine(diff.ToString());

                Money div = money1 / 2;
                Console.WriteLine(div.ToString());

                Money mul = money2 * 3;
                Console.WriteLine(mul.ToString());

                Money inc = ++money1;
                Console.WriteLine(inc.ToString());

                Money dec = --money2;
                Console.WriteLine(dec.ToString());

                Console.WriteLine("Money 1 > Money 2: " + (money1 > money2));
                Console.WriteLine("Money 1 < Money 2: " + (money1 < money2));
                Console.WriteLine("Money 1 == Money 2: " + (money1 == money2));
            }
            catch (BankruptExeption ex)
            {
                Console.WriteLine("Bankrupt ex: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exeption : " + ex.Message);
            }
        }
    }
}
