using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEFCodeFirstCont.Models
{
    //Data Annotations
    [Table("Instructor")]
    public class Instructor
    {
        [Key]//Primary Key + identity
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]//not identity
        public int Ins_Id { get; set; }
        [Required] //Not Null
        [StringLength(50)]
        public string Name { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        [Range(1200,9000)]
        public decimal? Salary { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [EmailAddress]//useless in ef core
        [StringLength(50)]
        public string? Email { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        //course has many instructors
        //and instructor has many courses 
        //the entity framework will create 3rd table between them automatically
        public virtual ICollection<Course> Courses { get; set; }
        = new HashSet<Course>();

        [NotMapped]//not create in db
        public DateTime? RegisterTime { get; } = DateTime.Now;
    }
}
