using src.assignment_1.domain.entity;

namespace src.assignment_1.infrastructure.repository.interfaces;

public interface IAgentsRepository
{
    Task<IEnumerable<Agents>> GetAllAsync();
    Task<Agents?> GetByIdAsync(int id);
    Task<Agents> CreateAsync(Agents agent);
    Task<Agents?> UpdateAsync(Agents agent);
    Task<bool> DeleteAsync(int id);
}
