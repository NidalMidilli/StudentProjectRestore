using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }

        [StringLength(30)]
        public string studentName { get; set; }

        [StringLength(30)]
        public string studentSurname { get; set; }

    }
}
