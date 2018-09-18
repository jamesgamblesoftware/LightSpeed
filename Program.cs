using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSpeed
{
    class LightSpeed
    {
        private const int metre = 1;
        private const float centimetre = 0.01F;             //to get 1 cm, multiply 1m by 0.01
        private const float millimetre = 0.001F;
        private const float micrometre = 0.000001F;
        private const double nanometre = 0.000000001F;

        private const int kilometre = 1000;                 //to get 1km, multiply 1m by 1000
        private const long astronomicalUnit = 149597870700;
        private const long lightyear = 9460730472580800;
        private const double mile = 1609.34;                //to get 1 mile, multiply 1m by 1609.34
        private const double yard = 0.9144;
        private const double inch = 0.0254;

        private const int day = 1;
        private const float hour = 0.0416667F;
        private const double minute = 0.000694444;
        private const double second = 0.00001157407407;
        private const double millisecond = 0.00000001157407407;

        private const int week = 7;
        private const float year = 365.25F;
        private const int century = 36525;
        private const int millenium = 365250;




        public void Calculate(double speedDistanceMultiplier, string speedDistanceUnit, string speedTimeUnit, 
            double totalDistanceMultiplier, string totalDistanceUnits, double totalTimeMultiplier, string totalTimeUnits)
        {
            //for instance: 10.0 "Miles" / "Hour" for 100.0 "Miles" would take 10.0 "Hours"
        }

        static void Main(string[] args)
        {
        }
    }
}
