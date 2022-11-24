using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        public int AddStudent(Student s);

        public int UpdateStudent(Student s);

        public int DeleteStudent(Student s);

        List<Student> ListAllStudents(Expression<Func<Student, bool>> filter=null);

        Student GetById(int id);
        

        
    }
}
