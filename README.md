# Software Design Patterns in .NET

This repository is dedicated to the study and mastery of software design patterns using the .NET infrastructure and the C# language. This document is enriched with historical, technical, and professional information and resources to help achieve advanced mastery of these patterns.

---

## Table of Contents

1. [Introduction to Design Patterns](#introduction-to-design-patterns)
2. [Pattern Classification](#pattern-classification)
3. [Origin and Historical Evolution](#origin-and-historical-evolution)
4. [Creational Patterns](#creational-patterns)
    - [Singleton](#singleton)
    - [Factory Method](#factory-method)
    - [Abstract Factory](#abstract-factory)
    - [Builder](#builder)
    - [Prototype](#prototype)
5. [Structural Patterns](#structural-patterns)
    - [Adapter](#adapter)
    - [Decorator](#decorator)
    - [Proxy](#proxy)
    - [Composite](#composite)
    - [Flyweight](#flyweight)
    - [Bridge](#bridge)
    - [Facade](#facade-suggested-to-be-added)
6. [Behavioral Patterns](#behavioral-patterns)
    - [Observer](#observer)
    - [Strategy](#strategy)
    - [Command](#command)
    - [State](#state)
    - [Memento](#memento)
    - [Template Method](#template-method)
    - [Chain of Responsibility](#chain-of-responsibility)
    - [Visitor](#visitor)
    - [Interpreter](#interpreter)
7. [Applications in .NET and C#](#applications-in-net-and-c)
8. [Professional and Advanced Level](#professional-and-advanced-level)
9. [Recommended Books and Resources](#recommended-books-and-resources)
10. [References](#references)

---

## Introduction to Design Patterns

Design patterns are reusable and proven solutions to common software design problems. In .NET, they allow developers to build cleaner, more maintainable, and scalable applications.

## Pattern Classification

- **Creational**: Manage object creation.
- **Structural**: Focus on class and object composition.
- **Behavioral**: Describe how objects interact with each other.

## Origin and Historical Evolution

Design patterns were popularized by the book *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994) by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides, known as the "Gang of Four" (GoF). Their ideas have been adapted to many languages, including C# and the .NET platform.

## Creational Patterns

### Singleton
**Purpose**: Ensures a class has only one instance.  
**Usage in .NET**: Commonly used for configuration or logging.  
**Example**: `Lazy<T>` + `private constructor`

### Factory Method
**Purpose**: Defines an interface for creating an object, deferring instantiation to subclasses.  
**Usage in .NET**: Enables flexibility in changing concrete types.

### Abstract Factory
**Purpose**: Creates families of related objects without specifying their concrete classes.  
**Usage**: Multiplatform GUI systems.

### Builder
**Purpose**: Builds complex objects step by step.  
**Usage**: Fluent API or LINQ query builders.

### Prototype
**Purpose**: Creates new objects by cloning others.  
**Usage**: Implements `ICloneable` in C#.

## Structural Patterns

### Adapter
Connects incompatible interfaces.

### Decorator
Adds functionalities dynamically.

### Proxy
Controls access to an object (caching, lazy-loading).

### Composite
Treats individual and composite objects uniformly.

### Flyweight
Reduces memory usage by sharing instances.

### Bridge
Separates abstraction from implementation.

### Facade *(Suggested to be added)*
Simplifies a complex interface.

## Behavioral Patterns

### Observer
Defines a one-to-many dependency (e.g., `INotifyPropertyChanged`).

### Strategy
Encapsulates interchangeable algorithms.

### Command
Encapsulates a request as an object (ideal for `ICommand` in MVVM).

### State
Changes object behavior based on its internal state.

### Memento
Captures internal state to restore it later.

### Template Method
Defines the skeleton of an algorithm.

### Chain of Responsibility
Passes a request along a chain of handlers.

### Visitor
Adds operations without modifying classes.

### Interpreter
Interprets a grammar-based language (e.g., mathematical expressions).

## Applications in .NET and C#

- MVVM in WPF and Xamarin: Command, Observer, Strategy.  
- ASP.NET Core: Dependency Injection (Abstract Factory), Middleware (Chain of Responsibility).  
- Entity Framework: Unit of Work, Repository (also considered architectural patterns).

## Professional and Advanced Level

To master patterns in .NET:

- Understand SOLID principles and object-oriented design.
- Use patterns with unit testing and TDD.
- Study open-source projects on GitHub (e.g., `ASP.NET Core`, `AutoMapper`, `MediatR`).
- Create your own patterns for recurring problems.

## Recommended Books and Resources

- *Design Patterns: Elements of Reusable Object-Oriented Software* – GoF (Erich Gamma et al.)
- *Head First Design Patterns* – Eric Freeman
- *Patterns of Enterprise Application Architecture* – Martin Fowler
- *Dependency Injection in .NET* – Mark Seemann
- [Refactoring Guru – Design Patterns in C#](https://refactoring.guru/design-patterns/csharp)
- [Microsoft Docs – Design Patterns](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)

## References

- Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (1994). *Design Patterns: Elements of Reusable Object-Oriented Software*.
- Seemann, M. (2011). *Dependency Injection in .NET*.
- Microsoft Learn: [https://learn.microsoft.com](https://learn.microsoft.com)
- Refactoring Guru: [https://refactoring.guru](https://refactoring.guru)

