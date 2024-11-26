﻿namespace MusicSchool.Requests.Student;

public class CreateStudentRequest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }
}
