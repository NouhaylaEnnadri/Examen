using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class reponse_string : Reponse
    {
       
        public string response_ouverte { get; set; }
        Question question; 
        public  reponse_string(string reponse_ouverte)
        {
            this.response_ouverte = reponse_ouverte;

        }

    }
}
