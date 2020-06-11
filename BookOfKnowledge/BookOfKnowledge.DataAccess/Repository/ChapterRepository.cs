using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.DataAccess.Repository
{
   public class ChapterRepository
    {

        public List<string> ListChapters()
        {        
            var listOfChapters = new List<string>();
            listOfChapters.Add("Chapter of Shaadatayn");
            listOfChapters.Add("Chapter of Salah");
            listOfChapters.Add("Chapter of Zakat");
            listOfChapters.Add("Chapter of Siyam");

            return listOfChapters;
        }

        public string FindChapterById(int chapterReferenceId)
        {
            var listOfChapters = new List<string>();
            listOfChapters.Add("Chapter of Shaadatayn");
            listOfChapters.Add("Chapter of Salah");
            listOfChapters.Add("Chapter of Zakat");
            listOfChapters.Add("Chapter of Siyam");
            
            var chapterFound = listOfChapters.Where(s => s.Contains("Chapter Of Salah")).FirstOrDefault();
            return chapterFound;         
        }

    }
}
