using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        // explicit typing to create a 'field' in this class
        // List<double> grades = new List<double>();

        // another way with to intialize grades List with constructor method
        List<double> grades;
        public Book()
        {
            grades = new List<double>();      
        }


        public void AddGrade(double grade) 
        {
            // implementation for AddGrade
            // validation for input, like 0 - 100 
            grades.Add(grade);
            
        }
    }
}