using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Ticket : BaseEntity
{
	public required TicketInfo TicketInfo { get; init; }
	public required TicketStatus Status { get; set; } = TicketStatus.Open;
	public required Unit Unit { get; init; }
	public required User CreatedBy { get; init; }
	public required TechnicianCapability IssueType { get; init; }
	public Technician? AssignedTechnician { get; set; }

	private readonly List<TicketComment> _comments = [];
	public IReadOnlyCollection<TicketComment> Comments => _comments.AsReadOnly();

	public void AddComment(TicketComment comment)
	{
		_comments.Add(comment);
	}
}