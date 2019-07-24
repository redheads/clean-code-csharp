## Die Werte des Clean Code Entwicklers

1. Do Only What's Neccessary
1. Isolate Aspects
1. Minimize Dependencies
1. Honor Pledges

---

### Do Only What's Neccessary

- Vorsicht vor Optimierungen:
  - You Ain't Gonna Need It (**YAGNI**)
  - Keep it simple, stupid (**KISS**)

---

### Isolate Aspects

- Don't Repeat Yourself (DRY)
- Separation of Concerns (SoC)
- Single Level of Abstraction (**SLA**)
- Single Responsibility Principle (**SRP**)
- Interface Segregation Principle (**ISP**)

---

### Minimize Dependencies

- Information Hiding Principle
- **Law of Demeter**
- **Tell, don't ask**
- Dependency Inversion Principle (DIP)
- Interface Segregation Principle (**ISP**)
- Open Closed Principle (OCP)

----

#### Law of Demeter

```csharp
class Street { string Name { get; set; } }

class Address { Street Street { get; set; } }

class Person {
    int Id { get; set; }
    Address Address { get; set; }
}

class PersonService {

    void DoSomething() {
        var person = repo.GetById(id)
        var street = person.Address.Street; // <- train wreck
    }

    void DoSomethingBetter() {
        var person = repo.GetById(id)
        var street = person.GetStreet();
    }
}
```

---

### Honor Pledges

- Überraschungen vermeiden
- AKA: **Principle of Least Astonishment**
- Implementation mirrors design
- **Favour Composition over Inheritance (FCoI)**
- Liskov Substitution Principle (LSP)
