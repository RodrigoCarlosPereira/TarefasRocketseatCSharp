
using Tarefas.Communication.Enums;

namespace Tarefas.Communication.Responses;

public class ResponseGetShortTarefasJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public Status Status { get; set; }
}