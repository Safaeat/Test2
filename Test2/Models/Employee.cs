using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("ID")]
        public int Emp_ID { get; set; }
        [Required]
        [MaxLength(200)]
        [DisplayName("Name")]
        public string Emp_Name { get; set; }
        [Required]
        [DisplayName("Age")]
        public int Emp_Age { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string Emp_Gender { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        public DateTime Emp_DOB { get; set; }
        [Required]
        [DisplayName("Designation")]
        public string Designation { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
