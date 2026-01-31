using System.ComponentModel.DataAnnotations;

namespace src.assignment_1.domain.entity;

public class Agent
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    public string CodeName { get; set; } = string.Empty;

    public bool Active { get; set; } = false;
}
