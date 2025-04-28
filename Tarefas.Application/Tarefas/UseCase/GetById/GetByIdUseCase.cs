
using Tarefas.Communication.Responses;

namespace Tarefas.Application.Tarefas.UseCase.GetById;

public class GetByIdUseCase
{
    public ResponseCreatedTarefasJson Execute(int Id) => new ResponseCreatedTarefasJson()
    {
        Id = 1,
        Description = "teste",
        LimitDate = DateTime.Now,
        Name = "teste",
        Priority = 0,
        Status = Communication.Enums.Status.Em_Andamento
    };
}