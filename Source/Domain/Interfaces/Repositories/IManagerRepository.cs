using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IManagerRepository
{
	Task AddAsync(Manager manager, CancellationToken ct);
	Task<ICollection<Manager>> GetAllAsync(CancellationToken ct);
	Task<Manager> GetByIdAsync(CancellationToken ct);
	Task UpdateAsync(Manager manager, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);	
}