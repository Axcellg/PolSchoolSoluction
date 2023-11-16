namespace PolSchool.DAL.Entities.Base
{
    public abstract class Person : Course
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? HireDate { get; set; }
        public string? EnrollmentDate { get; set; }

    }
}



