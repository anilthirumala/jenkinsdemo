using System;

namespace ConverterLibrary
{
    public class Converter
    {
        public double MeterToCM(double meter)
        {
            return meter * 100;
        }
        public double MeterToKm(double meter)
        {
            return meter  / 1000;
        }
       
    }
}
