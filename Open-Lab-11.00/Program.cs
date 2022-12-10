using Open_Lab_11._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();
            Book ucebnica1 = new Book("SLJ", 163, Book.categoryList[2], "Jožo Ráž", 1999);
            Book ucebnica2 = new Book("MAT", 174, Book.categoryList[2], "Michal Prtko", 2001);
            Book ucebnica3 = new Book("ELE", 666, Book.categoryList[2], "Stanislav Lokaj", 1769);
            Book ucebnica4 = new Book("ANJ", 111, Book.categoryList[2], "Renátka Mäkká", 2015);

            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add(ucebnica1);
            schoolLibrary.BooksList.Add(ucebnica2);
            schoolLibrary.BooksList.Add(ucebnica3);
            schoolLibrary.BooksList.Add(ucebnica4);
            schoolLibrary.NumberOfStudents = 2;
            schoolLibrary.NumberOfBooks = 4;

            Console.WriteLine(schoolLibrary.ToString());
        }
    }
}