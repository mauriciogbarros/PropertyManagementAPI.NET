using Domain.Entities.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Unit : BaseEntity
{
	private ICollection<Ticket> _tickets = [];

	public required UnitInfo UnitInfo { get; set; }
	public required Property Property { get; init; }
	public Tenant? Tenant { get; set; } = null;
	public ICollection<Ticket> Tickets
	{
		get => _tickets;
	}

	public void AddTicket(Ticket ticket)
	{
		_tickets.Add(ticket);
	}
}