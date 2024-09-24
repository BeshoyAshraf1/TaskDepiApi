using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Phone { get; set; }
        public double Grade { get; set; }
        public List<string> Courses { get; set; }
    }
}
