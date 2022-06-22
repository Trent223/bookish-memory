using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4Practice
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string _middleName { get; set; }

        public Person()
        {
            DoWork(param2: 40);
        }

        public Person(string name = "initialName", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public int DoWork(int param1 = 1, int param2 = 2)
        {
            return param2;
        }


        public bool DoSomething()
        {
            Console.WriteLine("Hello");
            DoSomethingSecret();
            return true;
        }

        private void DoSomethingSecret()
        {
            Console.Write("Secret!");
        }
    }
}
