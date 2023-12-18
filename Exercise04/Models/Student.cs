// Define the namespace where the Student class is located. Also uses the Course class
namespace MCT.Ex4.Models.Student;
using MCT.Ex4.Models.Course;
public class Student
{
    // CONSTRUCTORS
    public Student(string name, string lastname, string email, List<Course> classgroup, string dateofbirth)
    {
        Name = name;
        LastName = lastname;
        Email = email;
        ClassGroup = classgroup;
        DateOfBirth = dateofbirth;
    }

    // FUNCTIONS
    // Override the ToString() method 
    public override string ToString()
    {
        // Build a string representation of the person's information
        var info = "Student Information:\n";
        info += $"Name: {Name}\n";
        info += $"Last Name: {LastName}\n";
        info += $"Email: {Email}\n";
        foreach (var course in ClassGroup)
        {
            info += $"  - {course.Name}\n";
        }
        info += $"Date of Birth: {DateOfBirth}\n";

        return info;
    }
    // Method to add a course to the student's class group.
    public void AddCourse(Course course)
    {
        if (ClassGroup == null)
        {
            ClassGroup = new List<Course>();
        }

        ClassGroup.Add(course);
    }
    // Method to calculate the total price of the courses in the class group.
    public string TotalPrice()
    {
        int totalPrice = 0;
        foreach (var course in ClassGroup)
        {
            totalPrice += course.PricePerSemester;
        }

        return $"The total price of this students courses is: {totalPrice}";
    }

    // PROPERTIES
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<Course> ClassGroup { get; set; }
    public string DateOfBirth { get; set; }
}