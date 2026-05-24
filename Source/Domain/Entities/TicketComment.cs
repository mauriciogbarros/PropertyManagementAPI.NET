using Domain.Entities.Abstractions;

namespace Domain.Entities;

public class TicketComment
{
	public required string Comment { get; init; }
	public required User CommentedBy { get; init; }
	public DateTime CommentedOn { get; init; } = DateTime.UtcNow;
	public required Ticket Ticket { get; init; }
}