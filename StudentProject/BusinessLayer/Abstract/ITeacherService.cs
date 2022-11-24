using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        public int AddTeacher(Teacher t);

        public int UpdateTeacher(Teacher t);

        public int DeleteTeacher(Teacher t);

        List<Teacher> ListAllTeachers(Expression<Func<Teacher, bool>> filter=null);
        Teacher GetById(int id);
     
        
    }
}
