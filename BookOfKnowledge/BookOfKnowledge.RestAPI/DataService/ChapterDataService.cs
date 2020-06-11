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

        public List<string> ListChapters()
        {          
            return _chapterService.ListChapters();
        }

        public string FindChapterById(int chapterReferenceId)
        {
            return _chapterService.FindChapterById(chapterReferenceId);          
        }
    }
}
