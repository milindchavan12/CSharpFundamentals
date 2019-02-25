# Interfaces
Interfaces describe a group of related functions that can be belong to any class or struct.

In fact, Interface is a **Contract** and makes our code flexible.

### Interface Segregation Principle:
Client should not be forced to depend upon the methods they do not use. Interfaces belong to clients, not to hierarchies.
- Interfaces should only include what the calling code needs.

### Interface Inheritance:
When a class implements the inherited interface then it must provide the implementation of all the members that are defined within the interface inheritance chain.

![img text](https://github.com/milindchavan12/CSharpFundamentals/blob/master/assets/inheritance-interface.png)

### Design Patterns:
Interfaces helps to implement various Design Patterns:
- Repository Pattern
- Factory Method Pattern
- Decorator Pattern
