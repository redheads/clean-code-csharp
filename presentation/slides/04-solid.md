## SOLID

<div class="background-info" style="margin-bottom: 20px;">"P" steht immer für "Principle"</div>

- SRP: Single Responsibility <!-- .element: class="fragment" data-fragment-index="0" -->
- OCP: Open/Close <!-- .element: class="fragment" data-fragment-index="1" -->
- LSP: Liskov Substitution <!-- .element: class="fragment" data-fragment-index="2" -->
- ISP: Interface Segregation <!-- .element: class="fragment" data-fragment-index="3" -->
- DIP: Dependency Inversion <!-- .element: class="fragment" data-fragment-index="4" -->

Code Beispiele folgen...

---

### Single Responsibility Principle

> A module should have only one reason to change

<cite>Robert C. Martin</cite>

----

![srp1](images/clean-code-01_srp1.png)

<cite style="font-size: small">From: Agile Principles, Patterns and Practices in C#, Robert C. Martin</cite>

----

![srp2](images/clean-code-01_srp2.png)

<cite style="font-size: small">From: Agile Principles, Patterns and Practices in C#, Robert C. Martin</cite>

----

```csharp
class SomeService {
    void DoMagic(string message) {

        var emailService = new EmailService { Credentials = "bar" };

        try { emailService.Send(message); } 
        catch (Exception e) { /* ... */ }

        _smsService.Send(message);
    }
}
```

```csharp
class SomeServiceBetter {
    private readonly IEmailService _emailService;
    private readonly ISmsService smsService;

    SomeServiceBetter(IEmailService emailSrv, ISmsService smsService) {
        _emailService = emailSrv;
        _smsService = smsService;
    }

    void DoMagic(string message) {
        _emailService.Send(message);
        _smsService.Send(message);
    }
}
```

----

```csharp
class Rectangle {
    // ...
    int width;
    int height;

    void Draw() {
        // draw to output device
    }

    int CalculateArea() => width * height;
}
```

```csharp
class GeometricRectangle {
    // ...
    int width;
    int height;

    int CalculateArea() => width * height;
}

class Rectangle {
    void Draw() {
        // draw to output device
    }
}
```

---

### Open/Close Principle

> Software entities ... should be open for extension, but closed for modification.

<cite>Bertran Meyer / Robert C. Martin</cite>

----

![ocp1](images/clean-code-01_ocp1.png)

<cite style="font-size: small">From: Agile Principles, Patterns and Practices in C#, Robert C. Martin</cite>

----

![ocp2](images/clean-code-01_ocp2.png)

<cite style="font-size: small">From: Agile Principles, Patterns and Practices in C#, Robert C. Martin</cite>

----

```csharp
class SomeService {
    void DoMagic(string message) {
        _emailService.Send(message);
        _smsService.Send(message);
    }
}
```

```csharp
class SomeServiceBetter {

    private readonly List<IService> _services;

    SomeServiceBetter(List<IService> services) {
        _services = services;
    }

    void DoMagic(string message) {
        for (var service in _services) {
            services.Send(message);
        }
    }
}
```

---

### Liskov Substitution Principle

> Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

<cite>Barbara Liskov</cite>

----

```csharp
class Base {
    virtual int DoSomethingWithNumber(int i) => i;
}

class OtherNotOk : Base {
    override int DoSomethingWithNumber(int i) 
        => i == 42
            ? i
            : throw new Exception();
}

class OtherOk : Base {
    override int DoSomethingWithNumber(int i) => i * 100;
}
```

---

### Interface Segregation Principle

> Many client-specific interfaces are better than one general-purpose interface.

<cite>Robert C. Martin</cite>

----

```csharp
interface IPerson {
    Guid Id { get; set; }
    string FirstName  { get; set; }
    string LastName  { get; set; }
    Address Address  { get; set; }
    List<PersonalDetail> PersonalDetails  { get; set; }
}

class Person : IPerson {
    Guid Id { get; set; }
    string FirstName  { get; set; }
    string LastName  { get; set; }
    Address Address  { get; set; }
    List<PersonalDetail> PersonalDetails  { get; set; }
}
```

- Randnotiz: <!-- .element: class="fragment" data-fragment-index="1" -->
  - this is a **Java Bean** -> pointless <!-- .element: class="fragment" data-fragment-index="1" -->
    - (JEE violates   every aspect of OO, even more than .NET) <!-- .element: class="fragment" data-fragment-index="1" -->
- violates ISP <!-- .element: class="fragment" data-fragment-index="1" -->

----

Einzige Anforderung: Detailansicht der Person.

Robert C. Martin

Also:

```csharp
class Person : IPerson
```

----

```csharp
interface IPersonViewModel {
    Guid Id { get; set; }
    string Name { get; set; }
    string Address { get; set; }
}

class PersonViewModel : IPersonViewModel {
    Guid Id { get; set; }
    string FirstName  { get; set; }
    string LastName  { get; set; }
    Address Address  { get; set; }
}

interface IPersonListViewModel {
    Guid Id { get; set; }
    string Name { get; set; }
}

interface IPersonDetailViewModel {
    Guid Id { get; set; }
    string Name { get; set; }
    string Address { get; set; }
}
```

```csharp
IPersonListViewModel ConvertToListViewModel(Person person) 
    => new PersonListViewModel(person);
IPersonDetailViewModel ConvertToDetailViewModel(Person person) 
    => new PersonDetailViewModel(person);
```

---

### Dependency Inversion Principle

> Depend upon abstractions, not concretions.

<cite>Robert C. Martin</cite>

 ----

 ```csharp
// TODO
 ```
