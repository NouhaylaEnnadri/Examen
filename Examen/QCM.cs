using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class QCM : Question
    {
        private List<R_Proposition> propositions = new List<R_Proposition> ();
        public QCM(string Ques, int Id, float Note) : base(Ques, Id, Note) { }
        public void AddPropo(string propo)
        {
            propositions.Add(new R_Proposition(propo));
        }



    }
}
