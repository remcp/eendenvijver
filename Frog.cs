
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eendenvijver
{
    internal class Frog
    {
        public Gender gender { get; set; }
        public Frog (Gender choice)
        {
            gender = choice;
        }

        public override string ToString()
        {
            return "kikker " + gender.ToString();
        }
    }
}