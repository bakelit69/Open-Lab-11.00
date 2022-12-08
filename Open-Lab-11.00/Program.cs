using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        /// <summary>
        /// This List contains book categories
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detske", "romantické", "náučné", "sci-fi", "dobrodružné" };

        /// <summary>
        /// non-parametric constructor
        /// </summary>
        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        /// <summary>
        /// parametric constructor that sets certain values to Title and Pages
        /// </summary>
        public Book(string sTitle, int sPages)
        {
            this.title = sTitle;
            this.pages = sPages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        /// <summary>
        /// parametric constructor thats sets every value in Book
        /// </summary>
        public Book(string sTitle, int sPages, string sCategory, string sAuthor, int sReleaseDate)
        {
            this.title = sTitle;
            this.pages = sPages;
            this.category = sCategory;
            this.author = sAuthor;
            this.releaseDate = sReleaseDate;
        }

        /// <summary>
        /// get/set for Title
        /// </summary>
        public string Title { get { return title; } set { title = value; } }

        /// <summary>
        /// get/set for Pages
        /// </summary>
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = pages = value <= 0 ? 1 : value;
            }
        }

        /// <summary>
        /// get/set for Category
        /// </summary>
        public string Category { set { category = value; } }

        /// <summary>
        /// get/set for Author
        /// </summary>
        public string Author { get { return author; } set { author = value; } }

        /// <summary>
        /// get/set for ReleaseDate
        /// </summary>
        public int ReleaseDate
        {
            get
            {
                return releaseDate;

            }
            set
            {
                releaseDate = releaseDate = value <= 1450 || value >= 2021 ? -1 : value;
            }
        }

        /// <summary>
        /// method that returns customised strings
        /// </summary>
        public override string ToString()
        {
            return String.Format($"\n{title}\n{pages}\n{category}\n{author}\n{releaseDate}\n");
        }
    }
}