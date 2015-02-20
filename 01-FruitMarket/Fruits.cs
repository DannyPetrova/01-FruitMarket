using System;

class Fruits
{
    static decimal calculatingPrices(string productName, string dayOfWeek)
    {
        decimal price = 0m;
        bool isFruit = false;
        switch (productName)
        {
            case "bannana": price = 1.80m; isFruit = true; break;
            case "orange": price = 1.60m; isFruit = true; break;
            case "apple": price = 0.86m; isFruit = true; break;
            case "tomato": price = 3.20m; break;
            case "cucumber": price = 2.75m; break;
        }
        switch (dayOfWeek)
        {
            case "Friday": price = price * 0.90m; break;
            case "Sunday": price = price * 0.95m; break;
            case "Tuesday":
                if (isFruit == true)
                    price = price * 0.80m;
                break;
            case "Wednesday":

                if (isFruit == false)
                    price = price * 0.90m;
                break;
            case "Thursday":

                if (productName == "bannana")
                    price = price * 0.70m;
                break;

        }
        return price;
    }
    static void Main()
    {
        decimal totalSum = 0m;
        string dayOfWeek = Console.ReadLine();

        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();

        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();

        decimal quantity3 = decimal.Parse(Console.ReadLine()); ;
        string product3 = Console.ReadLine();

        totalSum = quantity1 * calculatingPrices(product1, dayOfWeek) +
                   quantity2 * calculatingPrices(product2, dayOfWeek) +
                   quantity3 * calculatingPrices(product3, dayOfWeek);
        Console.WriteLine(totalSum);

    }
}
