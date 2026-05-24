using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

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

	public void AssignTicket(Ticket ticket)
	{
		_assignedTickets.Add(ticket);
	}
}