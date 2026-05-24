namespace Domain.ValueObjects;

public record UnitInfo
{
	public int Number { get; init; }
	public int Floor { get; init; }
	public int Bedrooms { get; init; }
	public int Bathrooms { get; init; }
	public float AreaM2 { get; init; }
	public decimal MonthlyRate { get; set; } = 0;
}