using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class etudiant

    {
        public int CIN { get; set; }
        public string nom { get; set; }
        public string Prenom { get; set; }
        private List<Reponse> reponses = new List<Reponse>();

        public etudiant() { }
        public etudiant(int id, string nom, string Prenom, List<Reponse> reponses)
        {
            this.CIN = CIN;
            this.nom = nom;
            this.Prenom = Prenom;
            this.reponses = new List<Reponse>(reponses);
        }
    }
}
