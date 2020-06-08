using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.DataAccess.Repository
{
    public class BookRepository
    {


        public List<string> ListBooks()
        {
            var listOfBooks = new List<string>();


            listOfBooks.Add("Book Of Salah");
            listOfBooks.Add("Book Of Imaan");
            listOfBooks.Add("Book Of ISlam");

            return listOfBooks;

        }


        public string FindBookById(int bookReferenceId)
        {
            var listOfBooks = new List<string>();


            listOfBooks.Add("Book Of Salah");
            listOfBooks.Add("Book Of Imaan");
            listOfBooks.Add("Book Of ISlam");

            var bookFound = listOfBooks.Where(s => s.Contains("Book Of Salah")).FirstOrDefault();

            return bookFound;

        }


    }
}
