using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib1
{
    /// <summary>
    /// Calculation mathematical functions
    /// </summary>
    public class MyLib
    {
        /// <summary>
        /// sr_arifm - function finding average of 2 nembers
        /// </summary>
        /// <param name="a"> first number </param>
        /// <param name="b"> second number </param>
        /// <returns> returns average of 2 nambers </returns>
        public static double Average(double a, double b)  
        {
            double res;
            res = (a + b) / 2;
            return res;
        }
        /// <summary>
        /// Sum - function finding sum of the row given
        /// </summary>
        /// <param name="x"> real number - argument </param>
        /// <param name="n"> natural number row</param>
        /// <returns></returns>
        public static double Summ(double x, int n)
        {
            double factorial = 0;
            double res = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 2 * n - 1; j++) { factorial *= j; } 
                res += Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n - 1) / factorial) + res;
            }
            return res;
        }
            
    }
}
