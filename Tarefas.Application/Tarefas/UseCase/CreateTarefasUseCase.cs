using Tarefas.Communication.Enums;
using Tarefas.Communication.Requests;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.Tarefas.UseCase;

public class CreateTarefasUseCase
{
    public ResponseCreatedTarefasJson Execute(RequestCreateTarefaJson request)
    {
        return new ResponseCreatedTarefasJson
        {
            Id = 1,
            Name = request.Name,
        };
    }
}