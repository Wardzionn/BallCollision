using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class DataApi
    {
        public static DataApi CreateDataApi()
        {
            return new BallData();
        }

        private class BallData : DataApi
        {
            public BallData()
            {

            }
        }
    }
}
