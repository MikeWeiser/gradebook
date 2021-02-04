using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;  // no modifier is 'private'
        private string name;

        public Book(string name)  // 'public' is an access modifier
        {
            grades = new List<double>();
            this.name = name;  // 'this' is an implicit variable to refer to object currently being operated on
                  
        }


        public void AddGrade(double grade) 
        {
            // implementation for AddGrade
            // validation for input, like 0 - 100 
            grades.Add(grade);
            
        }
    }
}