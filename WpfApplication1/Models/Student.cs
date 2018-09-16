using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Helper;

namespace WpfApplication1.Models
{
    
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public Gender Gender { get; set; }
        public string Standard { get; set; }
    }
}
