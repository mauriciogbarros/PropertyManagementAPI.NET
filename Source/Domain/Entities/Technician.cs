using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Technician : Staff
{
	public ICollection<TechnicianCapability> Capabilities { get; set; } = [];
	private readonly List<Ticket> _assignedTickets = [];
	public IReadOnlyCollection<Ticket> AssignedTickets => _assignedTickets.AsReadOnly();

	public Technician()
	{
		Role = UserRole.Technician;
	}

	public void AssignedTicket(Ticket ticket)
	{
		_assignedTickets.Add(ticket);
	}
}