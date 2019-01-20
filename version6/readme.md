# What's there in C# 6.0

### Auto Property Iniatilizer:
```csharp
   public Guid Id { get; } = Guid.NewId();
```

### Primary Constructor
```csharp
   public struct Money(string currency, decimal amount)
   {
      public string Currency { get; } = name;
      public decimal Amount { get; } = amount;
   }
```
### Static types
```csharp
   using System.Console;
   class Program
   {
      public static void Main()
      {
         Writeline("This is the example of Static Types");
      }
   }
```
