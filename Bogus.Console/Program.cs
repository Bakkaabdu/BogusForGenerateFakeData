using Bogus;
using Bogus.Console;
using System;
using System.Text.Json;

public class Program { 
    public static void Main(string[] args)
        {
        var billingDetailsFaker = new Faker<BillingDetails>()
            .RuleFor(u => u.CostumerName, f => f.Name.FullName())
            .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.CostumerName))
            .RuleFor(u => u.AddressLine, f => f.Address.FullAddress())
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.PostCode, f => f.Address.ZipCode())
            .RuleFor(u => u.Country, f => f.Address.Country());

        var text = JsonSerializer.Serialize(billingDetailsFaker.Generate(100000));
        Console.WriteLine(text);
        }


}