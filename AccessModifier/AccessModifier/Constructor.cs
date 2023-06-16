using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Default Constructor");            
        }
        public Constructor(string name)
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
