# Definition

- a structure that can be visited and acted upon by another object
- means that it's possible to perform specific operations on elements of an object's structure without modifying it
- useful when you need to implement a system that needs to traverse a hierarchical structure and execute specific operations on individual nodes

## Two Key Participants

- Visitor
  - The visitor is the interface for concrete visitors

- Visitable
  - The visitable is the interface for objects that are accepting visitors