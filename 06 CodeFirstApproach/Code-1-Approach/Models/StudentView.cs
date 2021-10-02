using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_1_Approach.Models
{
    public class StudentView
    {
        public List<Student> getAllRecord()
        {
            StudentContext obj = new StudentContext();
            return obj.students.ToList();

        }
    }
}