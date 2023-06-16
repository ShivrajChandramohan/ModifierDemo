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
    public class Program : PrivateProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            //PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
            //publicAccessModifier.AccessModifier();


            //PrivateAccessModifier demo = new PrivateAccessModifier();
            //demo.Intro();


            ////ProtectedAccessModifier protectedAccessModifier = new ProtectedAccessModifier();
            ////Program program = new Program();
            ////program.IntroOfProtectedModifier();


            //InternalAccessModifier internalAccessModifier = new InternalAccessModifier();
            //internalAccessModifier.IntroOfInternalmodifier();


            //Constructor constructor = new Constructor();
            //Constructor constroctors = new Constructor("Shivraj");

            PrivateAccessModifier privateAccessModifier = new PrivateAccessModifier();
            Program program1 = new Program();
            Console.WriteLine(program1.name);


            ProtectedInternalAccessModifier protectedInternalAccessModifier = new ProtectedInternalAccessModifier();
            Console.WriteLine(protectedInternalAccessModifier.name);
            Console.ReadLine();
        }
    }
}
