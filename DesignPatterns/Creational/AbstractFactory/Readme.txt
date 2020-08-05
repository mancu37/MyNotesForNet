ABSTRACT FACTORY
----------------

Intent
------
Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

Aplicability
------------
# Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.
# The Abstract Factory provides you with an interface for creating objects from each class of the product family. As long as your code creates objects via this interface, you don’t have to worry about creating the wrong variant of a product which doesn’t match the products already created by your app.

Usage examples: The Abstract Factory pattern is pretty common in C# code. Many frameworks and libraries use it to provide a way to extend and customize their standard components.
Identification: The pattern is easy to recognize by methods, which return a factory object. Then, the factory is used for creating specific sub-components.

Credits: https://refactoring.guru/
