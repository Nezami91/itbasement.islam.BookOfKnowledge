using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookOfKnowledge.Models.Chapter;

namespace BookOfKnowledge.DataAccess.Repository
{
   public class ChapterRepository
    {
        private string _labsysConnectionString = "Data Source=EUHMBWS009;Initial Catalog=BookOfKnowledge;Integrated Security=false;User Id = sa; Password = milanax11";

        public List<Models.Chapter.Chapter> ListChapters()
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Chapter_List";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var listOfChaptersFromDatabase =
                    _connection.Query<Models.Chapter.Chapter>(sqlStoredProcedure, CommandType.StoredProcedure).ToList();

                if (listOfChaptersFromDatabase.Any())
                {
                    return listOfChaptersFromDatabase;
                }
            }
            throw new InvalidExpressionException("Nothing from the data base");

        }

        public Models.Chapter.Chapter FindChapterById(int chapterReferenceId)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Chapter_GetById";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var chapterListFromDatabase =
                    _connection.Query<Models.Chapter.Chapter>(sqlStoredProcedure, new { Id = chapterReferenceId }, commandType: CommandType.StoredProcedure).ToList();

                return chapterListFromDatabase.Find(x => x.Id == chapterReferenceId);
            }
        }

        public Models.Chapter.Chapter CreateChapter(Models.Chapter.Chapter chapter)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Chapter_Create";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                _connection.Query<Models.Book.Book>(sqlStoredProcedure,
                    new { Title = chapter.Title, Description = chapter.Description }, commandType: CommandType.StoredProcedure);
            }

            return ListChapters().Find(x => x.Id == chapter.Id);
            //return newBookList.LastOrDefault();
        }


        public Models.Chapter.Chapter UpdateChapter(int id, Models.Chapter.Chapter chapter)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Chapter_Update";

            if (FindChapterById(id) != null)
            {
                using (var _connection = new SqlConnection(_labsysConnectionString))
                {
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure,
                        new { Id = chapter.Id, Title = chapter.Title, Description = chapter.Description }, commandType: CommandType.StoredProcedure);

                    return ListChapters().Find(x => x.Id == id);
                }
            }
            else
            {
                throw new InvalidExpressionException("No Chapter with Id = " + chapter.Id + " was Found");
            }
        }

        public Models.Chapter.Chapter DeleteChapter(int id)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Chapter_Delete";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var chapterDeleted = FindChapterById(id);
                _connection.Query<Models.Chapter.Chapter>
                    (sqlStoredProcedure, new { Id = id }, commandType: CommandType.StoredProcedure);

                return chapterDeleted;
            }
        }

    }
}
