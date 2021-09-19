/*
 * @Description: 重载操作符(c#)
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 10:42:21
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-17 11:34:35
 */

using System;
using System.Collections.Generic;

namespace halconwork1
{
    class Program
    {
        public struct Vecotr2
        {
            public double x1;
            public double x2;
            public Vecotr2(double x1, double x2)
            {
                this.x1 = x1;
                this.x2 = x2;
            }
            /**
             * @description: 
             * @param {a,b}
             * @return {the * between the param a and b}
             * @author: gcusms
             */               
            public static Vecotr2 operator *(Vecotr2 a, float b) => new Vecotr2(a.x1 * b, a.x2 * b);
        }
        static void Main(string[] args)
        {
            Vecotr2 v1 = new Vecotr2(10, 20);
            v1 *= 3;
            Console.WriteLine($"v1.x ={v1.x1}");
            Console.WriteLine("123");
        }
    }
}
