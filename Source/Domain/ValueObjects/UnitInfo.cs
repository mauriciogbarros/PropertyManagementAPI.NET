using Domain.Results;

namespace Domain.ValueObjects;

public record UnitInfo
{
	public int Number { get; init; }
	public int Floor { get; init; }
	public int Bedrooms { get; init; }
	public int Bathrooms { get; init; }
	public float AreaM2 { get; init; }
	public decimal MonthlyRate { get; set; } = 0;

	private UnitInfo(
		int number,
		int floor,
		int bedrooms,
		int bathrooms,
		float areaM2,
		decimal monthlyRate
	)
	{
		Number = number;
		Floor = floor;
		Bedrooms = bedrooms;
		Bathrooms = bathrooms;
		AreaM2 = areaM2;
		MonthlyRate = monthlyRate;
	}

	public static Result<UnitInfo> Create(
		int number,
		int floor,
		int bedrooms,
		int bathrooms,
		float areaM2,
		decimal monthlyRate
	)
	{
		if (number <= 0)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.NumberLessThanOrEqualToZero", "Number must be greater than 0")
			);
		if (floor < 0)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.FloorLessThanZero", "Floor must be greater than or equal to 0")
			);
		if (bedrooms < 0)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.BedroomsLessThanZero", "Bedrooms must be greater than or equal to 0")
			);
		if (bathrooms < 1)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.BathroomsLessThanOne", "Bathrooms must be greater than 0")
			);
		if (areaM2 < 0)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.AreaLessThanZero", "Area must be greater than 0 m2")
			);
		if (monthlyRate <= 0)
			return Result.Failure<UnitInfo>(
				new Error("UnitInfo.MonthlyRateLessThanOrEqualToZero", "Monthly must be greater than or equal to $0.00")
			);

		return Result.Success(
			new UnitInfo(number, floor, bedrooms, bathrooms, areaM2, monthlyRate)
		);
	}
}