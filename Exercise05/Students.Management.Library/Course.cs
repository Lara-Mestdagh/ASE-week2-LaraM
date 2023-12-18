namespace MCT.Ex4.Models.Course;
public class Course
{
    // CONSTRUCTORS
    public Course(int id, string name, int pricepersemester)
    {
        ID = id;
        Name = name;
        PricePerSemester = pricepersemester;
    }

    // FUNCTIONS
    // Override the ToString() method 
    public override string ToString()
    {
        // Build a string representation of the person's information
        var info = "Course Information:\n";
        info += $"ID: {ID}\n";
        info += $"Name: {Name}\n";
        info += $"Price/Semester: {PricePerSemester}\n";

        return info;
    }

    // PROPERTIES
    public int ID { get; set; }
    public string Name { get; set; }
    public int PricePerSemester { get; set; }

}