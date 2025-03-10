using System;

/// <summary>
/// Represents a Student with an ID, program, and registration date.
/// </summary>
public class Student
{
    /// <summary>
    /// Unique student ID (used for hashing).
    /// </summary>
    public int StudentID { get; set; }

    /// <summary>
    /// Program in which the student is enrolled.
    /// </summary>
    public string Program { get; set; }

    /// <summary>
    /// Date when student registered.
    /// </summary>
    public DateTime DateRegister { get; set; }

    /// <summary>
    /// Overrides Equals() to compare two Student objects based on StudentID.
    /// </summary>
    /// <param name="obj">The object to compare.</param>
    /// <returns>True if the objects have the same StudentID; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj is Student otherStudent)
        {
            return this.StudentID == otherStudent.StudentID;
        }
        return false;
    }

    /// <summary>
    /// Overrides the == operator to compare two Student objects.
    /// </summary>
    /// <param name="s1">First student.</param>
    /// <param name="s2">Second student.</param>
    /// <returns>True if both students have the same StudentID.</returns>
    public static bool operator ==(Student s1, Student s2)
    {
        if (s1 is null) return s2 is null;
        return s1.Equals(s2);
    }

    /// <summary>
    /// Overrides the != operator to compare two Student objects.
    /// </summary>
    /// <param name="s1">First student.</param>
    /// <param name="s2">Second student.</param>
    /// <returns>True if the students have different StudentIDs.</returns>
    public static bool operator !=(Student s1, Student s2)
    {
        return !(s1 == s2);
    }

    /// <summary>
    /// Overrides GetHashCode() to generate a hash based on StudentID.
    /// </summary>
    /// <returns>The hash code for the student.</returns>
    public override int GetHashCode()
    {
        return StudentID.GetHashCode();
    }
}
