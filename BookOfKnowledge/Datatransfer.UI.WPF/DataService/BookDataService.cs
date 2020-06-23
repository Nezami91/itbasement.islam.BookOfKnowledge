using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatransfer.UI.WPF.DataService
{
   public  class BookDataService
    {

        BookOfKnowledge.Service.Book.BookService bookService = new BookOfKnowledge.Service.Book.BookService();
       
        public List<BookOfKnowledge.Models.Book.Book> ListBook()
        {
            return bookService.ListBooks();
        }
        public BookOfKnowledge.Models.Book.Book FindBookById(int bookReferenceId)
        {
            return bookService.FindBookById(bookReferenceId);
        }
        public void DeleteBook(int id)
        {
            bookService.DeleteBook(id);
        }

        public BookOfKnowledge.Models.Book.Book CreateBook(BookOfKnowledge.Models.Book.Book book)
        {
            return bookService.CreateBook(book);
        }
        public BookOfKnowledge.Models.Book.Book UpdateBook(int id, BookOfKnowledge.Models.Book.Book book)
        {
            return bookService.UpdateBook(id, book);
        }


    }

   
}
