using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.Results;

namespace Domain.Entities;

public sealed class Technician : Staff
{
	private readonly List<Ticket> _assignedTickets = [];

	public required ICollection<TechnicianCapability> Capabilities { get; set; } = [];
	public IReadOnlyCollection<Ticket> AssignedTickets => _assignedTickets.AsReadOnly();

	public Technician()
	{
		Role = UserRole.Technician;
	}

	public void AddCapability(TechnicianCapability capability)
	{
		Capabilities.Add(capability);
	}

	public Result AssignTicket(Ticket ticket)
	{
		if (ticket is null)
			return Result.Failure(
				new Error("Technician.TicketNull", "Ticket cannot be null.")
			);

		if (_assignedTickets.Any(t => t.Id == ticket.Id))
			return Result.Failure(
				new Error("Technician.TicketAlreadyAssigned", "Ticket has already been assigned to this technician.")
			);

		_assignedTickets.Add(ticket);

		return Result.Success();
	}
}