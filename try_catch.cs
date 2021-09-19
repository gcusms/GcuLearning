/*
 * @Description: 错误捕捉测试
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 10:42:38
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-17 11:26:29
 */

using System;
using System.Collections.Generic;

namespace halconwork1
{
    class Program
    {
        class TesEx
        {
            public void TestException() {
                try
                {
                    object obj = null;
                    obj.ToString();
                }
                catch (NullReferenceException e)  //  捕捉异常
                {
                    Console.WriteLine(e.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            TesEx t_ = new TesEx();
            t_.TestException();
            Console.WriteLine("123");
        }
    }
}
