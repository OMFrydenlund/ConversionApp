using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionApp
{
    public class AppPage
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Conversion App!\nWhat would you like to convert?:" +
                              "\n1. Currency\n2. Temperature\n3. Weight");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: ConvertCurrency();
                    break;
                case 2: ConvertTemperature();
                    break;
                case 3: ConvertWeight();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
        }

        private void ConvertCurrency()
        {
            Console.WriteLine("Choose currency to convert from:\n1. NOK\n2. EUR\n3. USD");
            int fromCurrencyChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose currency to convert to:\n1. NOK\n2. EUR\n3. USD");
            int toCurrencyChoice = Convert.ToInt32(Console.ReadLine());
            
            
            double fromAmount;
            string fromCurrencyName;
            string toCurrencyName;

            Console.Write("Enter amount to convert: ");
            fromAmount = Convert.ToDouble(Console.ReadLine());

            switch (fromCurrencyChoice)
            {
                case 1:
                    fromCurrencyName = "NOK";
                    break;
                case 2:
                    fromCurrencyName = "EUR";
                    break;
                case 3:
                    fromCurrencyName = "USD";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            switch (toCurrencyChoice)
            {
                case 1:
                    toCurrencyName = "NOK";
                    break; 
                case 2:
                    toCurrencyName = "EUR";
                    break;
                case 3:
                    toCurrencyName = "USD";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            double convertedAmount = ConvertCurrency(fromAmount, fromCurrencyName, toCurrencyName);
            Console.WriteLine($"{fromAmount} {fromCurrencyName} is {convertedAmount} {toCurrencyName}.");
        }

        private double ConvertCurrency(double amountInput, string fromCurrency, string toCurrency)
        {
            double exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            return amountInput * exchangeRate;
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "NOK" && toCurrency == "EUR")
                return 0.088301199;
            else if (fromCurrency == "EUR" && toCurrency == "NOK")
                return 11.325047;
            else if (fromCurrency == "NOK" && toCurrency == "USD")
                return 0.095209812;
            else if (fromCurrency == "USD" && toCurrency == "NOK")
                return 10.503119;
            else if (fromCurrency == "EUR" && toCurrency == "USD")
                return 1.0782499;
            else if (fromCurrency == "USD" && toCurrency == "EUR")
                return 0.92742876;

            return 1.0;
        }

        private void ConvertTemperature()
        {

        }

        private void ConvertWeight()
        {

        }
    }
}
