namespace Domain.ValueObjects;

public record PropertyInfo
{
	public record Address
	{
		public required int Number { get; init; }
		public required string Street { get; init; }
		public required string City { get; init; }
		public required string State { get; init; }
		public required string PostalCode { get; init; }
		public required string Country { get; init; }
		
		public Address(
			int number,
			string street,
			string city,
			string state,
			string postalCode,
			string country
		)
		{
			if (number < 0)
				throw new ArgumentException("Street number must be greater than 0", nameof(number));
			if (string.IsNullOrWhiteSpace(street))
				throw new ArgumentException("Street is required", nameof(street));
			if (string.IsNullOrWhiteSpace(city))
				throw new ArgumentException("City is required", nameof(city));
			if (string.IsNullOrWhiteSpace(state))
				throw new ArgumentException("State is required.");
			if (string.IsNullOrWhiteSpace(postalCode))
				throw new ArgumentException("Postal code is required", nameof(postalCode));
			if (string.IsNullOrWhiteSpace(country))
				throw new ArgumentException("Country is required", nameof(country));

			Number = number;
			Street = street;
			City = city;
			State = state;
			PostalCode = postalCode;
			Country = country;
		}
	}

	public string? WebPage { get; set; }
}