using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Ticket : BaseEntity
{
	private readonly List<TicketComment> _comments = [];

	public required TicketInfo TicketInfo { get; init; }
	public required TicketStatus Status { get; set; } = TicketStatus.Open;
	public required Unit Unit { get; init; }
	public required User CreatedBy { get; init; }
	public required TechnicianCapability IssueType { get; init; }
	public Technician? AssignedTechnician { get; private set; } = null;
	public IReadOnlyCollection<TicketComment> Comments => _comments.AsReadOnly();

	public void AddComment(TicketComment comment)
	{
		ArgumentNullException.ThrowIfNull(comment);
		
		_comments.Add(comment);
	}

	public void AssignTechnician(Technician technician)
	{
		ArgumentNullException.ThrowIfNull(technician);

		if (Status == TicketStatus.Closed)
			throw new InvalidOperationException("Cannot assign a technician to a closed ticket.");

		AssignedTechnician = technician;
	}
}