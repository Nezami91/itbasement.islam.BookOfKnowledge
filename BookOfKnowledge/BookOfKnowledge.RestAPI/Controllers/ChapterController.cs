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
        public IEnumerable<string> Get()
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().ListChapters();        
        }

        // GET: api/Chapter/5
        [HttpGet("{id}", Name = "GetChapter")]
        public string Get(int id)
        {
            return new BookOfKnowledge.RestAPI.DataService.ChapterDataService().FindChapterById(id);
        }

        // POST: api/Chapter
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Chapter/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
