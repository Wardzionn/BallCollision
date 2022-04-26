using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class Helper
    {
        public static double NextDoubleInRange(
            this Random random,
            double minValue,
            double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
