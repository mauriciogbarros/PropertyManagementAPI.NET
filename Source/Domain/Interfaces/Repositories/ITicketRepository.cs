using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ITicketRepository
{
	Task AddAsync(Ticket ticket, CancellationToken ct);
	Task<ICollection<Ticket>> GetAllAsync(CancellationToken ct);
	Task<Ticket> GetByIdAsync(CancellationToken ct);
	Task UpdateAsync(Ticket ticket, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);
}