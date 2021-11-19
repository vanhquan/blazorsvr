using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazorsvr.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string BatchTime { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string Password { get; set; }
    }
}
