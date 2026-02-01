using Microsoft.EntityFrameworkCore;
using src.assignment_1.domain.entity;
using src.assignment_1.infrastructure.data;
using src.assignment_1.infrastructure.repository.interfaces;

namespace src.assignment_1.infrastructure.repository;

public class AgentsRepository : IAgentsRepository
{
    private readonly AppDbContext _context;

    public AgentsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Agents>> GetAllAsync()
    {
        return await _context.Agents.ToListAsync();
    }

    public async Task<Agents?> GetByIdAsync(int id)
    {
        return await _context.Agents.FindAsync(id);
    }

    public async Task<Agents> CreateAsync(Agents agent)
    {
        _context.Agents.Add(agent);
        await _context.SaveChangesAsync();
        return agent;
    }

    public async Task<Agents?> UpdateAsync(Agents agent)
    {
        var existingAgent = await _context.Agents.FindAsync(agent.Id);
        if (existingAgent == null)
            return null;

        existingAgent.FirstName = agent.FirstName;
        existingAgent.LastName = agent.LastName;
        existingAgent.CodeName = agent.CodeName;
        existingAgent.Active = agent.Active;

        await _context.SaveChangesAsync();
        return existingAgent;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var agent = await _context.Agents.FindAsync(id);
        if (agent == null)
            return false;

        _context.Agents.Remove(agent);
        await _context.SaveChangesAsync();
        return true;
    }
}
