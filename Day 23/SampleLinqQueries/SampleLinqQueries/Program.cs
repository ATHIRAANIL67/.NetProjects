using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleLinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = Student.GetStudent();
            Console.WriteLine("Multiple Select and where Operator");
            var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardID > 0)
                              .Select(s => s.StudentName);
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("****************************************************");

            //The following query returns Enumerable of anonymous object that has
            //only StudentName property:
            Console.WriteLine("LINQ Query returns Collection of Anonymous Objects");
            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            Console.WriteLine("****************************************************");


            //The following query returns list students group by StandardID:
            Console.WriteLine("LINQ GroupBy Query");
            var studentsGroupByStandard = from s in studentList
                                          group s by s.StandardID into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };
            foreach (var group in studentsGroupByStandard)
            {
                Console.WriteLine("StandardID {0}:", group.Key);
                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }
            //The output includes Ron who doesn't have any StandardID. So Ron falls under StandardID 0.
            Console.WriteLine("****************************************************");


            //To remove a student who doesn't have a StandardID, use a where operator before the group operator:
            Console.WriteLine("LINQ GroupBy Query");
            var studentsGroupByStandard1 = from s in studentList
                                           where s.StandardID > 0
                                           group s by s.StandardID into sg
                                           orderby sg.Key
                                           select new { sg.Key, sg };

            foreach (var group in studentsGroupByStandard1)
            {
                Console.WriteLine("StandardID {0}:", group.Key);
                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }
            Console.WriteLine("****************************************************");


            //Use left outer join to display students under each standard. Display the
            //standard name even if there is no student assigned to that standard.
            List<Standard> standardList = Standard.GetStandard();
            Console.WriteLine("LINQ Left Outer Join");
            var studentsGroup = from stad in standardList
                                join s in studentList
                                on stad.StandardID equals s.StandardID
                                    into sg
                                select new
                                {
                                    StandardName = stad.StandardName,
                                    Students = sg
                                };

            foreach (var group in studentsGroup)
            {
                Console.WriteLine(group.StandardName);
                group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            }
            Console.WriteLine("****************************************************");


            //In the following example of group by query, we sort the group and select
            //only StudentName:
            Console.WriteLine("LINQ Left Outer Join");
            var studentsWithStandard = from stad in standardList
                                       join s in studentList
                                       on stad.StandardID equals s.StandardID
                                       into sg
                                       from std_grp in sg
                                       orderby stad.StandardName, std_grp.StudentName
                                       select new
                                       {
                                           StudentName = std_grp.StudentName,
                                           StandardName = stad.StandardName
                                       };


            foreach (var group in studentsWithStandard)
            {
                Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
            }
            Console.WriteLine("****************************************************");

            //The following query returns list of students by ascending order of
            //StandardID and Age.
            Console.WriteLine("Sorting");
            var sortedStudents = from s in studentList
                                 orderby s.StandardID, s.Age
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     Age = s.Age,
                                     StandardID = s.StandardID
                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandardID));
            Console.WriteLine("****************************************************");

            //Inner Join
            Console.WriteLine("Inner Join");
            var studentWithStandard = from s in studentList
                                      join stad in standardList
                                      on s.StandardID equals stad.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stad.StandardName
                                      };

            studentWithStandard.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.StudentName, s.StandardName));
            Console.WriteLine("****************************************************");

            //Nested Query
            Console.WriteLine("Nested Query");
            var nestedQueries = from s in studentList
                                where s.Age > 18 && s.StandardID ==
                                    (from std in standardList
                                     where std.StandardName == "Standard 1"
                                     select std.StandardID).FirstOrDefault()
                                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));
        }
    }
}
