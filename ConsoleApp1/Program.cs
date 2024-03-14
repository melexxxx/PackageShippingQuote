using System;
using System.Threading;

namespace PackageShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is your package weight?");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            double maxWeight = 50;

            string weightLimit = packageWeight > maxWeight ? "Your Package exceeds the weight limit of Package Express. Thank you, have a great day." : $"Package weight :{packageWeight}";

            if (packageWeight > maxWeight)
            {
                Console.WriteLine("Your Package exceeds the weight limit of Package Express. Thank you, have a great day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package height: ");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Package width: ");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Package length: ");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                double maxDimensions = 50;

                double customerPackageDimensions = packageHeight + packageLength + packageWidth;

                string dimensionsLimit = customerPackageDimensions > maxDimensions ? "Your package exceeds the dimensions limit of Package Express" : $" Package dimensions: {customerPackageDimensions}";

                    if (customerPackageDimensions > maxDimensions)
                    {
                        Console.WriteLine("Your package exceeds the dimensions limit of Package Express");
                        Console.ReadLine();
                    } else if (customerPackageDimensions <= maxDimensions)
                    {
                        Console.WriteLine($"Package Dimensions: {customerPackageDimensions}");
                    }else
                    {
                    Console.WriteLine("oops... somehting went wrong!");
                    Console.ReadLine();
                    }


                if (customerPackageDimensions > maxDimensions)
                {
                    Console.WriteLine("Your package exceeds the dimensions limit of Package Express. Thank you, have a great day.");
                }
                else
                {
                    Console.WriteLine("Thank you, calculating cost.");

                    double shippingCost = ((packageHeight * packageWidth * packageLength) * packageWeight) / 100;

                    Thread.Sleep(2000);

                    Console.WriteLine($"Your estimated posting cost is {shippingCost}");

                    Console.ReadLine();
                }
            }
        }
    }
}
