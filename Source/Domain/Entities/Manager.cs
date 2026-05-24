using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Manager : User
{
	public UserInfo Info { get; set; } = default!;
	public Property Property { get; set; } = default!;
	public DateTime HireDate { get; init; } = DateTime.UtcNow;
	public DateTime? TerminationDate { get; set; }
	public decimal HourlyRate { get; set; } = 0;

	public Manager()
	{
		Role = UserRole.Manager;
	}
}