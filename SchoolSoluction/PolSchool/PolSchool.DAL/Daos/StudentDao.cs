using PolSchool.DAL.Context;
using PolSchool.DAL.Interfaces;
using PolSchool.DAL.Models;

namespace PolSchool.DAL.Daos
{
    public class StudentDao: InterStudentDao
    {
        private readonly  SchoolDbContext schoolDb;
        
        public StudentDao(SchoolDbContext schoolDb)
        {
            this.schoolDb = schoolDb;
        }

        public ModelStudent ;
    }
}
