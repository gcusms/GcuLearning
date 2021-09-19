<!--
 * @Description: 
 * @Version: 2.0
 * @Autor: gcusms
 * @Date: 2021-09-17 12:48:55
 * @LastEditors: gcusms
 * @LastEditTime: 2021-09-18 15:52:10
-->
# C#学习笔记Updatinig
## 特性属性(没有分号“；”)
<font color = yellow>**特性作用：**</font>是用于在运行时传递程序中各种元素（比如类、方法、结构、枚举、组件等）的行为信息的声明性标签.

c#提供了两种特性：<font color = #00800>**预定义特性(AttributeUsage,Conditional, Obsolete)**</font>和<font color = #00800>**自定义特性**</font>
<br>

预定义特性：
## **Attribute**
|名称 | 可选参数 |解释作用|
|:--:  | :--:       | :--:  |
|Attrubute | 描述类型 | validon,allonmultiple,inhertid|
<br>

**其中:**<br> 参数 validon 规定特性可被放置的语言元素。它是枚举器 AttributeTargets 的值的组合。默认值是 AttributeTargets.All。<br>
参数 allowmultiple（可选的）为该特性的 AllowMultiple 属性（property）提供一个布尔值。如果为 true，则该特性是多用的。默认值是 false（单用的）。<br>
参数 inherited（可选的）为该特性的 Inherited 属性（property）提供一个布尔值。如果为 true，则该特性可被派生类继承。默认值是 false（不被继承）。<br>
例如：
```c#
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property, 
AllowMultiple = true)]
```
<br>

## **Conditional**
它会引起方法调用的条件编译，取决于指定的值，比如 Debug 或 Trace。例如，当调试代码时显示变量的值。告诉编译器下面的函数是Debug还是Trace（跟踪）
```c#
// [Conditional(
//    conditionalSymbol
// )]
//例如：
[Conditional("DEBUG")]
```
示例：
```c#
#define DEBUG
using System;
using System.Diagnostics;
public class Myclass
{
    [Conditional("DEBUG")]
    public static void Message(string msg)
    {
        Console.WriteLine(msg);
    }
}
class Test
{
    static void function1()
    {
        Myclass.Message("In Function 1.");
        function2();
    }
    static void function2()
    {
        Myclass.Message("In Function 2.");
    }
    public static void Main()
    {
        Myclass.Message("In Main function.");
        function1();
        Console.ReadKey();
    }
}
```
## **Obsolete**
这个预定义特性标记了不应被使用的程序实体。它可以让您通知编译器丢弃某个特定的目标元素。例如，当一个新方法被用在一个类中，但是您仍然想要保持类中的旧方法，您可以通过显示一个应该使用新方法，而不是旧方法的消息，来把它标记为 obsolete（过时的）。
```c#
[Obsolete(
   message
)]
[Obsolete(
   message,
   iserror
)]
```
其中：

参数 **message**，是一个字符串，描述项目为什么过时以及该替代使用什么。<br>
参数 **iserror**，是一个布尔值。如果该值为 true，编译器应把该项目的使用当作一个错误。默认值是 false（编译器生成一个警告）。




# out 和 ref
out和ref相当于c++里面的“&”。<br>
out可以返回多个值，具体的可以参考[链接]