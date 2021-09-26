<!--
 * @Description: static理解
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-25 14:26:02
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-26 17:45:54
-->

# static理解
**静态变量：** 函数中的变量，类中的变量<br>
**静态类的成员：** 类对象和类中的函数

## 静态变量：
### <font color = blue><b>函数中的静态变量</b></font>：
函数为了变量声明 static 的时候，空间将在程序的声明周期中调用，静态变量的空间调用只分配一次。

来看看下面这个例子：
~~~c++
#include <iostream> 
#include <string> 
using namespace std; 

void demo() 
{ 
    // static variable 
    static int count = 0; 
    cout << count << " "; 

    // value is updated and 
    // will be carried to next 
    // function calls 
    count++; 
} 

int main() 
{ 
    for (int i=0; i<5; i++)  
        demo(); 
    return 0; 
} 
~~~
输出的结果：
~~~c++
0 1 2 3 4
~~~
每次 for 循环调用函数的时候都会传值进去，但是不会对变量计数进行初始化。

### 类中的静态变量：
类中可以声明静态变量，但是不可以由对象共享。对于不同的对象，不能有相同静态变量的多个副本。也是因为这个原因，静态变量不能使用构造函数初始化。

~~~c++
#include<iostream> 
using namespace std; 

class Apple 
{ 
public: 
    static int i; 

    Apple() 
    { 
        // Do nothing 
    }; 
}; 

int main() 
{ 
Apple obj1; 
Apple obj2; 
obj1.i =2; 
obj2.i = 3; 

// prints value of i 
cout << obj1.i<<" "<<obj2.i; 
} 
~~~
程序输出的结果会出现 error
因此，类中的静态变量需要在类外面进行范围解析和运算符显示初始化。
~~~c++
#include<iostream> 
using namespace std; 

class Apple 
{ 
public: 
    static int i; 

    Apple() 
    { 
        // Do nothing 
    }; 
}; 

int Apple::i = 1; 

int main() 
{ 
    Apple obj; 
    // prints value of i 
    cout << obj.i; 
} 
~~~
输出结果为 
~~~c++
1
~~~

## 静态成员
和变量一样，static 声明后可以存活到程序整个声明周期的范围。

~~~c++
#include<iostream> 
using namespace std; 

class Apple 
{ 
    int i; 
    public: 
        Apple() 
        { 
            i = 0; 
            cout << "Inside Constructor\n"; 
        } 
        ~Apple() 
        { 
            cout << "Inside Destructor\n"; 
        } 
}; 

int main() 
{ 
    int x = 0; 
    if (x==0) 
    { 
        Apple obj; 
    } 
    cout << "End of main\n"; 
} 
~~~

输出：
~~~c++
Inside Constructor
Inside Destructor
End of main
~~~

如果我们将对象声明为静态
~~~c++
#include<iostream> 
using namespace std; 

class Apple 
{ 
    int i; 
    public: 
        Apple() 
        { 
            i = 0; 
            cout << "Inside Constructor\n"; 
        } 
        ~Apple() 
        { 
            cout << "Inside Destructor\n"; 
        } 
}; 

int main() 
{ 
    int x = 0; 
    if (x==0) 
    { 
        static Apple obj; 
    } 
    cout << "End of main\n"; 
} 
~~~

输出：
~~~c++
Inside Constructor
End of main
Inside Destructor
~~~

### 类中的静态函数
访问类中的静态函数建议使用 '::' 而不是 '.'。