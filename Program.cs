using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblVal1, dblVal2, dblRep=0;
            bool isOpIncorrect = true;
            Console.WriteLine("Calculatrice");
            Console.WriteLine("-------------");
            //Saisie des operandes, avec verification de ces dernieres
            Console.WriteLine("Saisir la premier valeur:");
            while(double.TryParse(Console.ReadLine(), out dblVal1))
            {
                Console.Write("Saisir a nouveau la 1ere valeur :");
            }

            Console.WriteLine("Saisir la dexieme valeur:");
            while (double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisir a nouveau la 2eme valeur :");
            }
            //Saisie du choix de loperateur
            Console.Write("Operation a choix [+ - * / ^]");
            while (isOpIncorrect)
            {
                string strOp = Console.ReadLine();
                isOpIncorrect = false;
                switch (strOp)
                {
                    default:
                        Console.WriteLine("Operation non reconu par le systeme");
                        Console.WriteLine("Veuillez saisir unnnouveau operateur [+ - * / ^]");
                        isOpIncorrect = true;
                        break;
                    case "+":
                        dblRep = Outils.Addition(dblVal1,dblVal2);
                        Console.Write("La reponse:" + dblRep.ToString());
                        break;
                    case "-":
                        dblRep = 0;
                        break;
                    case "*":
                        dblRep = 0;
                        break;
                    case "/":
                        dblRep = 0;
                        break;
                    case "^":
                        dblRep = 0;
                        break;
                }
            }
            Console.Write(dblVal1.ToString());

            Console.ReadKey();
        }
    }
}
