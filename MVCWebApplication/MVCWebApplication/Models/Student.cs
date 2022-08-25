using System.ComponentModel.DataAnnotations;

namespace MVCWebApplication.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
