using System.ComponentModel.DataAnnotations;
using App.Base;
using Base.Domain;


namespace App.DAL.DTO;

public class Team : DomainEntityId
{
    [Display( ResourceType = typeof(App.Resourses.App.Domain.Team), Name = nameof(App.Resourses.App.Domain.Team.Name))]
    public string? Name { get; set; }

    public ICollection<UserInTeam>? UserInTeams { get; set; }
    public ICollection<TeamInProject>? TeamInProjects { get; set; }
}