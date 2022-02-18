using Domain.App.Base;

namespace Domain.App;

public class IdeaTag : IBaseItem
{
    public Guid Id { get; set; }
    
    public Guid ProjectIdeaId { get; set; }
    public ProjectIdea? ProjectIdea { get; set; } = default!;
    
    public Guid TagId { get; set; }
    public Tag? Tag { get; set; } = default!;
}