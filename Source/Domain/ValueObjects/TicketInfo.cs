namespace Domain.ValueObjects;

public record TicketInfo
{
	public required string Title { get; init; }
	public required string Description { get; init; }
}