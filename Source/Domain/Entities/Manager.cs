using Domain.Entities.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public sealed class Manager : Staff
{
	public Manager()
	{
		Role = UserRole.Manager;
	}
}