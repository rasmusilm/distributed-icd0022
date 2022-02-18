using Domain.App.Base;
using Domain.App.Identity;

namespace Domain.App;

public class UserInTeam : IBaseItem
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public Guid TeamId { get; set; }
    public Team? Team { get; set; }
}