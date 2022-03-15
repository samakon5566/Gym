using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjGymEndTerm.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackWebApiController : ControllerBase
    {
        private readonly GYMContext gym;
        public BackWebApiController( GYMContext context)
        {
            gym = context;
        }

        // GET: api/<BackWebApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BackWebApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BackWebApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BackWebApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BackWebApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Lesson lesson = gym.Lessons.FirstOrDefault(l => l.LessonId == id);

            if (lesson != null)
            {
                gym.Remove(lesson);
                gym.SaveChanges();
            }
        }
    }
}
