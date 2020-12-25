# Prototype (Creational)

## Intent

Lets you copy existing objects without making your code dependent on their classes.

## Motivation

- When the code shouldn't depend on the concrete classes of objects that you need to copy.
- When you want to reduce the number of sublcasses that only differ in the way how they initialize their respective objects.
- When you want to create resource intensive objects

## UML

![PrototypeUML](https://miro.medium.com/max/2524/1*k445Y_YUwZ-ZypRZYKnhqw.png)

## Implementation

- Create prototype interface and declare the clone() method
- Prototype class must define the alternative constructor that accpepts an object of that class as argument. (Constructor must copy values of all fields defined in the class)
- Every class must explicitly override the cloning method and use its on class
- Optianlly create centralized prototype registry to store a catalog of frequently used prototypes

## Consequences

Pros

- Reduce the need of subclasses
- Option to customize created objects
- Clone objects without coupling their concrete class
- Get rid of repeated initialization code
- Produce complex objects more conveniently
- Alternative to inheritance when dealing with configuration presets for complex objects

Cons

- Hide concrete class implementation details
- Applyable for complex systems and objects
- Cloning complex objects that have circular references might be tricky

## Known uses

- Data from Database objects

## Related Patterns

- Factory
- Abstract Factory
