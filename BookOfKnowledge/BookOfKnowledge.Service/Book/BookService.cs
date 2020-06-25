using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BookOfKnowledge.Service.Book
{
    public class BookService : IBookService
    {
       
        private readonly BookOfKnowledge.DataAccess.Repository.BookRepositoryMongoDB _bookRepository;
        public BookService()
        {
            _bookRepository = new BookOfKnowledge.DataAccess.Repository.BookRepositoryMongoDB();
        }
        public List<Models.Book.Book> ListBooks()
        {
            return _bookRepository.ListBooks();
        }
        public Models.Book.Book FindBookById(int bookReferenceId)
        {
            return _bookRepository.FindBookById(bookReferenceId);
        }
        public Models.Book.Book DeleteBook( int id)
        {
            return _bookRepository.DeleteBook(id);
        }

        public Models.Book.Book CreateBook(Models.Book.Book book)
        {
            return _bookRepository.CreateBook(book);
        }
        public Models.Book.Book UpdateBook(int id, Models.Book.Book book)
        {
            return _bookRepository.UpdateBook(id, book);
        }
    }
}
