using System.Collections.Generic;
using Core;
using Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExcerciseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcercisesController : ControllerBase
    {
        readonly ICRUD<Excercise> _repository;
        public ExcercisesController(ICRUD<Excercise> excerciseRepository)
        {
            this._repository = excerciseRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Excercise>> GetAll()
        {
            return _repository.Read();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Excercise> GetById(int id)
        {
            return  _repository.Read(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Create([FromBody] Excercise excercise)
        {
            var id = _repository.Create(excercise);
            return CreatedAtAction(nameof(Create), new { id });
        }

        // PUT api/values/5
        [HttpPut]
        public void Update([FromBody] Excercise excercise)
        {
            _repository.Update(excercise);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
