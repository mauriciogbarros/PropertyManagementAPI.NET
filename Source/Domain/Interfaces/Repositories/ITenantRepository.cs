using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ITenantRepository
{
	Task AddAsync(Tenant tenant, CancellationToken ct);
	Task<ICollection<Tenant>> GetAllAsync(CancellationToken ct);
	Task<Tenant> GetBydIdAsync(CancellationToken ct);
	Task UpdateAsync(Tenant tenant, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);
}