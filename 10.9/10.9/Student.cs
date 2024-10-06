using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._9
{
    internal class Student
    {
        private String name;
        private String subject;
        private List<String> courses;
        private Dictionary<String, int> tests;

        public Student(String name, String subject)
        {
            this.name = name;
            this.subject = subject;
            courses = new List<string>();
            tests = new Dictionary<String, int>();
        }
        public String getName() {  return name; }
        public String getSubject() { return subject; }
        public int getAmountOfCourses() { return courses.Count; }
        public Boolean mark56()
        {
            foreach (var item in tests.Values)
            {
                if (item < 56)
                    return true;
            }
            return false;
        }

        //סעיף 1
        public void showCourse()
        {
            foreach (String item in courses)
            {
                Console.WriteLine(item+" "); 
            }
        }

        
        public void addCourse()
        {
            Console.WriteLine(name+" enter the name of the course");
            String input =    Console.ReadLine();
            while (!input.Equals("0"))
            {
                courses.Add(input);
                Console.WriteLine("Enter the name of the course");
                input = Console.ReadLine();
                
            }
          
            Console.WriteLine("The courses were successfully taken");
            
        }   
        

        //סעיף 2
        public void addTest(String subject,int mark)
        {
            tests.Add(subject,mark);
        }

        public void showScores()
        {
            Console.WriteLine("hellow "+name+" your marks in your tests: ");
            foreach (var test in tests)
            {
                Console.WriteLine("subject :" +test.Key+" ,your mark: "+ test.Value);
            }
        }

    }
}
