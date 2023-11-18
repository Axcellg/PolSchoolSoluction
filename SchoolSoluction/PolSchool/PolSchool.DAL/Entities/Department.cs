using PolSchool.DAL.core;

namespace PolSchool.DAL.Entities.Base
{
    public class Department : EntityBase
    {

        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int? Administrator { get; set; }

    }
}

