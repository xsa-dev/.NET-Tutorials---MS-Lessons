using System;
using System.Collections.Generic;

//This is for Lesson 13

namespace Cource {

class Cource {
    public List<Student> list = new List<Student>();

    public void writeStudentName() {
        foreach (Student st in list) {
            Console.WriteLine(st.FullName);
        }
    }

    public void writeRoostedName() {
        foreach (Student st in list) {
            Console.WriteLine(st.RosterName);
        }
    }
}

public class Person
{
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;
    }

    protected string FirstName { get; private set; }
    protected string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }

    public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }
    
    public bool IsAnAdult()
    {
        var eighteenYearsAgo = DateTime.Today.AddYears(-18);
        return this.DateOfBirth < eighteenYearsAgo;
    }
}

public class Student : Person
{
    public Student (string firstName, string lastName, DateTime dateOfBirth)
        : base(firstName, lastName, dateOfBirth)
    { }
    public string SchoolName { get; set; }

    public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
}}