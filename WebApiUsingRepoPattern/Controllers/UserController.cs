using Microsoft.AspNetCore.Mvc;
using WebApiUsingRepoPattern.IRepository;
using WebApiUsingRepoPattern.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiUsingRepoPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository _repo;

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            if(_repo.GetUsers().Count() == 0)
                return NotFound();
            else 
            return Ok(_repo.GetUsers());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _repo.GetById(id);
            if(obj == null)
                return NotFound();
            else
                return Ok(obj);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {

            return Created("added", _repo.AddUser(user));
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            _repo.UpdateUser(id, user);
            return Ok();    
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteUser(id);
            return Ok();    
        }
    }
}
