using BookOfKnowledge.Models.Chapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfKnowledge.RestAPI.DataService
{
    public class ChapterDataService
    {
        private readonly BookOfKnowledge.Service.Chapter.ChapterService _chapterService;

        public ChapterDataService()
        {
            _chapterService = new Service.Chapter.ChapterService();
        }

        public List<Models.Chapter.Chapter> ListChapters()
        {          
            return _chapterService.ListChapters();
        }

        public Models.Chapter.Chapter FindChapterById(int chapterReferenceId)
        {
            return _chapterService.FindChapterById(chapterReferenceId);          
        }

        public Models.Chapter.Chapter CreateChapter(Models.Chapter.Chapter chapter)
        {
            return _chapterService.CreateChapter(chapter);
        }

        public Models.Chapter.Chapter UpdateChapter(int id, Chapter chapter)
        {
            return _chapterService.UpdateChapter(id, chapter);
        }

        public Models.Chapter.Chapter DeleteChapter(int id)
        {
            return _chapterService.DeleteChapter(id);
        }
    }
}
