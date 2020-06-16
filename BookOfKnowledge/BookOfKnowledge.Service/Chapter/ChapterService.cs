using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.Service.Chapter
{
    public class ChapterService
    {
        private readonly BookOfKnowledge.DataAccess.Repository.ChapterRepository _chapterRepository;
     
        public ChapterService()
        {
            _chapterRepository = new BookOfKnowledge.DataAccess.Repository.ChapterRepository();
        }

        public List<Models.Chapter.Chapter> ListChapters()
        {          
            return _chapterRepository.ListChapters();
        }
        public Models.Chapter.Chapter FindChapterById(int chapterReferenceId)
        {
            return _chapterRepository.FindChapterById(chapterReferenceId);
        }

        public Models.Chapter.Chapter CreateChapter(Models.Chapter.Chapter chapter)
        {
            return _chapterRepository.CreateChapter(chapter);
        }

        public Models.Chapter.Chapter UpdateChapter(int id, Models.Chapter.Chapter chapter)
        {
            return _chapterRepository.UpdateChapter(id, chapter);
        }

        public Models.Chapter.Chapter DeleteChapter(int id)
        {
            return _chapterRepository.DeleteChapter(id);
        }
    }
}
