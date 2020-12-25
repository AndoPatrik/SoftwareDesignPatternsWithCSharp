# Immutable Objects (Creational)

## Intent

Prevents a client from changing the values of its data fields after creation. To change an immutable object, one has to discard it and create a new one with the revised fields.

## Motivation

When the data of an object needs to be unchangeable, so you can guarantee data consistency. (unless discarded and replaced completely)

## UML / Visualization

![ImmutableObjects](https://i.stack.imgur.com/lS2tQ.jpg)

## Implementation

- Use the keyword of your language of choice to set var immutable (final, readonly, val...)

## Consequences

Pros

- Object remains unchanged

Cons

- If we want to change it after instantiation we must make a copy of the object, change the data and instantiate a new instance.

## Known uses

- Strings
- Configuration files
- Singleton

## Related Patterns

- Singleton
