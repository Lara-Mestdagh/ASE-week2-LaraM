namespace Howest.MCT.Ex1.Models;
public class Person
{
    // CONSTRUCTORS
    public Person(string name, string lastname)
    {
        Name = name;
        LastName = lastname;
    }

    public Person(string name, string lastname, byte age, List<string> addresses, List<string> emails, List<string> phones)
    {
        Name = name;
        LastName = lastname;
        Age = age;
        Addresses = addresses;
        EmailAddresses = emails;
        PhoneNumbers = phones;
    }

    // FUNCTIONS
    public override string ToString()
    {
        // Build a string representation of the person's information
        var info = "Person Information:\n";
        info += $"Name: {Name}\n";
        info += $"Last Name: {LastName}\n";
        info += $"Age: {Age}\n";
        info += "Addresses:\n";
        foreach (var address in Addresses)
        {
            info += $"  - {address}\n";
        }
        info += "Email Addresses:\n";
        foreach (var email in EmailAddresses)
        {
            info += $"  - {email}\n";
        }
        info += "Phone Numbers:\n";
        foreach (var phone in PhoneNumbers)
        {
            info += $"  - {phone}\n";
        }

        return info;
    }

    // PROPERTIES
    public string Name { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public List<string> Addresses { get; set; }
    public List<string> EmailAddresses  { get; set; }
    public List<string> PhoneNumbers  { get; set; }
    
}