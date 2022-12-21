using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //int
                int[] arr = new int[4] { 1, 2, 3, 4 };

                foreach(var i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }

        }


    }
}
