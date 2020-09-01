using System;

namespace StudentApp2
{
    class Program
    {
        class Student
        {
            public string LastName { get; set;}
            public string FirstName { get; set;}
            public string PersonalID { get; set;}
            public string group { get; set; }

            private int course; //переменная get

            public int Course
            {
                get { return course; }
                set
                {
                    if(value>= 1 && value<=5)
                    {
                        course = value;
                    }
                }
            }

            public string Gender()
            {
                if (PersonalID[0] == '3' || PersonalID[0] == '5')
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }
            }

            public override string ToString()
            {
                return "Student: " + LastName + " " + FirstName + " " + "\n\t\tGroup: "+ group+ "\n\t\tCourse:" 
                    + Course+ "\n\t\t" + "Gender: "+ Gender();
            }

        }


        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.LastName = "Russovits";
            student1.FirstName = "Aleksander";
            student1.PersonalID = "50206213737";
            student1.group = "JPTVR18";
            student1.Course = 3;
            Console.WriteLine(student1);
            //------------------------------------------
            Student student2 = new Student();
            student2.LastName = "Fedoseyeva";
            student2.FirstName = "Jelizaveta";
            student2.PersonalID = "60308144587";
            student2.group = "JPLBR19";
            student2.Course = 2;
            Console.WriteLine(student2);


            Console.Write("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
