using Domain.Results;

namespace Domain.ValueObjects;

public record PropertyInfo
{
	public record Address
	{
		public int Number { get; init; }
		public string Street { get; init; }
		public string City { get; init; }
		public string State { get; init; }
		public string PostalCode { get; init; }
		public string Country { get; init; }
		
		private Address(
			int number,
			string street,
			string city,
			string state,
			string postalCode,
			string country
		)
		{
			Number = number;
			Street = street;
			City = city;
			State = state;
			PostalCode = postalCode;
			Country = country;
		}

		public static Result<Address> Create(
			int number,
			string street,
			string city,
			string state,
			string postalCode,
			string country
		)
		{
			if (number <= 0)
				return Result.Failure<Address>(
					new Error("Address.NumberLessThanOrEqualToZero", "Street number must be greater than 0")
					);
			if (string.IsNullOrWhiteSpace(street))
				return Result.Failure<Address>(
					new Error("Address.StreetRequired", "Street is required")
				);
			if (string.IsNullOrWhiteSpace(city))
				return Result.Failure<Address>(
					new Error("Address.CityRequired", "City is required")
				);
			if (string.IsNullOrWhiteSpace(state))
				return Result.Failure<Address>(
					new Error("Address.StateRequired", "State is required.")
				);
			if (string.IsNullOrWhiteSpace(postalCode))
				return Result.Failure<Address>(
					new Error("Address.PostCodeRequired", "Postal code is required")
				);
			if (string.IsNullOrWhiteSpace(country))
				return Result.Failure<Address>(
					new Error("Address.CountryRequired", "Country is required")
				);
			
			return Result.Success(new Address(number, street, city, state, postalCode, country));
		}
	}

	public string? WebPage { get; set; }
}