
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Pond
    {
        public List<Duck> ducks { get; set; }
        public List<Frog> frogs { get; set; }

        public override string ToString()
        {
            return "frog " + frogs.ToString();
        }
    }
}