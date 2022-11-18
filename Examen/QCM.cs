using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class QCM : Question
    {
        private List<Proposition> propositions = new List<Proposition> ();
        public QCM(string Ques, int Id) : base(Ques, Id)
        {
            this.Ques = Ques;
            this.Id = Id;
        }
       

    }
}
