using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazorsvr.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string BatchTime { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public string URL { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
