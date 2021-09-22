/**
 * @description: 委托函数
 * @param {*}
 * @return {*}
 * @author: gcusms
 * C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。
 * 委托（Delegate） 是存有对某个方法的引用的一种引用类型变量。引用可在运行时被改变。
 * 更改的 ref 变量，就是修改了地址的值
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace halconwork1
{

    class PramrGo
    {
        static int input_n = 10;
        public static int addNumber(int in_)
        {
            input_n += in_;
            return input_n;
        }
        public static int getNum()
        {
            return input_n;
        }
        public static int MultNum(int n)
        {
            return input_n *= n;
        }
        delegate int getNumber(int k); // 委托函数
        // 主函数
        static void Main(string[] args)
        {
            getNumber n1 = new getNumber(addNumber);  // 声明委托对象n1
            getNumber n2 = new getNumber(MultNum);  // 声明委托对象n2
            n1(20);  // 相当于 addNumber (20)
            Console.WriteLine("The result = {0}", getNum());
            n2(50);  // 相当于 MultNum (20)
            Console.WriteLine("The result = {0}", getNum());
            n1 += n2;  // 可以将两个委托声明的对象相加等于两个函数的返回值相加
            n1(2);
            Console.WriteLine("The result = {0}", getNum());
            Console.WriteLine("123");
        }
    } 
}
