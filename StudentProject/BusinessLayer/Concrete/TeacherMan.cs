using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeacherMan : ITeacherService
    {
        ITeacherDAL teacherdal;
        public int AddTeacher(Teacher t)
        {
            return teacherdal.Add(t);
        }

        public int DeleteTeacher(Teacher t)
        {
            return teacherdal.Delete(t);
        }

        public Teacher GetById(int id)
        {
            return teacherdal.GetById(id);
        }


        public List<Teacher> ListAllTeachers(Expression<Func<Teacher, bool>> filter=null)
        {
            return teacherdal.ListAll();
        }

        public int UpdateTeacher(Teacher t)
        {
            return teacherdal.Update(t);
        }
    }
}
