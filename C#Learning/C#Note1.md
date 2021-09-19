<!--
 * @Description: C#学习笔记Updatinig
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-18 16:22:55
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-18 16:28:00
-->
# C#学习笔记Updatinig
## 属性
相当于c++ 访问类里面的成员函数或者成员变量的函数
使用 get 获取和 set 设置 private 成员变量或者成员函数
```c#
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
```
