using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Q_ouverte : Question
    {
        private List<reponse_string> reponse_string = new List<reponse_string>();
        public Q_ouverte(string Ques, int Id) : base(Ques, Id)
        {
            this.Ques = Ques;
            this.Id = Id;
        }


    }
}
