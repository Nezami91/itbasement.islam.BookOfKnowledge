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
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_GetById";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var bookFromDatabase =
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, new {Id = bookReferenceId},commandType: CommandType.StoredProcedure).ToList();
                                                     
                return bookFromDatabase.Find(x => x.Id == bookReferenceId);                          
            }                              
        }

        public List<Models.Book.Book> DeleteBook(int id)
        {
           string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Delete";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                _connection.Query<Models.Book.Book>
                    (sqlStoredProcedure, new { Id = id }, commandType: CommandType.StoredProcedure);
               
                return ListBooks();
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
