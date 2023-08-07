using System;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Wystąpił błąd: Podana wartość nie jest liczbą całkowitą!");
                return;
            }

            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+' , '-', '*' , '/' ");
            var action = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę: ");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Wystąpił błąd: Podana wartość nie jest liczbą całkowitą!");
                return;
            }

            var result = Calculate(number1, number2, action);
            Console.WriteLine(string.Format("Wynik twojego działania: {0}", result));



            Console.ReadKey();
        }

        public static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}
