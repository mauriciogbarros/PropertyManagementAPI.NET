using Domain.Entities.Abstractions;
using Domain.Results;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Property : BaseEntity
{
	private readonly List<Unit> _units = [];
	private readonly List<User> _users = [];
	
	public required PropertyInfo Info { get; set; }
	public IReadOnlyCollection<Unit> Units => _units.AsReadOnly();
	public IReadOnlyCollection<User> Users => _users.AsReadOnly();

	public Result AddUnit(Unit unit)
	{
		if (unit is null)
			return Result.Failure(
				new Error("Property.NullUnit", "Unit cannot be null.")
			);

		if(_units.Any(u => u.Id == unit.Id))
			return Result.Failure(
				new Error("Property.UnitAlreadyExists", "Unit already exists in this property.")
			);

		_units.Add(unit);

		return Result.Success();
	}

	public Result AddUser(User user)
	{
		if (user is null)
			return Result.Failure(
				new Error("Property.UserNull", "User cannot be null.")
			);

		if (_users.Any(u => u.Id == user.Id))
			return Result.Failure(
				new Error("Property.UserAlreadyExists", "User already exists in this property.")
			);
			
		_users.Add(user);

		return Result.Success();
	}
}