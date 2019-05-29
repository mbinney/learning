using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleLearning
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StudentCourse
    {
        public Course course;
        public Student student;
    }


    public class LinqGroupBy
    { 
        public void main ()
        {

            var studentCourses = BuildStudentCourses();

            var a = studentCourses.GroupBy(x => new { x.course.Name, x.student.Grade })
                .Select(g => new { courseName = g.Key.Name,
                                   grade = g.Key.Grade,
                                   studentcourses = g.ToList()}).ToList();

            foreach (var item in a)
            {
                Console.WriteLine($"{item.courseName} {item.grade}");

                foreach (var ab in item.studentcourses)
                {
                    Console.WriteLine($"{ab.student.FirstName} {ab.student.LastName}");
                }

                Console.WriteLine(Environment.NewLine);
            }
        }

        List<StudentCourse> BuildStudentCourses()
        {
            List<StudentCourse> studentCourses = new List<StudentCourse>()
            {
               new StudentCourse {course = new Course{Name = "Geography"},
                                  student = new Student{ Id = 1,
                                                         FirstName = "Marty",
                                                         LastName = "Binney",
                                                         Grade = "A"}
                                  },
               new StudentCourse {course = new Course{Name = "Geography"},
                                  student = new Student{ Id = 2,
                                                         FirstName = "Jason",
                                                         LastName = "Binney",
                                                         Grade = "A"}
                                  },
                new StudentCourse {course = new Course{Name = "Math"},
                                  student = new Student{ Id = 1,
                                                         FirstName = "Ken",
                                                         LastName = "Green",
                                                         Grade = "A"}
                                  },
               new StudentCourse {course = new Course{Name = "Math"},
                                  student = new Student{ Id = 2,
                                                         FirstName = "Phil",
                                                         LastName = "Stardom",
                                                         Grade = "B"}
                                  },
                new StudentCourse {course = new Course{Name = "Math"},
                                  student = new Student{ Id = 1,
                                                         FirstName = "Alson",
                                                         LastName = "Wood",
                                                         Grade = "A"}
                                  },
               new StudentCourse {course = new Course{Name = "Math"},
                                  student = new Student{ Id = 2,
                                                         FirstName = "Katie",
                                                         LastName = "Perry",
                                                         Grade = "C"}
                                  }


            };

            return studentCourses;
        }
    }
}
