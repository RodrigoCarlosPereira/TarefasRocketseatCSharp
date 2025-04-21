using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.Tarefas.UseCase;
using Tarefas.Application.Tarefas.UseCase.GetAll;
using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreatedTarefasJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult CreateTarefa([FromBody] RequestCreateTarefaJson request)
        {
            var response = new CreateTarefasUseCase().Execute(request);
            return Created(string.Empty, response);
        }
        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllTarefas), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var response = new GetAllUseCases().Execute();
            return Ok(response);
        }
    }
}
