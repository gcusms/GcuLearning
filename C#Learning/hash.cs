/*
 * @Description: 哈希表
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-22 19:33:39
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-22 19:42:36
 */

using System;
using System.Collections;
using System.Diagnostics;


namespace halconwork1
{

    class PramrGo
    {
        public static Hashtable hash1 = new Hashtable();
        public static int value;
        // 主函数
        static void Main(string[] args)
        {
            hash1.Add("01", "sss");
            hash1.Add("02", "halll");
            if (hash1.ContainsKey("gcusms"))  // 判断哈希表中是否函数 "gcusms"
            {
                Console.WriteLine("the hashtable is include gcusms");
            }else
            {
                hash1.Add("05", "gcusms");
            }
            ICollection i = hash1.Keys;
            Console.WriteLine("count = {0}", hash1.Count);  // 输出哈希表的个数
            foreach (string k in i)
            {
                int.TryParse(k, out value);
                Console.WriteLine("value = {0}",value);  // 输出哈希表的值

            }
            Console.WriteLine(i.GetType());  // 打印声明对象 i 的类型
            Console.WriteLine("123123");  

        }
    } 
}