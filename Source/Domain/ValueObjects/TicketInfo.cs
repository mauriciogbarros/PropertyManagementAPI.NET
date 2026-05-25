using Domain.Results;

namespace Domain.ValueObjects;

public record TicketInfo
{
	public string Title { get; init; }
	public string Description { get; init; }

	private TicketInfo(string title, string description)
	{
		Title = title;
		Description = description;
	}

	public static Result<TicketInfo> Create(
		string title,
		string description
	)
	{
		if (string.IsNullOrWhiteSpace(title))
			return Result.Failure<TicketInfo>(
				new Error("TicketInfo.TitleIsRequired", "Title must not be empty")
			);

		if (string.IsNullOrWhiteSpace(description))
			return Result.Failure<TicketInfo>(
				new Error("TicketInfo.DescriptionIsRequired", "Descriptioin must not be empty")
			);

		return Result.Success(new TicketInfo(title, description));
	}
}