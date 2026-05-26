using Domain.Entities;
using Domain.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
	public DbSet<Property> Properties => Set<Property>();
	public DbSet<User> Users => Set<User>();
	public DbSet<Unit> Units => Set<Unit>();
	public DbSet<Ticket> Tickets => Set<Ticket>();
	public DbSet<TicketComment> TicketComments => Set<TicketComment>();

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder mb)
	{
		mb.ApplyConfigurationsFromAssembly(
			typeof(AppDbContext).Assembly
		);

		base.OnModelCreating(mb);
	}
}