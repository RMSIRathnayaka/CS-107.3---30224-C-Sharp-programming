using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter exam marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            char grade = DetermineGrade(marks);

            Console.WriteLine($"{name} scored {marks} marks. Grade: {grade}");
        }

        static char DetermineGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
                return 'A';
            else
                return 'F'; // You might want to extend this with more grading criteria

        }
    }
}
