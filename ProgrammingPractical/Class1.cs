using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractical
{
    public struct Person
    {
        public string name;
        public String gender;

        public static void Main(string[] args)
        {
            Person p;
            p.name = "Access";
            p.gender="Female";
            Console.WriteLine("Name of organaisation" + " " +p.name);

        }
     
    }
}
