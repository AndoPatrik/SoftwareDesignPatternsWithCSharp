# Factory Method (Creational)

## Intent

Define an interface for creating a new object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to sublcasses. (provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.)

## Motivation

A framework needs to standardize the architectural model for a range of applications, but allow for individual applications to define their own domain objects and provide for their instantiation.

## UML

![FactoryMethodUML](https://upload.wikimedia.org/wikipedia/commons/1/1a/Factory_Method_design_pattern.png)

## Implementation

- Create an interface and make the classes (that are intended to be in the factory) follow this interface.
- Add an emtpy factory method in the 'creator' class. The return type of the method should match the interface.
- Extract the object creation logic and place into the factory method of the 'creator' class.
- Use the factory class instead of the 'new' keyword

## Consequences

Pros

- Avoid tight coupling between creator and concrete classes
- Single Responsibility Principle (There is one place in the code that is responsible for creating objects.)
- Open/Closed principle (Introduce new types without breaking/changing existing client code.)

Cons

- Code may become complicated, because you may need to introduce lot of new sublcasses.

## Known uses

- Socket / Databese connections
- OOP object creation

## Related Patterns

- Abstract Factory
- Prototype
- Builder
