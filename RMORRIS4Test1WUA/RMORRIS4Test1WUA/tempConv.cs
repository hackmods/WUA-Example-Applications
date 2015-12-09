using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMORRIS4Test1WUA
{
    public class tempConv
    {
        //kalvin value
        public static double kal = 273;

        public static double FtoC(double val)
        {
            double result = 0;

            result = ((val - 32) * 5 / 9);

            result = Math.Round(result, 2);
            return result;
        }

        public static double FtoK(double val)
        {
            double result = val;
            result = FtoC(result);
            result = CtoK(result);
            result = Math.Round(result, 2);
            return result;
        }

        public static double CtoF(double val)
        {
            double result = 0;

            result = ((val * 9) / 5 + 32);

            result = Math.Round(result, 2);
            return result;
        }

        public static double CtoK(double val)
        {
            double result = val;

            result += kal;

            result = Math.Round(result, 2);
            return result;
        }

        public static double KtoC(double val)
        {
            double result = val;

            result -= kal;

            result = Math.Round(result, 2);
            return result;
        }

        public static double KtoF(double val)
        {
            double result = val;
            result = KtoC(result);
            result = CtoF(result);
            result = Math.Round(result, 2);
            return result;
        }
    }
}
