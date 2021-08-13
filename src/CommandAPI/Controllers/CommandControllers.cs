using System.Collections.Generic;
using CommandAPI.Data;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }
    }
}