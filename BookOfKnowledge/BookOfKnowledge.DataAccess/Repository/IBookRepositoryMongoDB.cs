using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.DataAccess.Repository
{
    public interface IBookRepositoryMongoDB
    {
        List<BookOfKnowledge.Models.Book.Book> ListBooks();
        Models.Book.Book FindBookById(int bookReferenceId);
        Models.Book.Book CreateBook(Models.Book.Book book);
        Models.Book.Book UpdateBook(int id, Models.Book.Book book);
        Models.Book.Book DeleteBook(int id);
    }
}
