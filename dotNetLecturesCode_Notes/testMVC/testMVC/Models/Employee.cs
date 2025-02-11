using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Salary { get; set; }
        public string? JobTitle { get; set; }
        public string? ImageURL { get; set; }
        public string? Address { get; set; }

        [ForeignKey("Department")]
        [Display(Name="Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
