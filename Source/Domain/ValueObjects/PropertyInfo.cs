namespace Domain.ValueObjects;

public record PropertyInfo
{
	public record Address
	{
		public int Number { get; init; } = 0;
		public string Street { get; init; } = string.Empty;
		public string City { get; init; } = string.Empty;
		public string State { get; init; } = string.Empty;
		public string PostalCode { get; init; } = string.Empty;
		public string Country { get; init; } = string.Empty;
		
	}

	public string WebPage { get; init; } = string.Empty;
	public string Email { get; init; } = string.Empty;
}