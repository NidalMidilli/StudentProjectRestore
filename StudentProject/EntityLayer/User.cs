using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [StringLength(30)]
        public string userName { get; set; }
        [StringLength(30)]
        public string password { get; set; }
        public string Yetki { get; set; }
    }
}
