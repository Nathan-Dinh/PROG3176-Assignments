using assignment_1.src.domain.entity;

namespace assignment_1.src.infrastructure.repository.interfaces;

public interface IAgentsRepository
{
  Task<IEnumerable<Agents>> GetAllAsync();
  Task<Agents?> GetByIdAsync(int id);
  Task<Agents> CreateAsync(Agents agent);
  Task<Agents?> UpdateAsync(Agents agent);
  Task<bool> DeleteAsync(int id);
}
