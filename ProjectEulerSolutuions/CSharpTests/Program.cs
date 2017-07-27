using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests{

    
    static class ExtensionMethods
    {
        
        
    }

    //CustomExceptionA : LoadException
    //CustomExceptionB : CustomExceptionA
    //CustomExceptionC : LoadException

    class Program {
        
        static void Test(int a){
            Console.WriteLine($"Test was called: {a}");
        }

        static void Test2(int a)
        {
            Console.WriteLine($"Test2 was called: {a}");
        }

        static void Test3(int a)
        {
            throw new Exception();
            Console.WriteLine($"Test3 was called: {a}");
        }

        class DelegateHolder{
            public delegate void RunFunction(int a);
            RunFunction runFunction;// = new RunFunction();

            public void Add(RunFunction a){
                runFunction += a;
            }

            public void Invoke(int a){
                runFunction.Invoke(a);
            }
        }

        static void Main(string[] args){

            DelegateHolder delegateHolder = new DelegateHolder();

            



            try{
                delegateHolder.Invoke(4);
            }catch {

            }

            Console.WriteLine("End");
            Console.Read();
            


        }
    }
}
