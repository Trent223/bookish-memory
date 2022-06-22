using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Practice
{
    internal class ChildPerson : Person
    {
        public ChildPerson()
        {

        }

        public void CanIDoSomething()
        {
            DoSomething();
        }
    }
}
