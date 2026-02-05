namespace assignment_1.src.domain.entity.interfaces;

public interface IAgents
{
  int Id { get; set; }
  string FirstName { get; set; }
  string LastName { get; set; }
  string CodeName { get; set; }
  bool Active { get; set; }
}
