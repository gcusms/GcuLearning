<!--
 * @Description: inline理解
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-26 18:52:33
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-26 19:22:31
-->
# inline理解
内联函数:
~~~c++
inline int func(){}; // Do something
~~~
## 编译器对 inline 函数的处理步骤
 * 将 inline 函数体复制到 inline 函数调用点处；
 * 为所用 inline 函数中的局部变量分配内存空间；
 * 将 inline 函数的的输入参数和返回值映射到调用方法的局部变量空间中；
 * 如果 inline 函数有多个返回点，将其转变为 inline 函数代码块末尾的分支（使用 GOTO）。

注意:
(1)如果函数体内的代码比较长，使得内联将导致内存消耗代价比较高。<br>
(2如果函数体内出现循环，那么执行函数体内代码的时间要比函数调用的开销大。

虚函数(非多态)可以是内联函数
笔记：
~~~c++
#include <iostream>  
using namespace std;
class Base
{
public:
    inline virtual void who()
    {
        cout << "I am Base\n";
    }
    virtual ~Base() {}
};
class Derived : public Base
{
public:
    inline void who()  // 不写inline时隐式内联
    {
        cout << "I am Derived\n";
    }
};

int main()
{
    // 此处的虚函数 who()，是通过类（Base）的具体对象（b）来调用的，编译期间就能确定了，所以它可以是内联的，但最终是否内联取决于编译器。 
    Base b;
    b.who();

    // 此处的虚函数是通过指针调用的，呈现多态性，需要在运行时期间才能确定，所以不能为内联。  
    Base *ptr = new Derived();
    ptr->who();

    // 因为Base有虚析构函数（virtual ~Base() {}），所以 delete 时，会先调用派生类（Derived）析构函数，再调用基类（Base）析构函数，防止内存泄漏。
    delete ptr;
    ptr = nullptr;

    system("pause");
    return 0;
} 
~~~