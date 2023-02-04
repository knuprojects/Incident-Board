using IncidentBoard.Core.Entities;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("IncidentBoard.Persistence")]
namespace IncidentBoard.Core.Repositories;

internal interface IIncidentRepository
{
    void Add(Incident incident);
    IEnumerable<Incident> GetAll();
}
