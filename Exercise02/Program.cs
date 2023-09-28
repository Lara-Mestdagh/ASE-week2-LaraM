// Create instances of Person with multiple addresses, email addresses, and phone numbers
Person p1 = new Person(
    "John",
    "Doe",
    30,
    new List<string> {"123 Main St, City1, State1, 12345", "456 Elm St, City2, State2, 67890"},
    new List<string> { "john.doe@email.com", "johndoe@gmail.com" },
    new List<string> { "123-456-7890", "987-654-3210" }
);

// Display information for each person
Console.WriteLine(p1.ToString());