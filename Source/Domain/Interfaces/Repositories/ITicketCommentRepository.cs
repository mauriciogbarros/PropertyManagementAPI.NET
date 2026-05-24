using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface ITicketCommentRepository
{
	Task AddAsync(TicketComment ticketComment, CancellationToken ct);
	Task<ICollection<TicketComment>> GetAllAsync(CancellationToken ct);
	Task<TicketComment> GetByIdAsync(CancellationToken ct);
	Task UpdateAsync(TicketComment ticketComment, CancellationToken ct);
	Task DeleteAsync(CancellationToken ct);
}