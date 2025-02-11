﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A090_params
{
    class Program
    {
        public static void PrintIntParams(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintObjectParams(params object[] arr)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintObjectParams();

            int[] myIntArry = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArry);

            object[] myObjArray = { 2, 2.345, 'b', "test", "again" };
            PrintObjectParams(myObjArray);

            PrintObjectParams(myIntArry);
         }

    }
}
