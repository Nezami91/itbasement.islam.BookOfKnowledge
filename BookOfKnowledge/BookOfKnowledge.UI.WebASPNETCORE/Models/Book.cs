using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfKnowledge.UI.WebASPNETCORE.Models
{
    public class Book : BookOfKnowledge.Service.Book.IBookService
    {
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }


        private readonly BookOfKnowledge.Service.Book.BookService _bookService;

        public BookOfKnowledge.Models.Book.Book CreateBook(BookOfKnowledge.Models.Book.Book book)
        {
            return _bookService.CreateBook(book);
        }

        public BookOfKnowledge.Models.Book.Book DeleteBook(int id)
        {
            return _bookService.DeleteBook(id);
        }

        public BookOfKnowledge.Models.Book.Book FindBookById(int bookReferenceId)
        {
            return _bookService.FindBookById(bookReferenceId);
        }

        public List<BookOfKnowledge.Models.Book.Book> ListBooks()
        {
            return _bookService.ListBooks();
        }

        public BookOfKnowledge.Models.Book.Book UpdateBook(int id, BookOfKnowledge.Models.Book.Book book)
        {
            return _bookService.UpdateBook(id, book);
        }
    }
}
