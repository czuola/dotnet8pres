using Microsoft.Extensions.Options;

ValidateOptionsResultBuilder builder = new();
builder.AddError("Error: invalid operation code");
builder.AddResult(ValidateOptionsResult.Fail("Invalid request parameters"));
builder.AddError("Malformed link", "Url");

// Build ValidateOptionsResult object has accumulating multiple errors.
ValidateOptionsResult result = builder.Build();

Console.WriteLine(result.FailureMessage);
Console.ReadLine();
// Reset the builder to allow using it in new validation operation.
builder.Clear();