using System;
using System.Collections.Generic;
using System.Text;
namespace CSharpNuGetProject
{
    class RainbowSchool
    {
        
        
        
        public static void Do()
        {
            String ans; ;
            Console.WriteLine("==============Welcome To RainbowSchool=================");
            do
            {
                Console.WriteLine("Choose Options");
                Console.WriteLine("1.Add Student\n2.Add Teacher\n3.Add Subject\n4.Display Students List\n5.Display Teachers List\n6.Display Subjects List\n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("=======Adding Student Data=========");
                        StudentDo.AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("=======Adding Teacher Data=========");
                        TeacherDo.AddTeacher();
                        break;
                    case 3:
                        Console.WriteLine("=======Adding Subject Data=========");
                        SubjectDo.AddSubject();
                        break;
                    case 4:
                        Console.WriteLine("=======Students List=========");
                        List<Student> studs = StudentDo.GetStudentList();
                        if(studs.Count==0)
                            Console.WriteLine("No data");
                        else
                        foreach(Student s in studs)
                            Console.WriteLine("Name of the student: "+s.GetName()+"\t Class And Section: "+s.GetClassAndSection());
                        break;
                    case 5:
                        Console.WriteLine("=======Teachers List=========");
                        List<Teacher> teachs = TeacherDo.GetTeacherList();
                        if (teachs.Count == 0)
                            Console.WriteLine("No data");
                        else
                            foreach (Teacher s in teachs)
                            Console.WriteLine("Name of the teacher: " + s.GetName() + "\t Class And Section: " + s.GetClassAndSection());
                        break;
                    case 6:
                        Console.WriteLine("=======Subjects List=========");
                        List<Subject>subjs  = SubjectDo.GetSubjectList();
                        if (subjs.Count == 0)
                            Console.WriteLine("No data");
                        else
                            foreach (Subject s in subjs)
                            Console.WriteLine("Name of the subject: " + s.GetName() + "\t Class And Section: " + s.GetSubjectCode());
                        break;
                    default: Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Want to continue?(Type yes/no)");
                ans = Console.ReadLine();
            } while(ans.Equals("yes"));
            
        }
        
       
        
       
    }
}
