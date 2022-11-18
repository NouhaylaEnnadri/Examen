using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Dichotomique :Question
    {
        private List<vrai_faux> reponse_string = new List<vrai_faux>();
    public Dichotomique(string Ques, int Id) : base(Ques, Id)
    {
        this.Ques = Ques;
        this.Id = Id;
    }


}
}
