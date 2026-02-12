using Microsoft.AspNetCore.Mvc;
using assignment_1.src.domain.entity;
using assignment_1.src.infrastructure.unitOfWork;

namespace assignment_1.src.presentation.controllers;

[ApiController]
[Route("api/[controller]")]
public class AgentsController(UnitOfWork unitOfWork) : ControllerBase
{
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Agents>>> GetAll()
  {
    var agents = await unitOfWork.AgentsRepository.GetAllAsync();
    return Ok(agents);
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Agents>> GetById(int id)
  {
    var agent = await unitOfWork.AgentsRepository.GetByIdAsync(id);
    if (agent == null)
      return NotFound();

    return Ok(agent);
  }

  [HttpPost]
  public async Task<ActionResult<Agents>> Create(Agents agent)
  {
    var createdAgent = await unitOfWork.AgentsRepository.CreateAsync(agent);
    return CreatedAtAction(nameof(GetById), new { id = createdAgent.Id }, createdAgent);
  }

  [HttpPut("{id}")]
  public async Task<ActionResult<Agents>> Update(int id, Agents agent)
  {
    if (id != agent.Id)
      return BadRequest();

    var updatedAgent = await unitOfWork.AgentsRepository.UpdateAsync(agent);
    if (updatedAgent == null)
      return NotFound();

    return Ok(updatedAgent);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    var deleted = await unitOfWork.AgentsRepository.DeleteAsync(id);
    if (!deleted)
      return NotFound();

    return NoContent();
  }
}
