namespace Domain.ValueObjects;

public record TicketInfo
{
	public required string Title { get; init; }
	public required string Description { get; init; }

	public TicketInfo(string title, string description)
	{
		if (string.IsNullOrWhiteSpace(title))
			throw new ArgumentException("Title must not be empty", nameof(title));
		if (string.IsNullOrWhiteSpace(description))
			throw new ArgumentException("Descriptioin must not be empty", nameof(description));

		Title = title;
		Description = description;
	}
}