# Sealed keyword in C-Sharp
My experiments with Sealed keyword in C#

## WHAT IS SEALED KEYWORD AND WHEN TO USE?
- It is one of the important keywords in C#. It can be used with classes, methods and properties.
- If you don’t want derived classes to customize your class or change the behaviour of your class, you can use ‘sealed’ keyword.

## HOW SEALED IS USED?
- When used with classes, a sealed class cannot be inherited or in other words it is used to restrict inheritance of a class. 
- In C#, we should not use abstract modifier with sealed class, because an abstract class must be inherited by a class that provides an implementation of the abstract methods or properties.
- Local variables cannot be sealed.
- In C#, structs are implicitly sealed.

