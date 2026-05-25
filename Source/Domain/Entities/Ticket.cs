using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.Results;
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

	public Result AddComment(TicketComment comment)
	{
		if (comment is null)
			return Result.Failure(
				new Error("Ticket.CommentNull", "Comment cannot be null")
			);
		
		_comments.Add(comment);

		return Result.Success();
	}

	public Result AssignTechnician(Technician technician)
	{
		if (technician is null)
			return Result.Failure(
				new Error("Ticket.AssignedTechnicianNull", "Assigned technician cannot be null.")
			);

		if (Status == TicketStatus.Closed)
			return Result.Failure(
				new Error("Ticket.TicketClosed", "Cannot assign a technician to a closed ticket.")
			);

		AssignedTechnician = technician;

		return Result.Success();
	}
}