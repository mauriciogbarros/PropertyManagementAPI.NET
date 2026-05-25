using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.Results;

namespace Domain.Entities;

public sealed class Tenant : User
{
	public Unit? Unit { get; set; } = null;
	public required DateTimeOffset MovedIn { get; init; } = DateTime.UtcNow;
	public DateTimeOffset? MovedOut {	get; private set; }

	public Tenant()
	{
		Role = UserRole.Tenant;
	}

	public Result MoveOut(DateTimeOffset moveOutDate)
	{
		if (moveOutDate <= MovedIn)
			return Result.Failure(
				new Error("Tenant.MoveOutBeforeMoveIn", "Move out date must be greater than move in date")
			);

		MovedOut = moveOutDate;

		return Result.Success();
	}
}