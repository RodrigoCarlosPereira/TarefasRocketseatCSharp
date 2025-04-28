using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.Tarefas.UseCase.CreateTarefas;
using Tarefas.Application.Tarefas.UseCase.Delete;
using Tarefas.Application.Tarefas.UseCase.GetAll;
using Tarefas.Application.Tarefas.UseCase.GetById;
using Tarefas.Application.Tarefas.UseCase.Update;
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

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(ResponseCreatedTarefasJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int Id)
        {
            var response = new GetByIdUseCase().Execute(Id);
            return Ok(response);
        }
        [HttpPut]
        [Route("{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int Id, [FromBody] RequestCreateTarefaJson request){

            new UpdateUseCase().Execute(Id, request);
            return NoContent();
        }
        [HttpDelete]
        [Route("{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Delete([FromRoute] int Id)
        {
            new DeleteUseCase().Execute(Id);
            return NoContent();
        }

    }
}
