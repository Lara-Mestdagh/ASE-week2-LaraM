// Create three Course objects with unique IDs, names, and prices per semester.
Course c1 = new Course(1, "Prototyping", 270);
Course c2 = new Course(2, "Team Project", 180);
Course c3 = new Course(3, "Data Science", 230);

// Create two Student objects with names, last names, email addresses, a list of enrolled courses, and dates of birth.
Student s1 = new Student("Lara", "Mestdagh", "mail@gmail.com", new List<Course> { c1 }, "07/02/2002");
Student s2 = new Student("Ava", "PiefPaf", "uhhh@gmail.com", new List<Course> { c1, c3 }, "28/09/2002");

// Display information about the first course and student using its ToString() method.
Console.WriteLine(c1.ToString());
Console.WriteLine(s1.ToString());

// Add the third course (c3) to the list of courses for the first student (s1).
s1.AddCourse(c3);

// Display updated information about the first student.
Console.WriteLine(s1.ToString());
// Calculate and display the total price of the courses in the first student's class group.
Console.WriteLine(s1.TotalPrice());