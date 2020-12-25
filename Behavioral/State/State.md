# State (Behavioral)

## Intent

Lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

## Motivation

- When you have an object that behaves differently depending on its current state, the number of states is enormous, and the state-specific code changes frequently.
- when you have a class polluted with massive conditionals that alter how the class behaves according to the current values of the class’s fields.
- When you have a lot of duplicate code across similar states and transitions of a condition-based state machine.

## UML

![StateUML](https://www.tutorialspoint.com/design_pattern/images/state_pattern_uml_diagram.jpg)

## Implementation

- Define the context class
- Declrate the state interface
- Create state class for every actual state (derives from state interface)
- Add reference field of the state in the context class (use the interface type)
- Replace empty state conditionals with calls to corresponding methosd of the state object

## Consequences

Pros

- SRP (separate state logics)
- OCP (Add new states without changing esting state)
- Simplyfy the code of the context (eliminate bulky state machine conditionals)

Cons

- Applying the pattern can be overkill if a state machine has only a few states or rarely changes.

## Known uses

- State machine

## Related Patterns

- Bridge
- Strategy
