
namespace PolSchool.DAL.Entities.Base
{
    public abstract class Instructor : Person
    {
        public int Id { get; set; }
        public string? HireDate { get; set; }

    }
}
