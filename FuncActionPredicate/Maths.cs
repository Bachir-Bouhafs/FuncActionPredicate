using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    public class Maths
    {
        public delegate double delegateReturnSum(int x, float y, double z);
        public delegate void delegateWriteSum(int x, float y, double z);
        public delegate bool delegateCheck(string str);

        public static double Somme(int x,float y , double z)
        {
            return x + y + z;
        }

        public static void EcrireSomme(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool VerifierTaille(string str)
        {
            if (str.Length > 4)
                return true;
            return false;
        }

    }
}
