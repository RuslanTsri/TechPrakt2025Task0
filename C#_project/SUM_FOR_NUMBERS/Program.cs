using System;
using System.Reflection;
using Library;

class Program
{
   
    static void Main(string[] args)
    {
        // Ініціалізуємо об'єкти класів з бібліотеки
        UnicodeIO unicodeIO = new UnicodeIO();
        unicodeIO.SetupUnicode();

        Initializer initializer = new Initializer();
        initializer.InitializeNumbers();

        Adder adder = new Adder();
        int result = adder.Add(initializer.Num1, initializer.Num2);

        Printer printer = new Printer();
        printer.PrintResult(result);
    }
}
