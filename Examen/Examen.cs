using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Examen
    {
        int score;
        private int idExamen;
        private DateTime date = new DateTime();  
        private int limiteTemps;
        private bool estV;
        private bool pasV;
        
        public Examen(int score, int idExamen, DateTime date, int limiteTemps, bool estV, bool pasV)
        {
            this.score = score;
            this.idExamen = idExamen;
            this.date = date;
            this.limiteTemps = limiteTemps;
            this.estV = estV;
            this.pasV = pasV;

        }
    }
}
