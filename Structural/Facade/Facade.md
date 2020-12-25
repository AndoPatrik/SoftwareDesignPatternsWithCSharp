# Facade (Structural)

## Intent

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

## Motivation

When you have a complex subsystem but you need to have limited and easier to use interface to utilize the complex subsystem. Also, when you want to structure the subsystem into layers.

## UML

![Facade UML](https://www.researchgate.net/profile/Siti_Rochimah2/publication/323517753/figure/fig1/AS:599724600078337@1519996895927/Class-diagram-of-the-Facade-pattern.png)

## Implementation

- Check if possible to create a simpler interface then subsystems provide
- Declare and implement subsystems in the facade class
- Make all the client code communicate with the subsytem via Facade
- If it gets too big consider extracting parts (create multiple facades)

## Consequences

Pros

- Shields user from complex system components while providing a simpler itnerface to use
- Changing in underlying subsystems without changes in client code
- Dependency reduction
- Code isolation

Cons

- If the faced is the only acces point then it may limit the features and flexibility
- May become a 'god object'

## Known uses

- Anywhere where complex system should be hidden (complex applications)

## Related Patterns

- Abstract Factory
- Singleton
