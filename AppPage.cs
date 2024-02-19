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
            Console.WriteLine("Welcome to the Conversion App!\n\nWhat would you like to convert?:" +
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
            Console.Clear();
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

            Console.Clear();
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
            if (fromCurrency == "EUR" && toCurrency == "NOK")
                return 11.325047;
            if (fromCurrency == "NOK" && toCurrency == "USD")
                return 0.095209812;
            if (fromCurrency == "USD" && toCurrency == "NOK")
                return 10.503119;
            if (fromCurrency == "EUR" && toCurrency == "USD")
                return 1.0782499;
            if (fromCurrency == "USD" && toCurrency == "EUR")
                return 0.92742876;

            return 1.0;
        }

        private void ConvertTemperature()
        {
            Console.Clear();
            Console.WriteLine("Choose temperature to convert from:\n1. Celsius\n2. Fahrenheit\n3. Kelvin");
            int fromTemperatureChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose temperature to convert to:\n1. Celsius\n2. Fahrenheit\n3. Kelvin");
            int toTemperatureChoice = Convert.ToInt32(Console.ReadLine());

            double initialTemperatureAmount;
            string fromTemperatureName;
            string toTemperatureName;

            Console.Write("Enter amount to convert: ");
            initialTemperatureAmount = Convert.ToDouble(Console.ReadLine());

            switch (fromTemperatureChoice)
            {
                case 1:
                    fromTemperatureName = "Celsius";
                    break;
                case 2:
                    fromTemperatureName = "Fahrenheit";
                    break;
                case 3:
                    fromTemperatureName = "Kelvin";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            switch (toTemperatureChoice)
            {
                case 1:
                    toTemperatureName = "Celsius";
                    break;
                case 2:
                    toTemperatureName = "Fahrenheit";
                    break;
                case 3:
                    toTemperatureName = "Kelvin";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.Clear();
            double convertedAmount = ConvertTemperature(initialTemperatureAmount, fromTemperatureName, toTemperatureName);
            Console.WriteLine($"{initialTemperatureAmount} {fromTemperatureName} is {convertedAmount} {toTemperatureName}.");
        }

        private double ConvertTemperature(double initTempAmount, string fromTempName, string toTempName)
        {
            double CtoF = initTempAmount * 1.8 + 32;
            double CtoK = initTempAmount + 273.15;

            double FtoC = initTempAmount - 32 / 1.8;
            double FtoK = initTempAmount + 459.67 * 5 / 9;

            double KtoC = initTempAmount - 273.15;
            double KtoF = initTempAmount * 9 / 5 - 459.67;

            if (fromTempName == "Celsius" && toTempName == "Fahrenheit")
            {
                return CtoF;
            }
            if (fromTempName == "Celsius" && toTempName == "Kelvin")
            {
                return CtoK;
            }
            if (fromTempName == "Kelvin" && toTempName == "Celsius")
            {
                return KtoC;
            }
            if (fromTempName == "Kelvin" && toTempName == "Fahrenheit")
            {
                return KtoF;
            }
            if (fromTempName == "Fahrenheit" && toTempName == "Celsius")
            {
                return FtoC;
            }
            return FtoK;
        }

        private void ConvertWeight()
        {

        }
    }
}
