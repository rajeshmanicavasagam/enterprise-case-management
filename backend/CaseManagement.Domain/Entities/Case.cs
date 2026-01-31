using CaseManagement.Domain.Enums;

namespace CaseManagement.Domain.Entities;

public class Case
{
    public Guid Id { get; set; }
    public string CaseNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public CaseStatus Status { get; set; } = CaseStatus.Open;
    public int Priority { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
