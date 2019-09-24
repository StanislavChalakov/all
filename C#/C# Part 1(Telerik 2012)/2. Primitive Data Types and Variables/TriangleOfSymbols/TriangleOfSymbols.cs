using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TriangleOfSymbols
    {
        static void Main()
        {
            char c = (char)169;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(@"       
   {0}
  {0} {0}
 {0}   {0}
{0} {0} {0} {0}", c); 
        }
    }

