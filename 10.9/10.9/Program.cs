using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10._9
{
    internal class Program
    {

        static void printStudentLinst(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("hello "+ students[i].getName()+", you learn "+ students[i].getSubject());
                Console.WriteLine("your courses: ");
                students[i].showCourse();
                students[i].showScores();
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //סעיף 3
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello student number "+(1+i));
                Console.WriteLine("Enter yuor name and your subject: ");
                Student s = new Student(Console.ReadLine(), Console.ReadLine());
                s.addCourse();
                Console.WriteLine("Enter the scores of the last 2 tests:");
                for (int j = 0; j < 2; j++) {
                    s.addTest(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
                }
                students.Add(s);
            }
            printStudentLinst(students);

            // סעיף 4
            List<Student> nameStartWith = students.Where(s => s.getName().StartsWith("a")).ToList();
            List<Student> subjectStartWith = students.Where(s => s.getSubject().Equals("teaching")).ToList();
            List<Student> manyCuorses = students.Where(s => s.getAmountOfCourses()>1).ToList();
            List<Student> lowMark = students.Where(s => s.mark56()).ToList();

            Console.WriteLine("Students whose name begins with the letter a:");
            printStudentLinst(nameStartWith);
            Console.WriteLine("Students whose profession is teaching:");
            printStudentLinst(subjectStartWith);
            Console.WriteLine("Students whose number of courses is greater than 1:");
            printStudentLinst(manyCuorses);
            Console.WriteLine("Students who have a score lower than 56:");
            printStudentLinst(lowMark);

        }
        
    }
}
