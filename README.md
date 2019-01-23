# C# Fundamentals
C# is Object Oriented Programming language with 3 pillars in the language constituation:
- Encapsulation
- Inheritance
- Polymorphism

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

| Attempt | #1  | #2  |
| :---:   | :-: | :-: |
| Seconds | 301 | 283 |
