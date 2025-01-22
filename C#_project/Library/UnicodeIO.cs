using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UnicodeIO
    {
        /// <summary>
        /// Налаштовує консоль для коректної роботи з Юнікодом.
        /// </summary>
        public void SetupUnicode()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Консоль налаштована для роботи з Юнікодом.");
        }

        /// <summary>
        /// Читає текст із вводу користувача.
        /// </summary>
        /// <param name="prompt">Повідомлення для користувача.</param>
        /// <returns>Введений рядок.</returns>
        public string ReadUnicodeInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        /// <summary>
        /// Виводить текст у консоль.
        /// </summary>
        /// <param name="message">Повідомлення для виводу.</param>
        public void WriteUnicodeOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
