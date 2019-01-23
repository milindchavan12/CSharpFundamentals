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

## Collections and Generics:

### Collection:
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

