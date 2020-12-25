# Strategy (Behavioral)

## Intent

Lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

## Motivation

- When you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.
- when you have a lot of similar classes that only differ in the way they execute some behavior.
- When your class has a massive conditional operator that switches between different variants of the same algorithm.
- To isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.

## UML

![StrategyUML](https://www.tutorialspoint.com/design_pattern/images/strategy_pattern_uml_diagram.jpg)

## Implementation

- Identify an algortihm that's prone to a frequent changes
- Declrare the strategy interface (common to all variants)
- Extract all algorithms into their own classes. (They should implement strategy interface)
- Add field for storing a reference to a strategy obj in the context class

## Consequences

Pros

- Swap algorythms inside an object during runtime
- Isolate implementation details
- Replace inheritance with composition
- OCP (Intorduce new strategy without having to change exisitng context)

Cons

- If you have rarely changing algorythms it can just overcomplicate the program
- Clients must be aware of the differences between strategies to be able to select the proper one
- Modern languages offer support to implement anonymus functions that can replace the strategy objects

## Known uses

## Related Patterns

- Factory
- Builder
- Decorator
