# Iterator (Behavioral)

## Intent

Lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

## Motivation

- When your collection has a complex data structure under the hood, but you want to hide its complexity from clients (either for convenience or security reasons).
- To reduce duplication of the traversal code across your app.
- When you want your code to be able to traverse different data structures or when types of these structures are unknown beforehand.

## UML

![IteratorUML](https://dzone.com/sites/all/files/iterator_pattern.PNG)

## Implementation

- Declare iterator interface. Must have a method for fetching the next element from a collection.
- Declare collection interface and describe a method for fetching iterators.
- Implement concrete iterator classes for the collections.
- Implement collection interface in your collection classes.
- Replace all of the collection traversal code with the iterators.

## Consequences

Pros

- You can iterate over the same collection in parallel (contains its own iteration state)
- You can delay iteration and continue it when needed

Cons

- If your app works only with simple collections it can be overkill
- May be less efficient than going through elements of some specialized collections directly

## Known uses

- Java.util Iterator interface
- Java.util enumeration interface

## Related Patterns

- Composite
