using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public class Student
{
    public int StudentId { get; set; } 
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public string Sex { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string DateOfJoin { get; set; }
    public string ParentName { get; set; }
    public List<Result> Results { get; set; }

    public Student()
    {
        
    }

    public Student(int studentId, string email, string password, string name, DateTime dob, string sex, string address, string phone, string dateOfJoin, string parentName)
    {
        StudentId = studentId;
        Email = email;
        Password = password;
        Name = name;
        DOB = dob;
        Sex = sex;
        Address = address;
        Phone = phone;
        DateOfJoin = dateOfJoin;
        ParentName = parentName;
    }
}