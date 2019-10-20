using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExcerciseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcerciseController : ControllerBase
    {
        readonly ICRUD<Excercise> _repository;
        public ExcerciseController(ICRUD<Excercise> excerciseRepository)
        {
            this._repository = excerciseRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Excercise> Get(int id)
        {
            return  _repository.Read(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Excercise excercise)
        {
            var id = _repository.Create(excercise);
            return CreatedAtAction(nameof(Post), new { id });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
