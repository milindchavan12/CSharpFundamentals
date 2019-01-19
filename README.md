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
