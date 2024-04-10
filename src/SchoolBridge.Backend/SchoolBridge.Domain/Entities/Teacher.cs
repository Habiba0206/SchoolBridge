namespace SchoolBridge.Domain.Entities;

public class Teacher : User
{
    /// <summary>
    /// Gets or sets the unique identifier of teacher's class.
    /// This value is nullable, if teacher has a class, must not be null. 
    /// </summary>
    public Guid? ClassId { get; set; }

    /// <summary>
    /// Gets or sets the value which determines if the teacher has a class.
    /// This value is nullable, because if the user's role is teacher, this user might have class, it's not related to students.
    /// </summary>
    public bool? HasClass { get; set; }

    /// <summary>
    /// Navigation property that stores the class related to this teacher.
    /// </summary>
    public Class? Class { get; set; }

    /// <summary>
    /// Navigation property that stores the subjects related to this teacher.
    /// </summary>
    public List<Subject> Subjects { get; set; }
}
