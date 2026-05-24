namespace Domain.Entities.Abstractions;

public class Staff : User
{
	private DateTimeOffset? _terminationDate = null;
	private decimal _hourlyRate;

	public required Property Property { get; set; }
	public DateTimeOffset? TerminationDate
	{
		get => _terminationDate;
		set
		{
			if (TerminationDate <= CreatedAt)
				throw new ArgumentException("Termination date must be greater than user creation date.");

			_terminationDate = TerminationDate;
		}
	}
	public required decimal HourlyRate
	{
		get => _hourlyRate;
		set
		{
			if (HourlyRate < 0)
				throw new ArgumentException("Hourly rate must be greater than $0.00", nameof(HourlyRate));
			_hourlyRate = HourlyRate;
		} 
	}
}