using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Delegates
{
    class Program
    {
        delegate int AddNos(int no1, int no2);
        static void Main(string[] args)
        {
            //Generic Delegate
            Predifined_GenericDelegates objGD = new Predifined_GenericDelegates();
            //Using Func
            Func<int, int, int> funcDelegate = new Func<int, int, int>(objGD.Add);
            funcDelegate.Invoke(30, 79);
            //Also can be used with Anonymous method
            Func<int, int, int> funcDel = new Func<int, int, int>(delegate (int no1, int no2)
            {
                return no1 + no2;
            });
            int result = funcDel.Invoke(10, 20);
            //Also can be used with Lambada Expression
            Func<int, int, int> funcDelLambadaExp = new Func<int, int, int>( ( no1, no2) =>
            {
                return no1 + no2;
            });
            funcDelLambadaExp.Invoke(10, 20);
           
            Console.WriteLine(result);

            //Using Action Delegate
            Action<string> objAct = new Action<string>(objGD.SayHello);
            objAct.Invoke("Ruchir");

            //Using Predicate Delegate
            Predicate<string> objPre = new Predicate<string>(objGD.Compare);
            Console.WriteLine(objPre.Invoke("9899765456"));

            /*Anonymous Method =>2.0
                Here instead of passing a function to a delegate we can 
                pass a code block to a delegate 
            */
            AddNos objAdd = delegate (int no1, int no2)
            {
                return no1 + no2;
            };

            /*Lambada Expression =>3.0 
             Before Lambada Expression Anyonymous methods were introduced 
             but after Lambada Expression ,its been considered as a preferred
             way to write inline coding
             So basically it improves the way compared to Anoynomous method
             to wirte inline code by removing  parameter types as well
             as the return type of method because they are already defined in the 
             int the delegate defination also the delegate keyword was removed
             */

            AddNos objAddLambadaExp = (no1, no2) => {
                return no1 + no2;
            };




        }
    }
}
