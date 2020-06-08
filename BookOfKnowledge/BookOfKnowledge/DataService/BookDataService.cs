using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfKnowledge.DataService
{
    public class BookDataService
    {
        private readonly BookOfKnowledge.Service.Book.BookService _bookService ;

        public BookDataService()
        {
            _bookService = new Service.Book.BookService();
        }

        public List<Models.Book.Book> ListBooks()
        {
            var listOfBooks = _bookService.ListBooks();

            return listOfBooks;

        }

        public string FindBookById(int bookReferenceId)
        {
            var listOfBooks = _bookService.FindBookById(bookReferenceId);

            return listOfBooks;

        }

    }
}
