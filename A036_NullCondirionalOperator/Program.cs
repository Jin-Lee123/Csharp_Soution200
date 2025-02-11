﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A036_NullCondirionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.Write("4글자 이상인 동물의 이름만 출력합니다.");
            do
            {
                LongNameAnimal(animal);
                Console.WriteLine("동물 이름: ");
            } while ((animal = Console.ReadLine()) != null);
        }
        private static void LongNameAnimal(string animal)
        {
            if(animal?.Length >= 4)
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}
