/*
 * @Description: 函数接口
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 15:24:20
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-17 15:25:24
 */

using System;
using System.Collections.Generic;

namespace halconwork1
{
    /**
     * @description: 接口函数
     * @param {可以变量，函数，}
     * @return {NULL}
     * @author: gcusms
     */
    interface ImyFace
    {
        // 成员接口
         void PrintFace();
    }
    class Cat : ImyFace
    {
        public  void PrintFace()
        {
            Console.WriteLine("I Like Fish");
        }
    }
    class capture
    {
        public void Cay(ImyFace im)
        {
            im.PrintFace();
            Console.WriteLine("***************************");
        }
    }
    class PramrGo
    {
        static void Main(string[] args)
        {
            capture c = new capture();
            ImyFace im;
            im = new Cat();
            c.Cay(im);
            //ImyFace im_ = new ImyFace();
            Console.WriteLine("test message");
        }
    }
}
