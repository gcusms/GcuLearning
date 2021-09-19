/*
 * @Description: 属性
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-18 16:28:27
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-18 16:28:38
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace halconwork1
{
    class C
    {
        private int code;
        private double sage;
        private string keywords;
        //声明类型为Keywords的属性
        public string Keywords
        {
            get
            {
                return keywords;
            }
            set
            {
                keywords = value;
            }
        }
        // 使用 overide 关键打印输出
        public override string ToString()
        {
            return "Keywords = " + Keywords;
        }
    }
    class PramrGo
    {

        static void Main(string[] args)
        {
            C c = new C { Keywords = "wolf"};
            Console.WriteLine("Student Info: {0}", c);
            Console.WriteLine("123");
        }
    } 
}
