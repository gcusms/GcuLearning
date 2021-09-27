<!--
 * @Description: friend友元
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-27 16:50:02
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-27 16:59:07
-->
# Friend 理解
友元可以访问普通函数或者成员函数中的私有数据变量。<br>
(1) 友元函数<br>
(2) 友元类<br>
**优点**: 提高了程序的运行效率。<br>
**缺点**: 破坏了类的封装性和数据的透明性。<br>
**总结**：- 能访问私有成员 - 破坏封装性 - 友元关系不可传递 - 友元关系的单向性 - 友元声明的形式及数量不受限制.<br>

例子：
~~~c++
#include <iostream>

using namespace std;

class A
{
public:
    A(int _a):a(_a){};
    friend int geta(A &ca);  ///< 友元函数
private:
    int a;
};

int geta(A &ca) 
{
    return ca.a;
}

int main()
{
    A a(3);    
    cout<<geta(a)<<endl;

    return 0;
}
~~~

~~~c++
#include <iostream>

using namespace std;

class A
{
public:
    A(int _a):a(_a){};
    friend class B;
private:
    int a;
};

class B
{
public:
    int getb(A ca) {
        return  ca.a; 
    };
};

int main() 
{
    A a(3);
    B b;
    cout<<b.getb(a)<<endl;
    return 0;
}
~~~

3.<font color = red>注意</font><br>
友元关系没有继承性 假如类B是类A的友元，类C继承于类A，那么友元类B是没办法直接访问类C的私有或保护成员。

友元关系没有传递性 假如类B是类A的友元，类C是类B的友元，那么友元类C是没办法直接访问类A的私有或保护成员，也就是不存在“友元的友元”这种关系。