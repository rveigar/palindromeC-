using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome3("subinoonibus"));
        }
    
        public static bool Palindrome1(string texto)

        {            
            int min = 0;
            int max = texto.Length -1 ;
            while (max > min)
            {
               if (texto[min] != texto[max])
                    {
                        return false;
                    }
                    min++;
                    max--;
            }
            return true;
        }

    
    
         public static bool Palindrome2(string texto)
        { 
            for (int i = 0; i < texto.Length/2; i++)    
            {
                if (texto[i] != texto[texto.Length -1-i])
                {
                    return false;
                }
                i++;
            }
            texto.Reverse().ToArray();
            return true;
        }


    public static bool Palindrome3(string texto)

    {
       // using System.Linq;
        string textoInvertido = new string(texto.Reverse().ToArray());
        if (texto == textoInvertido)
        {
            Console.WriteLine("texto= " +texto + " textoInvertido= " + textoInvertido);
            return true;
        } else {return false;}
    }

    }


}
