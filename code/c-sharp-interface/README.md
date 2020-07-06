# Interfaces in C-Sharp
My experiments with Interface in C#

## What is an Interface?
- Interface defines a Contract. 
- Any class or a struct implementing an interface must implement all defined parts of the interface.
- Interface is a type which can includes methods, properties, indexers, events etc.
- Interfaces provide no implementation just definitions.
- Interfaces supports Polymorphism. 
- C-Sharp supports multiple inheritance of interfaces.

```
public interface IBook {
  void ShipItem();
}

public class Ebook : IBook {
  public void ShipItem() { ... }
}

public class Hardcore : IBook {
  public void ShipItem() { ... }
}

```
