using System.ComponentModel.DataAnnotations;
using assignment_1.src.domain.entity.interfaces;

namespace assignment_1.src.domain.entity;

public class Agents : IAgents
{
  public int Id { get; set; }

  [Required]
  public string FirstName { get; set; } = string.Empty;

  [Required]
  public string LastName { get; set; } = string.Empty;

  public string CodeName { get; set; } = string.Empty;

  public bool Active { get; set; } = false;
}
