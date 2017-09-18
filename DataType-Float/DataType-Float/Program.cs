using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Float
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MinValue;

            decimal dcMin = decimal.MinValue;
            decimal dcMax = decimal.MaxValue;

            Console.WriteLine("float Min. Value = {0}    float Max. Value = {1}\n decimal Min. Value = {2}\n decimal Max. Value = {3}", flMin, flMax, dcMin,dcMax);
            Console.ReadKey();
        }
    }
}
