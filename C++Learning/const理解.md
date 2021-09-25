<!--
 * @Description: Const理解
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-25 10:57:15
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-25 13:59:28
-->
# Const的理解
## 含义：
const 常量定义(无法更改变量的值)

## 作用：
(1)定义常量
~~~c++
const int a =10;
~~~
(2)可以对常量进行安全检查<br>
(3)可以起到protect的作用
~~~c++
void f(const int i){
    i++; //error!
}
~~~
(4)可以节省空间，避免不必要的内存分配
**const** 定义常量从汇编的角度来看，只是给出了对应的内存地址，而不是像 **#define** 一样给出的是立即数，所以，**const** 定义的常量在程序运行过程中只有一份拷贝，而 **#define**定义的常量在内存中有若干个拷贝。)

## 多文件使用Const常量
需要加上extern 
> extern const int k = 10;

## 使用说明
* 定义后无法更改常量的值
  ~~~c++
  const int k = 100;
  k = 20; // error: aggsinment of the read-only variable 'k'
  ~~~
  ~~~c++
* 定义 const 需要进行初始化
  ~~~c++
  const int k; // error:unintitialized const 'k'
  ~~~


## 指针和Const
分类(4种)
~~~c++
const char * a; //指向const对象的指针或者说指向常量的指针。
char const * a; //同上
char * const a; //指向类型对象的const指针。或者说常指针、const指针。
const char * const a; //指向const对象的const指针。
// copy by the links:https://light-city.club/sc/basic_content/const/#1const
~~~
>小结：如果const位于 *的左侧，则const就是用来修饰指针所指向的变量，即指针指向为常量；如果const位于* 的右侧，const就是修饰指针本身，即指针本身是常量。

* 指向常量的指针：
~~~c++
const int *ptr; 
~~~
ptr指向的是一个 int 类型 const 对象的指针。所以不可以对*ptr进行赋值例如：
~~~c++
*ptr = 10; //error
~~~
>除此之外，也不能使用void*指针保存const对象的地址，必须使用const void*类型的指针保存const对象的地址。
~~~c++
const int p = 10;
const void * vp = &p;
void *vp = &p; //error
~~~

另外一个重点是：**允许把非const对象的地址赋给指向const对象的指针。
**
~~~c++
int *ptr1 = &val;
*ptr1=4;
cout<<*ptr<<endl;
~~~

<font color = green> <b>小结：</b><br>
对于指向常量的指针，不能通过指针来修改对象的值。
也不能使用void`*`指针保存const对象的地址，必须使用const void`*`类型的指针保存const对象的地址。<br>
允许把非const对象的地址赋值给const对象的指针，如果要修改指针所指向的对象值，必须通过其他方式修改，不能直接通过当前指针直接修改。</font>


## 常指针
const指针必须进行初始化：
~~~c++
int val = 100;
int* const k = &val;
~~~
但是不可指向一个const常数
例如：
~~~c++
const int num=0;
int * const ptr=&num; //error! const int* -> int*
cout<<*ptr<<endl;
~~~
上述若改为 const int *ptr或者改为const int *const ptr都可以正常！
~~~c++
const int p = 3;
const int * const ptr = &p; 
~~~

## 函数中使用const
(1)无意义的函数
~~~c++
void func(const int k);
void func(int* const k);
~~~
表明参数在函数体内不能被修改，但此处没有任何意义，var本身就是形参，在函数内不会改变。包括传入的形参是指针也是一样。<br>
输入参数采用“值传递”，由于函数将自动产生临时变量用于复制该参数，该输入参数本来就无需保护，所以不要加const 修饰。<br>

(2) 参数指针所指内容为常量不可变
~~~c++
void StringCopy(char *dst, const char *src);
~~~

(3) 用引用参数，为了增加效率同时可以防止修改。
~~~c++
void func(const A &a)
~~~
对于像void func(A a);这样声明函数的效率比较低,临时的变量 a 将会面临构造，赋值，析构。<br>
<font color = red><b>优化后：</b></font>**void func(A &a)** ,这样做的缺点是可能会修改 a 的值。<br>
<font color = red><b>再次优化后：</b></font>** void func(const A &a)**就可以起到保护的作用。<br>

>小结：对于非内部数据类型的输入参数，应该将“值传递”的方式改为“const 引用传递”，目的是提高效率。例如将void func(A a) 改为void func(const A &a)。
对于内部数据类型的输入参数，不要将“值传递”的方式改为“const 引用传递”。否则既达不到提高效率的目的，又降低了函数的可理解性。例如void func(int x) 不应该改为void func(const int &x)。


## 类中使用const
在一个类中，如果希望类中的成员变量不会被修改，建议加上 const 修饰。提高程序的健壮性。

~~~c++
//apple.cpp
class Apple
{
private:
    int people[100];
public:
    Apple(int i); 
    const int apple_number;
    void take(int num) const;
    int add(int num);
    int add(int num) const;
    int getCount() const;

};
//main.cpp
#include<iostream>
#include"apple.cpp"
using namespace std;

Apple::Apple(int i):apple_number(i)
{

}
int Apple::add(int num){
    take(num);
}
int Apple::add(int num) const{
    take(num);
}
void Apple::take(int num) const
{
    cout<<"take func "<<num<<endl;
}
int Apple::getCount() const
{
    take(1);
//    add(); //error
    return apple_number;
}
int main(){
    Apple a(2);
    cout<<a.getCount()<<endl;
    a.add(10);
    const Apple b(3);
    b.add(100);
    return 0;
}
//编译： g++ -o main main.cpp apple.cpp
//结果
take func 1
2
take func 10
take func 100
~~~
上述复杂的程序总结来说就是：定义一个 const 类对象和一个非 const 对象，前者默认调用的是同名的 take(int num)const函数，后者默认调用的是 take(int num)。

>const对象只能访问const成员函数,而非const对象可以访问任意的成员函数,包括const成员函数。