using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancialForecast forecast =
                new FinancialForecast();

            double futureValue =
                forecast.PredictFutureValue(
                    1000,
                    0.10,
                    5
                );

            Console.WriteLine(
                "Predicted Future Value: " +
                futureValue
            );
        }
    }
}