namespace Domain.ValueObjects;

public record UserInfo
{
	public string FirstName { get; init; } = string.Empty;
	public string LastName { get; init; } = string.Empty;
	public string Email { get; init; } = string.Empty;
	public string PhoneNumber { get; init; }  = string.Empty;

	public UserInfo(
		string firstName,
		string lastName,
		string email,
		string phoneNumber
	)
	{
		if (string.IsNullOrWhiteSpace(firstName))
			throw new ArgumentException("First name is required", nameof(firstName));
		if (string.IsNullOrWhiteSpace(lastName))
			throw new ArgumentException("Last name is required", nameof(lastName));
		if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
			throw new ArgumentException("A valid email is required", nameof(email));
		if (string.IsNullOrWhiteSpace(phoneNumber))
			throw new ArgumentException("Phone number is required", nameof(phoneNumber));

		FirstName = firstName;
		LastName = lastName;
		Email = email;
		PhoneNumber = phoneNumber;
	}
}