﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A087_LifeTimeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생년월일 시분초를 입력하세요 : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Now;

            TimeSpan interval = date2 - date1;
            Console.WriteLine("탄생 시간 : {0}", date1);
            Console.WriteLine("현재 시간 : {0}", date2);
            Console.WriteLine("생존 시간 : {0}", interval.ToString());
            Console.WriteLine("당신은 지금 이순간 까지 {0}일 {1}시간 " + " {2}분 {3}초 살았습니다. ", interval.Days, interval.Hours, interval.Minutes, interval.Seconds);

        }
    }
}
