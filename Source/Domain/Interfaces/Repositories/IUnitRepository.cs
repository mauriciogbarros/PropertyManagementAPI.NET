using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IUnitRepository
{
	Task AddAsync(Unit unit, CancellationToken ct);
	Task<ICollection<Unit>> GetAllAsync(CancellationToken ct);
	Task<Unit> GetByIdAsync(CancellationToken ct);
	Task UpdateAsync(Unit unit, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);
}