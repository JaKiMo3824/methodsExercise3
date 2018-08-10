using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise3
{
    class Methods
    {
        public static int Method1(int num1)
        {
            int res1 = num1 / 2;
            return res1;
        }

        public static decimal Method2(decimal num2)
        {
            decimal res2 = num2 * 0.5m;
            return res2;
        }

        public static string Method3(string num3)
        {
            int number3 = Convert.ToInt32(num3);
            int res3 = number3 + 10;
            string reso3 = res3.ToString();
            return reso3;

        }
    }
}
