using System;

namespace StudentApp
{
    class Program
    {
        class Student
        {
            // Variant 1
            public string fname; // имя
            public string lname; // фамилия
            public string group; // группа

            //Variant2

            public Student (string fname, string lname)
            {
                this.fname = fname;
                this.lname = lname;
                this.group = "JPTVR18";
            }

            //Variant 3
            public Student (string fname, string lname, string group)
            {
                this.fname = fname;
                this.lname = lname;
                this.group = group;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Student: {fname} / {lname}, Group: {group}");
            }
        
        }
        //end class


        static void Main(string[] args)
        {
            //Variant1
            /* Student stud1 = new Student();
             stud1.fname = "Aleksander";
             stud1.lname = "Russovits";
             stud1.group = "JPTVR18";
             */
            //--------------------------------------     

            //Variant2
            /*Student stud1 = new Student("Andrjuha", "Yspeh"); */

            //Variant 3

            Student stud1 = new Student("Andrjuha", "Yspeh", "JPTVR18");

            stud1.GetInfo();
           //--------------------------------------
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
