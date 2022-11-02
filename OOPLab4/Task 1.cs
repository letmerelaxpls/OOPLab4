using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab4
{

    class Printer
    {
        public void PrintYellow(string value)
        {
            Console.WriteLine("Type is string");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    
    class Printing
    {
        public static void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterRed
    {
        public void Print(char value)
        {
            Console.WriteLine("Type is char");
            Console.ForegroundColor = ConsoleColor.Red;
            Printing.Print(value.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class PrinterBlue
    {
        public void Print(int value)
        {
            Console.WriteLine("Type is int");
            Console.ForegroundColor = ConsoleColor.Blue;
            Printing.Print(value.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class PrinterGreen 
    {
        public void Print(double value)
        {
            Console.WriteLine("Type is double");
            Console.ForegroundColor = ConsoleColor.Green;
            Printing.Print(value.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PrintYellow("Строка");

            PrinterRed printerRed = new PrinterRed();
            char litera = 'C';
            printerRed.Print(litera);

            PrinterBlue printerBlue = new PrinterBlue();
            int a = 58;
            printerBlue.Print(a);

            PrinterGreen printerGreen = new PrinterGreen();
            double b = 4.542;
            printerGreen.Print(b);

            Console.ReadKey();
        }
    }
}
