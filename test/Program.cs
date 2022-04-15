using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (bool pet, int[] ar) kt;
            kt = vv();
            Print(kt.pet,kt.ar);
        }
           static (bool,int[]) vv()
        {
            (bool pet, int[] ar) kt;
            kt.pet = true;

            kt.ar = new int[2];
            kt.ar[0] = 1;
            kt.ar[1] = 1;
            
            return kt;
        }
        
        static void Print(bool pet,int[]ar)
        {
            if (pet != false)
            {
                foreach (int i in ar)
                    Console.WriteLine(i);
            }
           
        }
       

    } 
}
