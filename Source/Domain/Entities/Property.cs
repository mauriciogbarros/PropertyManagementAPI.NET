using Domain.Entities.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Property
{
	public PropertyInfo? Info { get; init; } = default;
	public ICollection<Unit> Units { get; set; } = [];
	public ICollection<User> Users { get; set; } = [];
}