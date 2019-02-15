# C# Fundamentals
C# is Object Oriented Programming language with pillars in the language constituation:
- Abstraction
- Encapsulation
- Inheritance : Allows to build a derived class that inherits members and method of *base* class
- Polymorphism : Polymorphism refers to a programming language's ability to process objects differently depending on their data type or class.

## Object Oriented Programming (OOP)
An approach to designing and building the application that are *Flexible*, *Natural*, *Wel-Crafted*, *testable* by focusing on objects that interacts cleanly with one another.

### Abstract Classes
Abstract classes are the classes that can be instantiated and contain the abstract members. Example:
```csharp
   public abstract class Window
   {
        public virtual string Name { get; set; }
        
        public virtual void Draw()
        {
            //Some drawing code
        }
        
        public abstract void Open();
   }
```

## Collections:
Collection provides in-memory management of group of items.

- **Arrays** : A fixed sized list of elements that can be accessed using a positional index number, starting from 0

```csharp
   string[] colorOptions = new stringp[4];
   colorOptios[0] = "Red";
   colorOptios[0] = "Green";
   colorOptios[0] = "Blue";
   colorOptios[0] = "Pink";
```

With *Collection Initializer*

```csharp
   string[] colorOptions = { "Red", "Green", "Blue", "Pink" };
```

## Generics:
- Generics are techniques of writing code without specifying data types. Example of generic class:
```csharp
    public class OperationResult<TResult>
    {
        public OperationResult()
        {
        }

        public OperationResult(TResult sucess, string message) : this()
        {
            this.Ressult = sucess;
            this.Message = message;
        }

        public TResult Ressult { get; set; }
        public string Message { get; set; }
    }
```
To use the generic class 
```csharp
   var expected1 = new OperationResult<bool>(true, "Test");
   
   var expected2 = new OperationResult<decimal>(0m, "Test");
```
- Example of generic method:
```csharp
   public T RetrieveValue<T>(string sql, T defaultValue)
     {
         T value = defaultValue;

         return value;
     }
```
- **Generic constraints**

Constraints are like rules or instructions to define how to interact with a generic class or method. They can restrict the parameter that will be replaced with T to some certain type or class or have some properties, like to be new instance of class.

Following are the constraint allowed:

| Generic Constraint    | Constraint **T** to |
| :---:                 | :-:                 |
| where **T** : struct  | Value type          |
| where **T** : class   | Reference type      |
| where **T** : new()   | value with parameterless constructor |
| where **T** : Car     | Be or derive from Car |
| where **T** : ICar     | Be or implement ICar interface |

## Generic List:
A strongly typed list of elements that is accessed using a positional index number. Generic list is the reference type.
- Example of generic list:
```csharp
   List<string> mylist = new List<string>();
```

- Declaring and initializing the list of objects:
```csharp
   var vendors = new List<Vendor>();
   var vendor = new Vendor { Name = "Xyz"};
   vendors.Add(vendor);
```

## Generic Dictionary:
A strongly typed list of elements with keys and values.
- Example of generic dictionary:
```csharp
   Dictionary<string, string> provincies = new Dictionary<string, string>();
```
- With Collection initializers:
```csharp
   Dictionary<string, string> provincies = new Dictionary<string, string>()
   {
      "UT" : "Utrecht",
      "AMS" : "Amsterdam"
   };
```

## Generic Collection Interfaces:
IEnumerable is base interface for the Generic Collection Interfaces. Returning `IEnumerable<T>` promises to return readonly sequence of typed element.

![img text](https://github.com/milindchavan12/CSharpFundamentals/blob/master/assets/generic-interface.png)

When selecting which interface to use as data-type, see the following chart:
![img text](https://github.com/milindchavan12/CSharpFundamentals/blob/master/assets/chart.png)

### Object Relationship
- **Collabration (uses a)** : Exists a relationship when a object of a class uses instances of one or more class. 
- **Composition (has a)** : relationship exists when a object of a class composes instances of one or more class. (Example : Customer *has a* home adress)
![img text](https://github.com/milindchavan12/CSharpFundamentals/blob/master/assets/object-relationship.png)
