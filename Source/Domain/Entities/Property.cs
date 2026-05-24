using Domain.Entities.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Property
{
	public PropertyInfo? Info { get; init; } = default;
	
	private readonly List<Unit> _units = [];
	public IReadOnlyCollection<Unit> Units => _units.AsReadOnly();

	private readonly List<User> _users = [];
	public IReadOnlyCollection<User> Users => _users.AsReadOnly();
}