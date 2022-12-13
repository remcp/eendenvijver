
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Ooievaar
    {
        List<Frog> eaten = new List<Frog>();

        public Gender gender { get; set; }
        public Ooievaar(Gender choice)
        {
            eaten = new List<Frog>();
            gender = choice;
        }

        public List<Frog> eatfrog(Frog frog)
        {
            List<Frog> tummy = new List<Frog>();
            tummy.Add(frog);
            return tummy;
        } 
    }
}
