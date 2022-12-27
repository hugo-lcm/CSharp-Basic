using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27ClasseObject
{
    internal class Test
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Test(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // agora ele vai comparar os valores dos objetos, mesmo que não sejam os mesmos objetos
        public override bool Equals(object? obj)
        {
            Test test = (Test)obj;
            return test.FirstName == this.FirstName && test.LastName == this.LastName;
        }

        public override string ToString()
        {
            return string.Format($"nome: {FirstName}\nsobrenome: {LastName}");
        }
    }
}
