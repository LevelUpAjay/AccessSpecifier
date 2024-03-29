using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    public class Program
    {
        public void MethodPublic()
        {
            Console.WriteLine("Public Method Called.");
        }

        void MethodPrivate()
        {
            Console.WriteLine("Private Method Called.");
        }

        protected void MethodProtected()
        {
            Console.WriteLine("Protected Method Called.");
        }

        internal void MethodInternal()
        {
            Console.WriteLine("Internal Method Called.");
        }

        protected internal void MethodProtectedInternal()
        {
            Console.WriteLine("Protected Internal Method Called.");
        }

        public static void Main(string[] args)
        {
            Program objProg = new Program();
            objProg.MethodPublic();
            objProg.MethodPrivate();
            objProg.MethodProtected();
            objProg.MethodInternal();
            objProg.MethodProtectedInternal();
            Console.ReadLine();
        }
    }
}
