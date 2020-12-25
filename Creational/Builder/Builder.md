# Builder (Creational)

## Intent

Lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

## Motivation

- To get rid of a 'telescopic consctrutcor'. (Constructor with lot of optional paramters)
- When you want your code to be able to create different representations of some object.
- To consctruct composite trees or other complex objects.

## UML

![BuilderUML](https://www.dofactory.com/img/diagrams/net/builder.gif)

## Implementation

- Make sure you can clearly define the common construction steps for building ALL available 'product' representations
- Declear these steps in the base builder interface
- Create concrete builder class for each version of product representation and implement their constructions steps
- Create a Director class, that may encapsulate various ways to construct a produt using the same builder object
- Client code creates both the builder and the director objects
- Construction result can be obtained directly from the director only if all products follow the same interface, otherwise the client should fetch the result from the builder

## Consequences

Pros

- Construct objects step by step
- Get rid of telescopis constructor
- Reuse the same consctruction code when builiding different representations
- SRP (Isolate complex construction code from bussines logic)

Cons

- Requires creating multiple new classes, so increases overall complexity of the code

## Known uses

- Method chaining for object creation
- Large set of paramaters for object creation
- Creating new algorithm without changing the code

## Related Patterns

- Factory pattern
- Prototype pattern
- Abstract factory pattern
- Singleton pattern
