/*
 * @Description: 泛型
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-22 19:59:06
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-22 20:00:10
 * 泛型类似于c++中的stl。本例程中建立C泛型，然后再main函数中定义
 */

using System;
using System.Collections;
using System.Diagnostics;


namespace halconwork1
{

    class PramrGo
    {
        public class C<T>
        {
            private T[] array;
            public C(int i)  // 初始化array的大小size
            {
                array = new T[i + 1];
            }
            public T GetNumber(int index)
            {
                return array[index];
            }
            public void addNum(int value_, T obj)
            {
                array[value_] = obj;
            }
        }
        // 主函数
        static void Main(string[] args)
        {
            C<int> array = new C<int>(10);
            array.addNum(1, 2);
            Console.WriteLine("array.size = {0}", array.GetNumber(1));
            C<char> array2 = new C<char>(10);
            array.addNum(1, 'k');
            Console.WriteLine("array.size = {0}", (char)(array.GetNumber(1)));  // 转成ascll码上的值' k '
            Console.WriteLine("123123");  

        }
    } 
}
