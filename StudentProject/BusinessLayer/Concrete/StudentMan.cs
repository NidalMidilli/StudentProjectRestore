using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentMan:IStudentService
    {
        IStudentDAL studentdal;
        Student student;

        public StudentMan(IStudentDAL studentdal)
        {
            this.studentdal = studentdal;
        }

        public int AddStudent(Student s)
        {
            return studentdal.Add(s);
        }

        public int DeleteStudent(Student s)
        {
            return studentdal.Delete(s);
        }


        public Student GetById(int id)
        {
            return studentdal.GetById(id);
        }

       

        public List<Student> ListAllStudents(Expression<Func<Student, bool>> filter=null)
        {
            return studentdal.ListAll();
        }

     

        public int UpdateStudent(Student s)
        {
            return studentdal.Update(s);
        }

      
    }
}
