using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1Navire
{
    class Port
    {
        private string nom;
        private int nbNaviresMax;
        private List<Navire> navires;

        public Port(string nom)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
            this.navires = new List<Navire>();

        }

        public string Nom { get => nom; set => nom = value; }
        public int NbNaviresMax { get => nbNaviresMax; set => nbNaviresMax = value; }
        internal List<Navire> Navires { get => navires; set => navires = value; }

        /// <summary>
        /// Enregistre l'arrivée du navire en paramètre
        /// </summary>
        /// <param name="navire"></param>
        public void EnregistrerArrivee(Navire navire)
        {
            if (Navires.Count() <= nbNaviresMax)
            {
                Navires.Add(navire);
            }
            else{
                Console.WriteLine("Ajout Impossible le port est complet");
            }
        }
        /// <summary>
        /// Enregistre le départ du navire en paramètre
        /// Seulement si il est présent dans le port
        /// </summary>
        /// <param name="imo"></param>
        public void EnregistrerDepart(String imo)
        {
            if (EstPresent(imo))
            {
                Navires.RemoveAt(navires.FindIndex(x => x.Imo == imo));
            }
            else
            {
                Console.WriteLine("Impossible : Le navire n'est pas dans le port");
            }
        }
        /// <summary>
        /// Verifie si le navire est présent dans le port
        /// </summary>
        /// <param name="imo"></param>
        /// <returns></returns>
        public bool EstPresent(String imo)
        {
            return Navires.Exists(x => x.Imo == imo);
        }
    }
}
