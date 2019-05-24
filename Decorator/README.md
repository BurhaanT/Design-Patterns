The decorator pattern allows for adding functionality to a class dynamically or at runtime without affecting the behaviour of other classes.

The pattern is designed so that multiple decorators can be stacked on top of each other, each time adding a new functionality to the overridden method(s).
Effectively, this extendes a class without having to change the original class or classes and adheres to the open-closed principle too.

### What problems can it solve?
- Responsibilities should be added to (and removed from) an object dynamically at run-time.
- A flexible alternative to subclassing for extending functionality should be provided.

Useful links:
- https://en.wikipedia.org/wiki/Decorator_pattern
- https://www.dotnettricks.com/learn/designpatterns/decorator-design-pattern-dotnet