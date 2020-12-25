# Composite (Structural)

## Intent

Lets you compose objects into tree structures and then work with these structures as if they were individual objects.

## Motivation

Use when you have tree-like object structure.
Use when the client code to treat both simple and complex elements uniformly

## UML

![CompositeUML](https://refactoring.guru/images/patterns/diagrams/composite/example-2x.png)

## Implementation

- Make sure core model of your app can be presented as tree structure. (Break it down into simple elements and containers)
- Declear componenet interface with list of methods tha make sense for both simple and complex componenets
- To represent simple elements create leaf class
- To represent complex elements create container, and provide an rray field for storing references to sub-elements.
- Define the methods for adding and removal of child elements in the container.

## Consequences

Pros

- Work with complex tree structures more conveniently (use polymorphism and recursion)
- Open closed principle (New elements can be introduced without breaking existing)

Cons

- Difficult to provide common interface for classes whose functionality differs

## Known uses

- Java GUI
- Java JUnit 3.x

## Related Patterns

- Chain of responsibility
- Builder
- Flyweight
