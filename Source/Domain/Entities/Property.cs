using Domain.Entities.Abstractions;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Property
{
	private readonly List<Unit> _units = [];
	private readonly List<User> _users = [];
	
	public required PropertyInfo Info { get; set; }
	public IReadOnlyCollection<Unit> Units => _units.AsReadOnly();
	public IReadOnlyCollection<User> Users => _users.AsReadOnly();

	public void AddUnit(Unit unit)
	{
		ArgumentNullException.ThrowIfNull(unit);
		if(_units.Any(u => u.Id == unit.Id))
			throw new InvalidOperationException("Unit already exists in this property.");

		_units.Add(unit);
	}

	public void AddUser(User user)
	{
		ArgumentNullException.ThrowIfNull(user);
		if (_users.Any(u => u.Id == user.Id))
			throw new InvalidOperationException("User already exists in this property.");
			
		_users.Add(user);
	}
}