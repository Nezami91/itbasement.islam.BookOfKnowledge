using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookOfKnowledge.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        // GET: api/Chapter
        [HttpGet]
        public IEnumerable<Models.Chapter.Chapter> Get()
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().ListChapters();        
        }

        // GET: api/Chapter/5
        [HttpGet("{id}", Name = "GetChapter")]
        public Models.Chapter.Chapter Get(int id)
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().FindChapterById(id);
        }

        // POST: api/Chapter
        [HttpPost]
        public Models.Chapter.Chapter Post([FromBody] Models.Chapter.Chapter chapter)
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().CreateChapter(chapter);
        }

        // PUT: api/Chapter/5
        [HttpPut("{id}")]
        public Models.Chapter.Chapter Put(int id, [FromBody] Models.Chapter.Chapter chapter)
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().UpdateChapter(id, chapter);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Models.Chapter.Chapter Delete(int id)
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().DeleteChapter(id);
        }
    }
}
