using IncidentBoard.Core.Primitives;

namespace IncidentBoard.Core.Entities;
public class Coordinate : BaseEntity
{
	public Coordinate(float longitude, float laitude)
	{
		Longitude = longitude;
		Laitude = laitude;
	}

	public float Longitude { get; private set; }
	public float Laitude { get; private set; }
}

