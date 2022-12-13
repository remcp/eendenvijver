using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Duck
    {

        public Gender gender { get; set; }
        public Duck(Gender choice)
        {
            gender = choice;
        }

        public override string ToString()
        {
            return "duck " + gender.ToString();
        }
    }
}