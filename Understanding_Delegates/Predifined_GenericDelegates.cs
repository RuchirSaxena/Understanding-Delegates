using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Delegates
{
    class Predifined_GenericDelegates
    {
        public int Add(int no1,int no2)
        {
            return no1 + no2;
        }
        public void SayHello(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        public bool Compare(string MobileNo)
        {
            if (MobileNo.Length == 10)
            {
                return true;
            }
            return false;
        }
    }
}
