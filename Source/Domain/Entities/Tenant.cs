using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Tenant : User
{
	public UserInfo Info { get; set; } = default!;
	public Unit? Unit { get; set; } = null;
	public DateTime MovedIn { get; init; } = DateTime.UtcNow;
	public DateTime? MovedOut { get; set; } = null;

	public Tenant()
	{
		Role = UserRole.Tenant;
	}
}