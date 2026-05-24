using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities.Abstractions;
public abstract class User : BaseEntity
{
	public UserInfo UserInfo { get; set; } = default!;
	public UserRole Role { get; init; }
}