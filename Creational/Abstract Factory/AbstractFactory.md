# Abstract Factory (Creational)

## Intent

Lets you produce families of related objects without specifying their concrete classes. (Ultimately a factory for other factories. Higher level of abstraction)

## Motivation

Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

## UML

![AbstractFactory](https://narbase.com/wp-content/uploads/2020/06/SecondImage-700x328.jpeg)

## Implementation

- Collect the tpye of prodcuts and their variants
- Declear abstarct product interafaces for all product types
- Make all concrete product classes implement these intrefaces
- Implement set of convrete factory classes(one for each variant)
- Create factory initialization
- Replace direct calls to product constructors with the call to appropriate factory

## Consequences

Pros

- OpenClose(introducde new variants without changing existing)
- SRP (Extract creation logic into one place)
- Avoid tight coupling between concrete products and client
- Products from factory are compatible with each other

Cons

- Due to the lot of interfaces and classes code can become complex
- Supporting additional products may be difficult

## Known uses

- GUI creation and management accross different systems (MAC/Windows buttons)

## Related Patterns

- Factory pattern
- Singleton pattern
- Prototype pattern
