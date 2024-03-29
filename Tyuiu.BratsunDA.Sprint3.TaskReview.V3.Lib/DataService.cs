﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BratsunDA.Sprint3.TaskReview.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((3*x-1.5) /(Math.Sin(x)-3+x)+2), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
