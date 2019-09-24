using System;

class ASCIITables
{
    static void Main()
    {
         int nSymbol=0;
          //  Console.OutputEncoding = Encoding.Unicode; 
         for (int i = 0; i <= 255; i++)
         {
             Console.WriteLine("The code is ->{0}, the symbol is->{1}", i, Convert.ToChar(nSymbol));
             nSymbol++;
         }
    }
}

