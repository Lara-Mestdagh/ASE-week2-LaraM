// Define the namespace where the Person class is located.
namespace Howest.MCT.Ex1.Models;
public class Person
{
    // CONSTRUCTORS
    public Person(string name, string lastname)
    {
        Name = name;
        LastName = lastname;
    }

    public Person(string name, string lastname, int age, string address, string email, string phone)
    {
        Name = name;
        LastName = lastname;
        Age = age;
        Address = address;
        Email = email;
        Phone = phone;
    }

    // FUNCTIONS
    // Override the ToString() method 
    public override string ToString()
    {
        return $"Person Information: \n Name: {Name} \n Last Name: {LastName} \n Age: {Age} \n Address: {Address} \n Email: {Email} \n Phone: {Phone}";
    }

    // PROPERTIES
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }   
}