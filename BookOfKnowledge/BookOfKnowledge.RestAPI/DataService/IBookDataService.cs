using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfKnowledge.RestAPI.DataService
{
    public interface IBookDataService
    {

        List<Models.Book.Book> ListBooks();
        Models.Book.Book FindBookById(int bookReferenceId);

        Models.Book.Book DeleteBook(int id);

        Models.Book.Book CreateBook(Models.Book.Book book);

        Models.Book.Book UpdateBook(int id, Models.Book.Book book);




    }
}
