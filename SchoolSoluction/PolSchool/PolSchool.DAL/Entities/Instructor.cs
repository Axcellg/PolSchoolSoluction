
using PolSchool.DAL.core;

namespace PolSchool.DAL.Entities.Base
{
    public partial class Instructor : Person
    {
        public int Id { get; set; }
        public DateTime? HireDate { get; set; }

    }
}
