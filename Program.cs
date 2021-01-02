using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testC2
{
    class Program
    {
       static void recursWrite(int [] array, int count = 0)
        {
            if (array.Length > count)
            {
                Console.WriteLine(array[count]);
                
                recursWrite(array, ++count);
            }
          
        }

       
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 19 };
            recursWrite(arr);
            
        }
    }
}
