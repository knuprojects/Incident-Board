using IncidentBoard.Core.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentBoard.Core.Entities;

public sealed class Incident : BaseEntity
{
    public Incident(string description, int coordinateId) 
    {
        Description = description;
        CoordinateId = coordinateId;
    }

    public string Description { get; set; }

    [ForeignKey(nameof(CoordinateId))]
    public int CoordinateId { get; set; }

    public Coordinate Coordinate { get; set; }
}

