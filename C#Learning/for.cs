/*
 * @Description: for循环
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 16:04:50
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-17 16:06:06
 */

using System;
using System.Collections.Generic;
namespace halconwork1
{
    class PramrGo
    {
        static void Main(string[] args)
        {
            int[] array = new int[51];
            /**
             * @description: 和c++类似
             * @param {i}
             * @return {null}
             * @author: gcusms
             */            
            for (int i = 0; i <= 50; i++)
            {
                array[i] = i;
            }
            /**
             * @description: 
             * @param {*}
             * @return {*}
             * @author: gcusms
             */            
            foreach (var j in array){
                Console.WriteLine("{0}", j);
            }
        }

    }
}
