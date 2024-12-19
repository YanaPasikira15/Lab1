using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertFromUAH(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount / usdRate;
            case "eur":
                return amount / eurRate;
            case "pln":
                return amount / plnRate;
            default:
                throw new ArgumentException("Unknown currency");
        }
    }
    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount * usdRate;
            case "eur":
                return amount * eurRate;
            case "pln":
                return amount * plnRate;
            default:
                throw new ArgumentException("Unknown currency");
        }
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(usd: 41.2, eur: 45.0, pln: 10.5);
        Console.WriteLine("Виберіть тип операції:");
        Console.WriteLine("1. Конвертація з гривні в іноземну валюту");
        Console.WriteLine("2. Конвертація з іноземної валюти в гривні");
        int operation = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть валюту (usd, eur, pln):");
        string currency = Console.ReadLine();
        Console.WriteLine("Введіть кількість валюти:");
        double amount = double.Parse(Console.ReadLine());
        if (operation == 1)
        {
            double result = converter.ConvertFromUAH(amount, currency);
            Console.WriteLine($"{amount} UAH = {result} {currency.ToUpper()}");
        }
        else if (operation == 2)
        {
            double result = converter.ConvertToUAH(amount, currency);
            Console.WriteLine($"{amount} {currency.ToUpper()} = {result} UAH");
        }
        else
        {
            Console.WriteLine("Неправильний вибір операції.");
        }
    }
}
