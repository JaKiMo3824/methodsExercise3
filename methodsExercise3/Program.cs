using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = Methods.Method1(12);
            Console.WriteLine(result1);

            decimal result2 = Methods.Method2(50m);
            Console.WriteLine(result2);

            string result3 = Methods.Method3("12");
            Console.WriteLine(result3);

            Console.ReadLine();

        }
    }
}
