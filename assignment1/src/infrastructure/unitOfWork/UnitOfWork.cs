using assignment_1.src.infrastructure.data;
using assignment_1.src.infrastructure.repository;
using assignment_1.src.infrastructure.repository.interfaces;

namespace assignment_1.src.infrastructure.unitOfWork;

public class UnitOfWork
{
  private readonly AppDbContext _context;
  private readonly IAgentsRepository _agentsRepository;

  public UnitOfWork(AppDbContext context)
  {
    _context = context;
    _agentsRepository = new AgentsRepository(_context);
  }

  public IAgentsRepository AgentsRepository => _agentsRepository;
}
