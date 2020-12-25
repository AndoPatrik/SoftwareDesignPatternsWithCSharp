# Adapter (Structural)

## Intent

Allows objects with incompatible interfaces to collaborate.

## Motivation

- Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.

- Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.

## UML

![AdapterUML](https://i.stack.imgur.com/1mPAh.gif)

## Implementation

- Make sure to have atleast 2 incompatible interfaces
- Declare client interface and describe how to communicate with incompatible service
- Create adapter class(follow the client interface)
- Store a reference to the service object in the adapter class
- Client should use the adapter via the client interface

## Consequences

Pros

- Allows classes to work together even if they are not compatible
- Old code can become compatible/reusable
- Single Responsibilty Principle (separetes convert logic from bussines logic)

Cons

- System can become complex due to the set new interfaces and classes

## Known uses

## Related Patterns

- Bridge
- Decorator
- Proxy
