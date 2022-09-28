using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        // GET: api/<ToDoListController>
        [HttpGet]
        public IEnumerable<ToDoTask> Get()
        {
            return ToDoTask.ReadAll(); //DOUBLE CHECK THIS
        }

        // GET api/<ToDoListController>/5
        [HttpGet("{id}")]
        public ToDoTask Get(int id)
        {
            return ToDoTask.Read(id);
        }

        // POST api/<ToDoListController>
        [HttpPost]
        public void Post([FromBody] string description)
        {
            ToDoTask task = new ToDoTask(description);
            task.Create();
        }

        // PUT api/<ToDoListController>/5
        [HttpPut("{idToFinish}")]
        public void Put(int idToFinish)
        {
            ToDoTask finishedTask = ToDoTask.Read(idToFinish);
            finishedTask.FinishTask();
        }

        // DELETE api/<ToDoListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ToDoTask deletedTask = ToDoTask.Read(id);
            deletedTask.Delete();
        }
    }
}
