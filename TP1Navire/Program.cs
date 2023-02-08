using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            TesterInstanciation();
            Console.ReadKey
        }
        public static void TesterInstanciation()
        {
            //déclaration de l'objet unNavire de la classe Navire
            Navire unNavire;
            //instanciation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
            //Déclaration et instanciation d'un autre objet navire
            Navire unAutreNavire = new Navire("IMO839272", "MSC Isabella", "Porte-conteneurs", 197500);
            // ??
            //unAutreNavire = new Navire("IMO8715871", "MSC PILAR");
        }
    }
}
