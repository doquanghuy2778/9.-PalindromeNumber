using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dem = 0;
            int index = 0;
            int dem2 = 0;
            Console.Write("x = ");
            string x = Console.ReadLine();  
            char[] Arr = x.ToCharArray();
            char[] Arr2 = new char[Arr.Length];

            for(int i = Arr.Length - 1; i >= 0; i--) 
            {
                Arr2[index] = Arr[i];
                index++;
            }

            for(int i = 0; i < Arr.Length; i++) 
            {
                if(Arr2[i] == Arr[i])
                {
                    dem2++;
                }
            }

            if(dem2 == Arr.Length)
            {
                Console.Write("true");
            }
            else
            {
                Console.Write("false");
            }
            Console.ReadKey();
        }
    }
}
