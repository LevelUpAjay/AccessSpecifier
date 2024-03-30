using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Three : AccessDemo1.Program
    {
        static void Main(string[] args)
        {
            Three objProg = new Three();
            objProg.MethodPublic();
            objProg.MethodProtected();
            objProg.MethodProtectedInternal();
            Console.ReadLine();
        }
    }
}
