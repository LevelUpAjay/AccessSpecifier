using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    class One : Program
    {
        static void Main()
        {
            //Program objProg = new Program();
            One objProg = new One();
            objProg.MethodPublic();
            objProg.MethodProtected();
            objProg.MethodInternal();
            objProg.MethodProtectedInternal();
            Console.ReadLine();
        }
    }
}
