BUILDER
-------

Intent
------
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

Notes:
Unlike other creational patterns, Builder doesn’t require products to have a common interface.

Applicability
-------------

# Use the Builder pattern when you want your code to be able to create different representations of some product (for example, stone and wooden houses).
# The Builder pattern can be applied when construction of various representations of the product involves similar steps that differ only in the details.

# Builder focuses on constructing complex objects step by step. Abstract Factory specializes in creating families of related objects. 
  Abstract Factory returns the product immediately, whereas Builder lets you run some additional construction steps before fetching the product.

Usage examples: 
# The Builder pattern is a well-known pattern in C# world. It’s especially useful when you need to create an object with lots of possible configuration options.


Credits:https://refactoring.guru/design-patterns/builder