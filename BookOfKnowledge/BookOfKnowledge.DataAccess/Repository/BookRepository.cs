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
                var bookListFromDatabase =
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, new {Id = bookReferenceId},commandType: CommandType.StoredProcedure).ToList();
                                                     
                return bookListFromDatabase.Find(x => x.Id == bookReferenceId);                          
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
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Create";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {              
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, 
                        new { Title = book.Title, Description = book.Description}, commandType: CommandType.StoredProcedure);            
            }

            return ListBooks().Find(x => x.Id == book.Id);                
            //return newBookList.LastOrDefault();
        }

        public Models.Book.Book UpdateBook(int id, Models.Book.Book book)
        {        
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Update";
           
            if (FindBookById(id) != null)
            {               
                using (var _connection = new SqlConnection(_labsysConnectionString))
                {
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure,
                        new {Id = book.Id, Title = book.Title, Description = book.Description }, commandType: CommandType.StoredProcedure);
                    
                    return ListBooks().Find(x => x.Id == id);
                }
                          
            }
            else
            {
                throw new InvalidExpressionException("No Book with Id = "+ book.Id+" was Found");
            }
        }
    }
}
