using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            int[] array = new int[10];
            Console.WriteLine("Enter the 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("enter the value:" + i + "Index");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < 10; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("The Even Numbers are:" + array[i]);
                   
                }
            }
            Console.ReadLine();
        }
            
    }
 }

