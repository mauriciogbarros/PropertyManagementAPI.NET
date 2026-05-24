using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ITechnicianRepository
{
	Task AddAsync(Technician technician, CancellationToken ct);
	Task<ICollection<Technician>> GetAllAsync(CancellationToken ct);
	Task<Technician> GetByIdAsync(CancellationToken ct);
	Task UpdateAsync(Technician technician, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);
}