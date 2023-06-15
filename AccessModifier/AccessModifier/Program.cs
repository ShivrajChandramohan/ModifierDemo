using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Program : ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
            publicAccessModifier.AccessModifier();
            Console.ReadLine();

            PrivateAccessModifier demo = new PrivateAccessModifier();
            demo.Intro();
            Console.ReadLine();

            ProtectedAccessModifier protectedAccessModifier = new ProtectedAccessModifier();
            Program program = new Program();
            program.IntroOfProtectedModifier();
            Console.ReadLine();

            InternalAccessModifier internalAccessModifier = new InternalAccessModifier();
            internalAccessModifier.IntroOfInternalmodifier();
            Console.ReadLine();
        }
    }
}
