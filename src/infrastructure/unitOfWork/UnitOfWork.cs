using src.assignment_1.infrastructure.data;
using src.assignment_1.infrastructure.repository;
using src.assignment_1.infrastructure.repository.interfaces;

namespace src.assignment_1.infrastructure.unitOfWork;

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
