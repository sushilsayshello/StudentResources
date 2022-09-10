using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResources.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseUnits { get; set; }
        public int UnitId { get; set; }
        public string UnitSpecification { get; set; }
        public int UnitTeacherId { get; set; }
        public string TeacherName { get; set; }
        public bool Approval { get; set; }
    }
}
