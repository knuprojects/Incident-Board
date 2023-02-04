using System.ComponentModel.DataAnnotations;

namespace IncidentBoard.Core.Primitives;

public abstract class BaseEntity : IEquatable<BaseEntity>
{
    [Key]
    public int Id { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        if (obj.GetType() != GetType()) return false;

        if (obj is not BaseEntity entity) return false;

        return entity.Id == Id;
    }

    public bool Equals(BaseEntity? other)
    {
        if (other is null) return false;

        if (other.GetType() != GetType()) return false;

        return other.Id == Id;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() * 41;
    }
}
