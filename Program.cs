using System;

namespace Assignment05
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    public class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre BookGenre { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01 & Q02 & Q03 & Q04
            Book book = new Book();

            Console.WriteLine(book.copiesInStock);

            book.Title = "Clean Code";
            Console.WriteLine(book.Title);

            book.BookGenre = Genre.Science;
            Console.WriteLine(book.BookGenre);
            #endregion

            #region Q05
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Q06
            int genreNumber = 1;
            Genre g1 = (Genre)genreNumber;
            Console.WriteLine(g1);
            #endregion

            #region Q07
            Genre genre = Genre.Fiction;
            string s = genre.ToString();
            Console.WriteLine(s);
            #endregion

            #region Q08
            string genreText = "Science";
            Genre g2 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(g2);
            #endregion

            #region Q09
            string genreText2 = "Mystery";
            bool isParsed = Enum.TryParse<Genre>(genreText2, true, out Genre g3);
            if (isParsed)
            {
                Console.WriteLine(g3);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}

/*
Q01: Compile error because password is private, so it can only be accessed inside Book class.
Q02: Yes it compiles and prints 5 because copiesInStock is internal, so it is accessible in the same project.
*/