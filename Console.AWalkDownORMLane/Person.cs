using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.AWalkDownORMLane
{
    public class Person
    {
        string Name { get; set; }
        public Person()
        {
            Name = "";
        }

        public Person(string name)
        {
            Name = name;
        }
    }
}
