using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.Service.Book
{
    public class BookService
    {
        private readonly BookOfKnowledge.DataAccess.Repository.BookRepository _bookRepository;


        public BookService()
        {
            _bookRepository = new BookOfKnowledge.DataAccess.Repository.BookRepository();
        }

        public List<string> ListBooks()
        {

            return _bookRepository.ListBooks();
        }


        public string FindBookById(int bookReferenceId)
        {

            return _bookRepository.FindBookById(bookReferenceId);
        }










    }
}
