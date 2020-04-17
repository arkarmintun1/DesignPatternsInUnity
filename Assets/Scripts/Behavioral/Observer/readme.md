# Definition

- Observer pattern is already natively implemented in the Unity Engine, in the form of C# event system
- the core purpose of the Observer is to observe other objects and specific changes in their internal states

## Events

- When an event is raised by an object (publisher), it sends out a signal that other objects (subscribers) can capture.
- Only those objects that subscribe to it will be notified
- Can choose to triggered by it or just ignore it

## Delegates

- Delegates hold references to functions (function pointers)
- Very useful when you want to trigger multiple functions from one call (multicast)
