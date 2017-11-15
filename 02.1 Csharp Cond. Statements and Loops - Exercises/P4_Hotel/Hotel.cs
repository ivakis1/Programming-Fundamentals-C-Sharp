namespace P4_Hotel
{
    using System;

    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nightsCount > 7)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                }
                
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    doublePrice = doublePrice - (doublePrice * 0.1);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    suitePrice = suitePrice - (suitePrice * 0.15);
                }
            }

            var totalPriceStudio = nightsCount * studioPrice;
            var totalPriceDouble = nightsCount * doublePrice;
            var totalPriceSuite = nightsCount * suitePrice;

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                totalPriceStudio = totalPriceStudio - studioPrice;
            }

            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.\nDouble: {totalPriceDouble:F2} lv.\nSuite: {totalPriceSuite:F2} lv.");


        }
    }
}
