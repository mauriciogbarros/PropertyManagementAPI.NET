using Domain.Entities.Abstractions;
using Domain.Results;
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

	public Result AddTicket(Ticket ticket)
	{
		if (ticket is null)
			return Result.Failure(
				new Error("Unit.TicketNull", "Ticket cannot be null.")
			);

		if (_tickets.Any(t => t.Id == ticket.Id))
			return Result.Failure(
				new Error("Unit.TicketExists", "Ticket already exists.")
			);

		_tickets.Add(ticket);

		return Result.Success();
	}
}