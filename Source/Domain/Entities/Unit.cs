using Domain.Entities.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Unit : BaseEntity
{
	public UnitInfo UnitInfo { get; set; } = default!;
	public Property Property { get; init; } = default!;
	public Tenant? Tenant { get; set; } = null;
	public ICollection<Ticket> Tickets { get; set; } = [];
}