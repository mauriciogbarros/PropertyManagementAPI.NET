using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Technician : User
{
	public UserInfo Info { get; set; } = default!;
	public Property Property { get; set; } = default!;
	public ICollection<TechnicianCapability> Capabilities { get; set; } = [];
	public DateTime HireDate { get; init; } = DateTime.UtcNow;
	public DateTime? TerminationDate { get; set; }

	public decimal HourlyRate { get; set; } = 0;

	public Technician()
	{
		Role = UserRole.Technician;
	}
}