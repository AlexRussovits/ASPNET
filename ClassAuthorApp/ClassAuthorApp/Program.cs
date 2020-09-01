using System;
using System.Linq;

namespace ClassAuthorApp
{
    class Program
    {
        class Author
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public override string ToString()
            {
                return "Author: " + LastName + " " + FirstName;
            }
        }

        static void Main(string[] args)
        {
            //Array authors
            Author[] authors =
            {
                new Author{LastName = "Morrison", FirstName = "Alex" },
                new Author{LastName = "Blake", FirstName = "David"}
            };

            Console.WriteLine("\n\nVariant1. LOOP OPERATOR: FOR ");
            for (int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + authors[i]);
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat("=",20)));
            //----------------------------------------------------------------
            Console.WriteLine("\n\nVariant2. LOOP OPERATOR: FOREACH ");

            int n = 0;

            foreach(Author author in authors)
            {
                n++;
                Console.WriteLine(n + ". "+ author);
            }

            //===============================================LINQ

            Console.WriteLine("\nLinQ");

            var selectedAuthor = from author in authors
                                 where author.FirstName=="Alex"
                                 orderby author.LastName
                                 select author; // Весь массив

            n = 0;

            foreach(Author author in selectedAuthor)
            {
                n++;
                Console.WriteLine(n + ". " + author);
            }




            Console.Write("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
