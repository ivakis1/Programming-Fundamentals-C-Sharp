using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int stockPricesCount = int.Parse(Console.ReadLine());

        double notificationLimit = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < stockPricesCount - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double div = Proc(last, currentPrice);
            bool isSignificantDifference = ImaliDif(div, notificationLimit);
            string message = Get(currentPrice, last, div, isSignificantDifference);

            Console.WriteLine(message);

            last = currentPrice;
        }
    }

    public static string Get(double currentPrice, double last, double razlika, bool etherTrueOrFalse)
    {
        string to = string.Empty;
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currentPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currentPrice, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
        { 
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currentPrice, razlika);
        }

        return to;
    }

    public static bool ImaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }

        return false;
    }

    public static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
