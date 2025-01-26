using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEFCodeFirstCont.Models
{
    //make EF model Creation via Fluent API
    //override onmodelcreation inside EF Runtime class [EF Context]
    //ADD microsoft entittyframeworkcore.sqlserver package
    ////// POCO class => Plain Old CLR Object
    public class Course
    {
        public int Crs_Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string Course_Desc { get; set; }

        //course has many instructors
        //and instructor has many courses 
        //the entity framework will create 3rd table between them automatically
        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();


        public DateTime? RegisterTime { get; } = DateTime.Now;


    }
}
