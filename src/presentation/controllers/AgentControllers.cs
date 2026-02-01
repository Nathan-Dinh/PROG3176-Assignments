using Microsoft.AspNetCore.Mvc;
using src.assignment_1.domain.entity;
using src.assignment_1.infrastructure.unitOfWork;

namespace src.assignment_1.presentation.controllers;

[ApiController]
[Route("api/[controller]")]
public class AgentsController : ControllerBase
{
    private readonly UnitOfWork _unitOfWork;

    public AgentsController(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Agents>>> GetAll()
    {
        var agents = await _unitOfWork.AgentsRepository.GetAllAsync();
        return Ok(agents);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Agents>> GetById(int id)
    {
        var agent = await _unitOfWork.AgentsRepository.GetByIdAsync(id);
        if (agent == null)
            return NotFound();

        return Ok(agent);
    }

    [HttpPost]
    public async Task<ActionResult<Agents>> Create(Agents agent)
    {
        var createdAgent = await _unitOfWork.AgentsRepository.CreateAsync(agent);
        return CreatedAtAction(nameof(GetById), new { id = createdAgent.Id }, createdAgent);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Agents>> Update(int id, Agents agent)
    {
        if (id != agent.Id)
            return BadRequest();

        var updatedAgent = await _unitOfWork.AgentsRepository.UpdateAsync(agent);
        if (updatedAgent == null)
            return NotFound();

        return Ok(updatedAgent);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _unitOfWork.AgentsRepository.DeleteAsync(id);
        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
