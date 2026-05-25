using Domain.Results;

namespace Domain.Entities.Abstractions;

public class Staff : User
{
	public required Property Property { get; set; }
	public DateTimeOffset? TerminationDate { get; private set; }
	public decimal HourlyRate { get; private set; }

	public Result SetHourlyRate(decimal hourlyRate)
	{
		if (hourlyRate < 0)
			return Result.Failure(
				new Error("Staff.HourlyRateNegative", "Hourly rate must be greater than $0.00")
			);

		HourlyRate = hourlyRate;

		return Result.Success();
	} 


	public Result TerminateStaff(DateTimeOffset terminationDate)
	{
		if (terminationDate < CreatedAt)
			return Result.Failure(
				new Error("Staff.TerminateBeforeCreate", "Termination date cannot be prior to creation date.")
			);

		TerminationDate = terminationDate;

		return Result.Success();
	}
}