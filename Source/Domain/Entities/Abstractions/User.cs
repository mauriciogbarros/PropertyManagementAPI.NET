using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities.Abstractions;
public abstract class User : BaseEntity
{
	public required UserInfo UserInfo { get; set; }
	public required UserRole Role { get; init; }
}