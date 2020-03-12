using System;
using static System.Console;
namespace Chapter03
{
    class Program
    {

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int row = 1; row <=12; row++)
            {
                WriteLine($"{row} x {number}={row*number}");
            }
        }
        static void RunTimesTable()
        {
            Write("Enter a number between 0 and 255: ");
            if(Byte.TryParse(ReadLine(),out byte number))
            {
                TimesTable(number);
            }
            else
            {
                WriteLine("You did not enter a valid number!");
            }
        }
        static decimal SalesTax(decimal amount,string twoLetterRegionCode)
        {
            decimal rate=0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH":
                rate=0.08M;
                break;
                case "DK":
                case "NO":
                rate = 025M;
                break;
                case "GB":
                case "FR":
                rate=0.2M;
                break;
                case "HU":
                rate=0.27M;
                break;
                case "OR":
                case "AK":
                case "MT":
                rate=0.0M;
                break;
                case "ND":
                case "WI":
                case "ME":
                case "VA":
                rate = 0.05M;
                break;
                case "CA":
                rate = 0.0825M;
                break;
                default:
                rate= 0.06M;
                break;
            }
            return amount*rate;
        }
        static void RunSalesTax()
        {
            Write("Enter amount: ");
            string amountInText=ReadLine();
            Write("Enter a two latter region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText,out decimal amount))
            {
                decimal taxToPay = SalesTax(amount,region);
                WriteLine($"you must {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }
        static void Main(string[] args)
        {
            RunSalesTax();
        }
    }
}
