using System;

namespace lesson12
{

public class Client : Address {
    public string Name;
    public string LastName;

    public Client (string streetAddress, string city, string state, string postalCode, string country, string name, string lastName) {
        Name = name;
        LastName = lastName;
        StreetAddress = streetAddress;
        City = city;
        Country = country;
        PostalCode = postalCode;
        State = state;
    }

} 

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
}