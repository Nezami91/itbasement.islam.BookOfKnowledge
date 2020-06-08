using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.DataAccess.Repository
{
    public class BookRepository
    {

        public List<BookOfKnowledge.Models.Book.Book> ListBooks()
        {
            var listOfBooks = new List<BookOfKnowledge.Models.Book.Book>();

            var bookOne = new BookOfKnowledge.Models.Book.Book();
            bookOne.Id = 1;
            bookOne.Title = "Book Of Salah";
            bookOne.Description = " Salhaa...";
            bookOne.Progress = 77;



            listOfBooks.Add(bookOne);

            var bookTwo = new BookOfKnowledge.Models.Book.Book() {
                Id = 1,
                Title = "Book Of Salah",
                Description = " Salhaa...",
                Progress = 77,
            };


            listOfBooks.Add(bookTwo);
       

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
