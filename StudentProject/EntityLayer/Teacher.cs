using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Teacher
    {
        [Key]
        public int teacherId { get; set; }

        [StringLength(30)]
        public string teacherName { get; set; }

        [StringLength(30)]
        public string teacherSurname { get; set; }


    }
}
