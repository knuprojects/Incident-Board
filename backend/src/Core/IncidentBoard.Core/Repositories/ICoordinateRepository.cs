using IncidentBoard.Core.Entities;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("IncidentBoard.Persistence")]
namespace IncidentBoard.Core.Repositories;
internal interface ICoordinateRepository
{
    void Add(Coordinate coordinate);
    Coordinate Get(int id);
}

