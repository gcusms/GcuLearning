<!--
 * @Description: throw.md异常抛出
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-27 18:40:15
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-27 18:47:18
-->
# throw异常抛出
程序中进程需要测试一段代码使用 try{}和 cath()接收抛出的异常。

~~~c++
#include<iostream>
using namespace std;
void temperature(int t)
{
try{
    if(t==100) throw "It's at the boiling point.";
    else if(t==0) throw "It reached the freezing point";
    else cout<<"the temperature is OK..."<<endl;
}
catch(int x){cout<<"temperature="<<x<<endl;}
catch(char const*s){cout<<s<<endl;}
}
int main(){
temperature(0);						//L1
temperature(10);						//L2
temperature(100);						//L3
system("pause");
return 0;
}
~~~


