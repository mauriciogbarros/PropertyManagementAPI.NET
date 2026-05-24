namespace Domain.ValueObjects;

public record UnitInfo
{
	public int Number { get; init; }
	public int Floor { get; init; }
	public int Bedrooms { get; init; }
	public int Bathrooms { get; init; }
	public float AreaM2 { get; init; }
	public decimal MonthlyRate { get; set; } = 0;

	public UnitInfo(
		int number,
		int floor,
		int bedrooms,
		int bathrooms,
		float areaM2,
		decimal monthlyRate
	)
	{
		if (number < 0)
			throw new ArgumentException("Number must be greater than or equal to 0", nameof(number));
		if (floor < 0)
			throw new ArgumentException("Floor must be greater than or equal to 0", nameof(floor));
		if (bedrooms < 0)
			throw new ArgumentException("Bedrooms must be greater than or equal to 0", nameof(bedrooms));
		if (bathrooms < 1)
			throw new ArgumentException("Bathrooms must be greater than 0", nameof(bathrooms));
		if (areaM2 < 0)
			throw new ArgumentException("Area must be greater than 0 m2", nameof(areaM2));
		if (monthlyRate <= 0)
			throw new ArgumentException("Monthly must be greater than or equal to $0.00", nameof(monthlyRate));

		Number = number;
		Floor = floor;
		Bedrooms = bedrooms;
		Bathrooms = bathrooms;
		AreaM2 = areaM2;
		MonthlyRate = monthlyRate;
	}
}