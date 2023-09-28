Course c1 = new Course(1, "Prototyping", 270);
Course c2 = new Course(2, "Team Project", 180);
Course c3 = new Course(3, "Data Science", 230);

Student s1 = new Student("Lara", "Mestdagh", "mail@gmail.com", new List<Course> { c1 }, "07/02/2002");
Student s2 = new Student("Ava", "PiefPaf", "uhhh@gmail.com", new List<Course> { c1, c3 }, "28/09/2002");

Console.WriteLine(c1.ToString());
Console.WriteLine(s1.ToString());

s1.AddCourse(c3);

Console.WriteLine(s1.ToString());

Console.WriteLine(s1.TotalPrice());