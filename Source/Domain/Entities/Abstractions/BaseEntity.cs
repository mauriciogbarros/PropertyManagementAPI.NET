namespace Domain.Entities.Abstractions;

public abstract class BaseEntity
{
	public Guid Id { get; protected init; } = Guid.NewGuid();
	public required DateTimeOffset CreatedAt { get; init; } = DateTime.UtcNow;
	public DateTimeOffset? UpdatedAt { get; set; }
}