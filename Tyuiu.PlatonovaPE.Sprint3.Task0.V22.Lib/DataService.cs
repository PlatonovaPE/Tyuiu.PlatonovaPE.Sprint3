﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlatonovaPE.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries *= (Math.Pow(value, i) + 4) * Math.Cos(value);
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
