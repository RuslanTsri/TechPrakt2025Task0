using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class Initializer
    {
        public int Num1 { get; private set; }
        public int Num2 { get; private set; }

        public void InitializeNumbers()
        {
            Num1 = GetValidNumber("Введіть перше число: ");
            Num2 = GetValidNumber("Введіть друге число: ");
        }
        private int GetValidNumber(string message)
        {
            int result;
            string? input;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Будь ласка, введіть коректне ціле число.");
                }
            } while (input == null || !int.TryParse(input, out result));

            return result;
        }
    }
}
