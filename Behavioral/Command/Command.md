# Command (Behavioral)

## Intent

Turns a request into a stand-alone object that contains all information about the request. This transformation lets you parameterize methods with different requests, delay or queue a request’s execution, and support undoable operations.

## Motivation

- When you want to parametrize objects with operations.
- When you want to queue operations, schedule their execution, or execute them remotely.
- When you want to implement reversible operations.

## UML

![CommandUML](https://miro.medium.com/max/504/1*pwbB1ryzuKmwMhXJ3pP8jg.png)

## Implementation

- Declare command interface with single execution method
- Extracr requests into concrete command classes that implement the command interface. Each class must have a set of fields for storing the request arguments along with a reference to the actual receiver object. All these values must be initialized via the command’s constructor.
- Identify classes that will act as senders. Add the fields for storing commands into these classes.
- Change the senders so they execute the command instead of sending a request to the receiver directly.
- The client should initialize objects in the following order:

1. Create receivers.
2. Create commands, and associate them with receivers if needed.
3. Create senders, and associate them with specific commands.

## Consequences

Pros

- The object the creates the command is not the same that executes it (high cohesion)
- Command instances can be shared
- Eliminates switch statements

Cons

- Due to introduced interfaces and classes increasing the complexity of the application.

## Known uses

- Callbacks
- GUI buttons / drop downs
- Thread pools

## Related Patterns

- Visitor
