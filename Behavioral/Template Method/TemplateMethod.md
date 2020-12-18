# Template Method (Behaviroal)

## Intent

Define the skeleton of an algorithm in an operation, deferring some steps to client subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
Base class declares algorithm 'placeholders', and derived classes implement the placeholders.

## Motivation

Two different components have significant similarities, but demonstrate no reuse of common interface or implementation. If a change common to both components becomes necessary, duplicate effort must be expended.

## UML

![TemplateUML](https://sourcemaking.com/files/v2/content/patterns/Template_Method.png)

## Implementation

- Define a new abstract base class
- Define the shell of the algorythm and the definition of all standard steps to the new base class
- Define placeholder or 'hook' method in the base class for each step that requires many different implementations.
- Invoke the hook methods from the template method.
- Declare an "is-a" relationship to the new abstract base class
- Remove from all the existing classes all the implementation details that have been moved to the base class
- Only details that will remain in the existing classes will be the implementation details peculiar to each derived class

## Consequences

Advantages

- Elimination of code duplication
- Let clients override only certain parts of large algorythm, making them less affected by changes, that happen to other parts of the algortythm

Disadvantages

- Some clients may be limited by the provided skeleton of an algorythm
- You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass.
- Template methods tend to be harder to maintain the more steps they have.

## Known uses

- java.util.Collections
- java.util.Arrays

## Related Patterns

- Factory Method
- Strategy
