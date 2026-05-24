namespace Domain.ValueObjects;

public record PropertyInfo
{
	public record Address
	{
		public int Number { get; set; } = 0;
		public string Street { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string PostalCode { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;
		
	}

	public string WebPage { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
}