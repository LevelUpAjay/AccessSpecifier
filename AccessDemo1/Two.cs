using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    class Two
    {
        static void Main()
        {
            Program objProg = new Program();
            objProg.MethodPublic();
            objProg.MethodInternal();
            objProg.MethodProtectedInternal();
            Console.ReadLine();
        }
    }
}
