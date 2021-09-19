/*
 * @Description: 头文件编写函数
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-18 14:36:49
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-18 14:36:54
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace halconwork1
{
    class St1
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
    class PramrGo
    {
        public static int k_works = 15;
        static void Main(string[] args)
        {
            St1 st1 = new St1();
            
            st1.getValue(out k_works);
            Console.WriteLine($"k_works = {k_works}");
        }
    } 
}
