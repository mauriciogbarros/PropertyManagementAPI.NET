using Domain.Entities.Abstractions;

namespace Domain.Entities;

public sealed class TicketComment : BaseEntity
{
	public required string Comment { get; init; }
	public required User CommentedBy { get; init; }
	public required Ticket Ticket { get; init; }
}