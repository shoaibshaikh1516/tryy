using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ref3
{
    class MyClass
    {
        public MyClass(int x, int y)
        {
        }
        public int sum(int i)
        {
            return 0;
        }
        public bool IsValid(int i)
        {
            return false;
        }
        public void SetData(double a, double b)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            Console.WriteLine("Analysing methods of my class");
           Console.WriteLine();
            Console.WriteLine("methods supported");  //Analysing methods of my classParameterInfo
            MethodInfo[] md=t.GetMethods();
            foreach (var m in md)
	{
		 Console.Write(""+m.ReturnType.Name+""+m.Name+"(");
                ParameterInfo[] pi=m.GetParameters();
                for(int i=0;i<pi.Length;i++)
                {
                    Console.Write(pi[i].ParameterType.Name+""+pi[i].Name);
                    if (i + 1 < pi.Length)
                    {
                      Console.Write(",");
                    }
                }

                Console.WriteLine(")");
                Console.WriteLine();
	}
            Console.ReadLine();

        }
    }
}
