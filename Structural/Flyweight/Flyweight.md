# Flyweight (Structural)

## Intent

Lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

## Motivation

Perfect fit to use when your program must support a huge number of objects which barely fit into the RAM.

## UML

![FlyweightUML](https://dzone.com/sites/all/files/flyweight_pattern.png)

## Implementation

- Create an object via factory
- The interface connects to a concrete implementation and returns specific complex object based in the passed paramaters

## Consequences

Pros

- Loosely coupled clases
- Resource reuse
- Save lots of RAM

Cons

- Trading RAM over CPU cycles when the context needs to be recalculated
- Code may become complicated
- Not meant for upper level programming
- Special care for flywighted objects

## Known uses

- Java Strings

## Related Patterns

- Factory
- Singleton
