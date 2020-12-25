# Chain of Responsibility (Behavioral)

## Intent

Lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

## Motivation

- When your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.
- When it’s essential to execute several handlers in a particular order.
- When the set of handlers and their order are supposed to change at runtime.

## UML

![ChainOfResponsibility](https://upload.wikimedia.org/wikipedia/commons/6/6a/W3sDesign_Chain_of_Responsibility_Design_Pattern_UML.jpg)

## Implementation

- Declare the handler interface and describe the signature of a method for handling request
- Create abstract base handeler to eliminate boilerplate code in concrete handlers.
- Create concete handler subclasses and implement their handling()
- The client may either assemble chains on its own or receive pre-built chains from other objects.
- The client may trigger any handler in the chain, not just the first one.
- Client needs to be ready to handle the following scenarios:

1. The chain may consist of a single link.
2. Some requests may not reach the end of the chain.
3. Others may reach the end of the chain unhandled

## Consequences

Pros

- SRP
- OCP
- Control the order of the request handling
- Reduce coupling

Cons

- Some request may not be handled

## Known uses

- Bank applications (money processing)

## Related Patterns

- Composite
