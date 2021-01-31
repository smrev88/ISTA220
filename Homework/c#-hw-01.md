# Homework C# 01

### 1. What is a console app?
is an application that runs in a command prompt window instead of providing a GUI

### 2. List two differences between .NET Framework and .NET Core. 
1. Core is capable of building portable apps that can run on other operating systems like Linux
1. Core apps do not have the same range of features like Framework

### 3. What does Main() (the main method) do in a console application? 
Designates the program's entry point. It should be specified in the Program class as a static method.

### 4. Describe these three files: TextHello.sln, TextHello.csproj, and AssemblyInfo.cs.
A. Top level solution file. Each app contains a single solution file.
A. Project file. Each project file references one or more files containing the source code and other artifacts for the project. Must write all source code in a single project in the same
language
A. Special file that you can use or add attributes to a program like date of the program being written, name of author etc.

### 5. What is the purpose of a namespace?
Creates a container for items such as classes
Used to declare a scope that contains a set of related objects. You can use it to organize code 
elements and to create globally unique types.

### 6. Describe specifically what using statements do.
The actions that a program takes are expressed in statements.
Declaring variables, assigning values, calling methods, looping

### 7. What is the entry point for a console app? What is the entry point for a UWP app?
Main Method
App.xaml.cs

### 8. What is an assembly?
Classes that are compiled. It is usually a .dll file name extension. Also .exe are assemblies
compiled libraries

### 9. How many different versions of the WriteLine() method does the Console class contain?
19

### 10. What is the relationship between an assembly and a namespace?
single assembly can contain classes defined in many namespaces
single namespace can span multiple assemblies

### 11. What is a graphical app?
UWP, apps that can run on computers, tablets, phones that use a UI

### 12. What does Build do?
Compiles the C# Code, resulting in a program you can run. Output window appears below the code and text editor window.

### 13. (Not in book) What is bytecode? What is Microsoft CIL? Do you think that CIL is bytecode? Why or why not?
Bytecode, also termed portable code or p-code, is a form of instruction set designed for efficient 
execution by a software interpreter. Unlike human-readable source code, bytecodes are compact numeric 
codes, constants, and references

It complies with the Common Language Infrastructure (CLI), which is a specification that was developed by Microsoft 
to describe a set of rules which programming languages need to comply with when they are targeting 
the CLI. One of the most important aspects of the CIL is that it is a platform- and CPU-independent 
instruction set.

Compilation (source code)
CIL (P-code)
CLR (Byte code



### 14. What does Debug do?
Process of finding errors during application execution