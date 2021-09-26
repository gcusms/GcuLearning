<!--
 * @Description: this拓展理解
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-26 18:43:50
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-26 18:48:27
-->
# this拓展理解
### 用处：<br>
(1) 类的 this 作用在类内部，但是为隐式指针。就是在编译的时候会自动加上 this 指针 <br>
(2) 一个对象的this指针并不是对象本身的一部分，不会影响sizeof(对象)的结果。<br>
(3) 在类的非静态成员函数中返回类对象本身的时候，直接使用 return *this。
(4) 当参数与成员变量名相同时，如this->n = n （不能写成n = n)。

小结：
>this在成员函数的开始执行前构造，在成员的执行结束后清除。在C++中类和结构是只有一个区别的：类的成员默认是private，而结构是public。this是类的指针，如果换成结构，那this就是结构的指针了。