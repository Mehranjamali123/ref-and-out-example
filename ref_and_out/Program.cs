using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //use of ref 
            int a =10;

            implement(ref a);

            Console.WriteLine( a);

            //use of out

            string name;
            outmethod(out name);
            Console.WriteLine(name);



        }

        static void implement(ref int a)
        {
            a = 30;
        }

        static void outmethod(out string name)
        {
            name = "mehran";
            string res = name + "jamali";
        }
    }
}
