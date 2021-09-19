/*
 * @Description: 命名空间
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 15:31:10
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-17 15:33:54
 * 声明命名空间和c++的格式相似，在main 函数中调用使用 ‘ . ’ 来表示
 * 使用using来表示使用命名空间 和 c++ usingnamespace相同
 */

using System;
using System.Collections.Generic;

using halconspace3;
using halconspace2;

namespace halconspace2
{
    class Wolf1
    {
        public void Print_()
        {
            Console.WriteLine("hello wofl1");
        }
    }
}
namespace halconspace3
{
    class Wolf2
    {
        public void PrintMessage()
        {
            Console.WriteLine("hello wofl2");
        }
    }
}

namespace halconwork1
{
    class PramrGo
    {
        static void Main(string[] args)
        {
            Wolf1 wolf = new Wolf1();
            Wolf2 wolf2 = new Wolf2();
            wolf2.PrintMessage();
            wolf.Print_();
            Console.WriteLine("test message");
        }
    }
}
