# aws-sdk-toolkit
Responsible for delivering the minimum requirements for integration with AWS services.

To use the library you will need to initialize it by following the steps below:

* In your application initialization file, the AWS configuration must be referenced:

```csharp
builder.Services
    .AddAwsDefaultSettings(builder.Configuration, builder.Environment);
```