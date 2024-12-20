﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlatonovaPE.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            startValue = 1;
            value = 2;
            while (stopValue >= startValue)
            {
                multSeries *= (Math.Pow(value, startValue) - 0.25) * Math.Cos(5);
                startValue++;

            }

            return Math.Round(multSeries, 3);
        }
    }
}
