namespace Domain.Entities.Abstractions;

public class Staff : User
{
	public required Property Property { get; set; }
	public DateTime? TerminationDate { get; set; }
	public decimal HourlyRate { get; set; } = 0;

}