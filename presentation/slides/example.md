
```csharp
class SomeService {
    void SomeServiceMethod(string message) {
        var emailService = new EmailService { Credentials = "bar" };
        emailService.Send(message);

        var smsService = new SmsService { Credentials = "foo" };
        smsService.Send(message);
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

    void SomeServiceMethod(string message) {
        _emailService.Send(message);
        _smsService.Send(message);
    }
}
```
