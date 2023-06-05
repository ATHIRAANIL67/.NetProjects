
using System;
using System.Globalization;

class CurrencyFormatter
{
    static void Main(string[] args)
    {
        double amount = 12324.134;

        // US currency format
        NumberFormatInfo usFormat = new CultureInfo("en-US").NumberFormat;
        string usCurrency = amount.ToString("C", usFormat);

        // Indian currency format
        NumberFormatInfo indiaFormat = new CultureInfo("en-IN").NumberFormat;
        string indiaCurrency = amount.ToString("C", indiaFormat);

        // Chinese currency format
        NumberFormatInfo chinaFormat = new CultureInfo("zh-CN").NumberFormat;
        string chinaCurrency = amount.ToString("C", chinaFormat);

        // French currency format
        NumberFormatInfo franceFormat = new CultureInfo("fr-FR").NumberFormat;
        string franceCurrency = amount.ToString("C", franceFormat);

        // Print the formatted values
        Console.WriteLine("US: " + usCurrency);
        Console.WriteLine("India: " + indiaCurrency);
        Console.WriteLine("China: " + chinaCurrency);
        Console.WriteLine("France: " + franceCurrency);
    }
}