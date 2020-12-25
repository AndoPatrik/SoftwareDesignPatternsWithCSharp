# Null Object (Behavioral)

## Intent

Eliminate null checks in the code.

## Motivation

- Checks the reference to ensure it is not null before invoking any methods.

## UML

![NullObjectUML](https://media.geeksforgeeks.org/wp-content/uploads/NullObject.png)

## Implementation

- Create abstract class that checks and returs an object if the paramter is real, else returns null object.

## Consequences

Pros

- Avoid null errors
- Eliminate null checks

Cons

## Known uses

- Conjuction with Factory Pattern
- Used with Tempalte Method Pattern

## Related Patterns

- Factory
- Singleton
- Builder
