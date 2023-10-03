using System.Text.Json;
using System.Text.Json.Serialization;

CustomerInfo customer =
    JsonSerializer.Deserialize<CustomerInfo>("""{"Name":"John Doe","Company":{"Name":"Contoso"}}""")!;
CustomerInfoNoPopulate customerNoPopulate =
    JsonSerializer.Deserialize<CustomerInfoNoPopulate>("""{"Name":"John Doe","Company":{"Name":"Contoso"}}""")!;

Console.WriteLine("Customer without populate attribute");
Console.WriteLine(JsonSerializer.Serialize(customerNoPopulate));

Console.WriteLine("\nCustomer with populate attribute");
Console.WriteLine(JsonSerializer.Serialize(customer));

Console.ReadLine();

class CompanyInfo
{
    public required string Name { get; set; }
    public string? PhoneNumber { get; set; }
}

[JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
class CustomerInfo
{
    // Both of these properties are read-only.
    public string Name { get; } = "Anonymous";
    public CompanyInfo Company { get; } = new() { Name = "N/A", PhoneNumber = "N/A" };
}

class CustomerInfoNoPopulate
{
    // Both of these properties are read-only.
    public string Name { get; } = "Anonymous";
    public CompanyInfo Company { get; } = new() { Name = "N/A", PhoneNumber = "N/A" };
}