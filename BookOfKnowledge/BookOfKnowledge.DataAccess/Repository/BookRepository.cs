using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperExtensions;

namespace BookOfKnowledge.DataAccess.Repository
{
    public class BookRepository
    {
        private string _labsysConnectionString = "Data Source=EUHMBWS009;Initial Catalog=BookOfKnowledge;Integrated Security=false;User Id = sa; Password = milanax11";

        public List<BookOfKnowledge.Models.Book.Book> ListBooks()
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_List";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var listOfBooksFromDatabase =
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, CommandType.StoredProcedure).ToList();

                if (listOfBooksFromDatabase.Any())
                {
                    return listOfBooksFromDatabase;
                }

                
            }
          
            throw new InvalidExpressionException("Nothing from the data base");

        }

        public Models.Book.Book FindBookById(int bookReferenceId)
        {
            var listOfBooks = ListBooks();
            
            return listOfBooks.Find(s => s.Id == bookReferenceId);
        }

        public Models.Book.Book DeleteBook(int id)
        {
           
            var bookList = ListBooks();
            var book = bookList.Find(x => x.Id == id); 

            if (bookList.Find(x => x.Id == id) != null)
            {
                bookList.Remove(bookList.Find(x => x.Id == id));
                return book;
            }
            else
            {
                Console.WriteLine("Object not Found");
                return book;                    
            }
           
        }

        public Models.Book.Book CreateBook(Models.Book.Book book)
        {
            // tjeck if a book with the same Title and Description exist

            var bookList = ListBooks();         
            bookList.Add(book);

            var newBookList = ListBooks();
            return newBookList.LastOrDefault();
        }

        public Models.Book.Book UpdateBook(Models.Book.Book book)
        {
            // tjeck if a book with the same Title and Description exist

            var bookList = ListBooks();
            bookList.Add(book);

            var newBookList = ListBooks();
            return newBookList.LastOrDefault();
        }
    }
}
