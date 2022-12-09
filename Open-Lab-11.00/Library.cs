using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Library
    {
        private int numberOfBooks;
        private int numberOfStudents;

        private List<string> studentsList = new List<string>();
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        private List<string> booksList = new List<string>();
        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }

        public int NumberOfBooks
        {
            get
            {
                return numberOfBooks;
            }
            set
            {
                numberOfBooks = value;
            }
        }

        public int NumberOfStudents
        {
            get
            {
                return NumberOfStudents;
            }
            set
            {
                numberOfStudents = value;
            }
        }
        public override string ToString()
        {
            return String.Format($"\n{numberOfBooks}\n{NumberOfStudents}\n{booksList}\n{StudentsList}\n");
        }
    }
}    
