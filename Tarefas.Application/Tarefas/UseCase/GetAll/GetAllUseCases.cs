
using Tarefas.Communication.Enums;
using Tarefas.Communication.Responses;

namespace Tarefas.Application.Tarefas.UseCase.GetAll;

public class GetAllUseCases
{
    public ResponseGetAllTarefas Execute()
    {
        return new ResponseGetAllTarefas()
        {
            TarefasJsons = new List<ResponseGetShortTarefasJson> {
                new ResponseGetShortTarefasJson
                {
                    Id = 1,
                    Name = "Planejar viagem",
                    Description = "Organizar detalhes da viagem para férias.",
                    Status = Status.Aguardando
                },
                new ResponseGetShortTarefasJson
                {
                    Id = 2,
                    Name = "Comprar presentes",
                    Description = "Comprar presentes para o aniversário da família.",
                    Status = Status.Concluido
                },
                new ResponseGetShortTarefasJson
                {
                    Id = 3,
                    Name = "Estudar para prova",
                    Description = "Revisar os materiais para a prova de matemática.",
                    Status = Status.Em_Andamento
                }

            }
        };
    }
}
        