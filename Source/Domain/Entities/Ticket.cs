using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Ticket : BaseEntity
{
	public required TicketInfo TicketInfo { get; init; }
	public required Unit Unit { get; init; }
	public required User CreatedBy { get; init; }
	public required TechnicianCapability IssueType { get; init; }
	public Technician? AssignedTechnician { get; set; } = null;
	public ICollection<TicketComment> Comments { get; set; } = [];	
}