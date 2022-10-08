using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0810
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human()
        {
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Fly()
        {
            throw new NotImplementedException("Human cannot fly yet!");
        }
    }
}
