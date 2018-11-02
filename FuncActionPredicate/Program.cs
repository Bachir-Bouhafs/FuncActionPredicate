using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths.delegateReturnSum delegateReturn = Maths.Somme;
            double resultat = delegateReturn.Invoke(366, 4.5f, 12.85);
            Console.WriteLine(resultat);

            Maths.delegateWriteSum delegateWrite = Maths.EcrireSomme;
            delegateWrite.Invoke(366, 4.5f, 12.85);
       

            Maths.delegateCheck delegateCheck = Maths.VerifierTaille;
            bool check = delegateCheck.Invoke("Bachir");
            Console.WriteLine(check);

           

            //Tout le code qu'on a écrit précédemment, on peut le simplifier grâce aux delegates generic 
            // Func, Action et Predicate

            Func<int, float, double, double> objFunc = (x, y, z) =>
            {
                return x + y + z;
            };

            Action<int, float, double> objAction = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };

            Predicate<string> objPredicate = (str) =>
            {
                if (str.Length > 4)
                    return true;
                return false;
            };

            Console.WriteLine(objFunc.Invoke(366, 4.5f, 12.85));
            objAction.Invoke(366, 4.5f, 12.85);
            Console.WriteLine(objPredicate("Bachir"));

            Console.ReadLine();

        }
    }
}
