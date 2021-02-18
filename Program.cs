using System;
using System.Collections.Generic;

namespace Partie4_Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            int mul = 1;
            List<int> nombre = new List<int>();
            string rep;
            bool test = false;




            while (test==false) {
                Console.WriteLine("Voulez vous entrer un nombre o/n");
                rep = Console.ReadLine();
                if (rep=="o") {
                    Console.WriteLine("Entrer un nombre");
                    nbr = Convert.ToInt32(Console.ReadLine());
                    nombre.Add(nbr);
                    test = false;
                }
                else
                {
                    test= true;
                }
               


            }


             for (int i = 0; i < nombre.Count; i++)
              {
                mul = nombre[i] * mul;
                Console.Write(nombre[i]);
                if (i < nombre.Count-1)
                {
                   

                    Console.Write("*");
                }
          

                 


              }


            Console.Write("="+ mul);


        }
    }
}
