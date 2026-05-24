namespace Domain.Entities.Abstractions;

public abstract class BaseEntity
{
	public Guid Id { get; protected init; } = Guid.NewGuid();
	public required DateTime CreatedAt { get; init; } = DateTime.UtcNow;
	public DateTime UpdatedAt { get; set; }
}