using CaseManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseManagement.Infrastructure.Persistence;

public class CaseManagementDbContext : DbContext
{
    public CaseManagementDbContext(DbContextOptions<CaseManagementDbContext> options)
        : base(options)
    {
    }

    public DbSet<Case> Cases => Set<Case>();
}
