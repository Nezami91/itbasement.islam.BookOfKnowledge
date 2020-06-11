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

        public List<string> ListChapters()
        {          
            return _chapterRepository.ListChapters();
        }
        public string FindChapterById(int chapterReferenceId)
        {
            return _chapterRepository.FindChapterById(chapterReferenceId);
        }

    }
}
