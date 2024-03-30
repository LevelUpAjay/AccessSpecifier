using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Four
    {
        static void Main()
        {
            AccessDemo1.Program objProg = new AccessDemo1.Program();
            objProg.MethodPublic();
            Console.ReadLine();
        }
    }
}
