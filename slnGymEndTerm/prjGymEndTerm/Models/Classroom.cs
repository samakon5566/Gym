using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Classroom
    {
        public Classroom()
        {
            CourseClasses = new HashSet<CourseClass>();
            Equipment = new HashSet<Equipment>();
        }

        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }
        public int ClassroomAccommodation { get; set; }

        public virtual ICollection<CourseClass> CourseClasses { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
