using App.Domain.Base;

namespace App.Domain;

public class IdeaInfeed : IBaseItem
{
    public Guid Id { get; set; }
    public IdeaFeedProfile? IdeaFeedProfile { get; set; }
    public Guid IdeaFeedProfileid { get; set; }

    public Guid ProjectIdeaId { get; set; }
    public ProjectIdea? ProjectIdea { get; set; }
}