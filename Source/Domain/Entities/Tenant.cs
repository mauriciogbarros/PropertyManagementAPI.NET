using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Tenant : User
{
	private DateTimeOffset? _movedOut = null;

	public Unit? Unit { get; set; } = null;
	public required DateTimeOffset MovedIn { get; init; } = DateTime.UtcNow;
	public DateTimeOffset? MovedOut
	{
		get => _movedOut;
		set
		{
			if (MovedOut <= MovedIn)
				throw new ArgumentException("Move out date must be greater than move in date", nameof(MovedOut));

			_movedOut = MovedOut;
		}
	}

	public Tenant()
	{
		Role = UserRole.Tenant;
	}
}