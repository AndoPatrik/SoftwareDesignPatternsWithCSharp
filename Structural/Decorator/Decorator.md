# Decorator (Structural)

=======

## Intent

Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. Client-specified embellishment of a core object by recursively wrapping it. (Wrapping a gift, putting it in a box, and wrapping the box.)

## Motivation

You want to add behavior or state to individual objects at run-time. Inheritance is not feasible because it is static and applies to an entire class.

## UML

![DecoratorUML](https://www.researchgate.net/profile/Amnon_Eden/publication/258568562/figure/fig17/AS:669479990218775@1536627876993/4-UML-Class-diagram-of-the-structure-of-the-Decorator-pattern.ppm)

## Implementation

- Create an interface
- Create concrete class impleting the interface
- Create abstract decorator implementing the interface
- Create concrete decorator extending the 'abstract decorator'
- Use the concrete decorator to decorate the base obj

## Consequences

Pros

- Extend obj behavior without making a new subclass
- Add or remove responsiblities during runtimee
- Combine several behaviors by wrapping an object into multiple decorators
- Single Responsiblity Principle (Divide a monolithic class that implements many possible variants of behavior into smaller classes.)

Cons

- Hard to remove wrapper from the wrapper stack
- Hard to implement a decorator in a way that its behavior doesn't depend on the order in the decorators stack
- Code configuration may look ugly

## Known uses

- java.io
- When you need to assign extra behaviors to an object during runtime without braking the code that uses the object

## Related Patterns

- Proxy
- Chain of Responsibility
- Adapter
