# Bridge (Structural)

## Intent

Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation which can be developed independently of each other.

## Motivation

Use the pattern when you need to extend a class in several independent dimensions, so the bridge pattern separetes concerns of absstraction and implementation by using composition over inheritance. Ideal to use if you need to be able to switch implementations at runtime.

## UML

![Bridge UML](https://upload.wikimedia.org/wikipedia/commons/c/cf/Bridge_UML_class_diagram.svg)

## Implementation

- Identify independent dimensions in classes. (Independent concepts could be abstraction/platform, domain/infrstructure, front/back-end, interface/implementation)
- See what operations the client needs and define them in the base abstraction class.
- Collect operations available on all platforms. Declearn the ones that needs abstraction in the general implementation interface.
- Create concrete implementation for platforms in the domain. (follow the implementation interface)
- Add reference field in the abstraction class for the implementation type.
- The client code should pass an implementation object to the abstraction's constructor. Client can forget the implementation and work only with the abstraction obj.

## Consequences

Pros

- Platform independent classes
- Client works with high level abstraction
- Introduce new abstractions independently from each other (open-close)

Cons

- Possible to make the code too complicated by applying it to highly cohesive class.

## Known uses

- (JWT) Separation of buttons
- JBDC: Java to SQL Driver
- GUI frameworks

## Related Patterns

- State/Strategy (have similar structure)
- Abstract Factory
- Builder (Builders act as implementation)
