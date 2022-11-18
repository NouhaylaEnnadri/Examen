using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal abstract class  Question
    {
       
        protected string Ques { get; set; } 
        protected int Id { get; set; }
        protected float Note { get; set; }
       
        public Question (string Ques , int Id , float Note)
        {
            this.Ques = Ques;
            this.Id = Id;   
            this.Note = Note;   
          
        }


    }
}
