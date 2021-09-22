/*
 * @Description: 队列
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-22 18:59:10
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-22 19:00:13
 * c#队列和c++中的类似，都是遵循先进先出的原则
 */

using System;
using System.Collections;
using System.Diagnostics;


namespace halconwork1
{

    class PramrGo
    {
        public static int value;

        // 主函数
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);   // 在队列的头中添加元素
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(10);
            Console.WriteLine(q.GetType());  // 输出q的类型
            Console.WriteLine(q.Count);  // 打印队列元素的个数

        }
    } 
}
