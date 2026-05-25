using Domain.Results;

namespace Domain.ValueObjects;

public record UserInfo
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
	public string Email { get; init; }
	public string PhoneNumber { get; init; }

	private UserInfo(
		string firstName,
		string lastName,
		string email,
		string phoneNumber
	)
	{
		FirstName = firstName;
		LastName = lastName;
		Email = email;
		PhoneNumber = phoneNumber;
	}

	public static Result<UserInfo> Create(
		string firstName,
		string lastName,
		string email,
		string phoneNumber
	)
	{
		if (string.IsNullOrWhiteSpace(firstName))
			return Result.Failure<UserInfo>(
				new Error("UserInfo.FirstNameRequired", "First name is required.")
			);

		if (string.IsNullOrWhiteSpace(lastName))
			return Result.Failure<UserInfo>(
				new Error("UserInfo.LastNameRequired", "Last name is required.")
			);

		if (string.IsNullOrWhiteSpace(email))
			return Result.Failure<UserInfo>(
				new Error("UserInfo.Email", "Email is required")
			);

		if (string.IsNullOrWhiteSpace(phoneNumber))
			return Result.Failure<UserInfo>(
				new Error("UserInfo.PhoneNumber", "Phone number is required.")
			);

		return Result.Success(
			new UserInfo(firstName, lastName, email, phoneNumber)
		);
	}
}