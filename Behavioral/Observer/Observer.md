# Observer (Behavioral)

## Intent

Lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

## Motivation

- When changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
- When some objects in your app must observe others, but only for a limited time or in specific cases.

## UML

![ObserverUML](https://upload.wikimedia.org/wikipedia/commons/0/01/W3sDesign_Observer_Design_Pattern_UML.jpg)

## Implementation

## Consequences

Pros

- OCP (Introduce new subscriber classes without having to change publisher's code)
- Establish relations between objects during runtime

Cons

- Subscribers are notified in random order
- Difficult to follow control flow
- Hard/Costly to update

## Known uses

- MVC Framework
- Java Message Service

## Related Patterns

- Mediator
- Command
